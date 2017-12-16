using System;
using System.Collections.Concurrent;
using System.Threading;
using BankSystem.Models.DB;
using BankSystem.Models.User.Account;
using BankSystem.Utils;

namespace BankSystem.Models.Transaction
{
    public class TransactionHandler
    {
        private readonly object _syncLock = new object();

        private readonly ConcurrentQueue<Transaction> _transactions;
        private Account _account;

        private User.User _user;


        internal TransactionHandler()
        {
            _transactions = new ConcurrentQueue<Transaction>();

            var maxNumOfThreads = Environment.ProcessorCount;
            ThreadPool.SetMaxThreads(maxNumOfThreads, maxNumOfThreads);
        }

        internal event FinishTransaction OnTransactionFinished;

        internal void Enquequ(Transaction transaction)
        {
            _transactions.Enqueue(transaction);
            ThreadPool.QueueUserWorkItem(HandleTransaction);
        }

        private void HandleTransaction(object state)
        {
            lock (_syncLock)
            {
                _transactions.TryDequeue(out var transaction);
                if (transaction == null) return;

                var ownerId = transaction.OwnerId;
                var accountId = transaction.AccountId;
                var transactionType = transaction.Type;
                var amount = transaction.Amount;

                var dbManager = DbManager.GetInstance();
                _user = dbManager.GetUserDataBase().Get(ownerId);
                _account = dbManager.GetAccountDatabase().Get(accountId);

                TransactionStatus status;

                try
                {
                    MakeTransaction(transactionType, amount);
                    status = TransactionStatus.Success;
                }
                catch (NotEnoughMoneyException e)
                {
                    status = TransactionStatus.Error;
                    transaction.ErrorMessage = e.Message;
                }
                catch (UnknowTransactionException e)
                {
                    status = TransactionStatus.Error;
                    transaction.ErrorMessage = e.Message;
                }
                catch (Exception)
                {
                    status = TransactionStatus.Error;
                    transaction.ErrorMessage = "Unknown error";
                }

                transaction.Status = status;
                transaction.Time = GetCurrentTime();
                transaction.TransactionId = GenerateId();


                AccountUtils.RegisterTransaction(_account.Id, transaction);

                OnTransactionFinished?.Invoke(transaction);
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        /// <exception cref="NotEnoughMoneyException"></exception>
        /// <exception cref="UnknowTransactionException"></exception>
        private void MakeTransaction(TransactionType type, decimal amount)
        {
            switch (type)
            {
                case TransactionType.Deposit:
                {
                    _account.Deposit(amount);
                    break;
                }
                case TransactionType.Withdraw:
                {
                    _account.Withdraw(amount);
                    break;
                }
                default:
                {
                    throw new UnknowTransactionException("Unknown transaction");
                }
            }
        }

        private static long GetCurrentTime()
        {
            return DateUtils.GetCurrentTime();
        }

        private int GenerateId()
        {
            //TODO generate id
            return (int) GetCurrentTime() / _user.GetHashCode();
        }

        internal delegate void FinishTransaction(Transaction transaction);
    }
}
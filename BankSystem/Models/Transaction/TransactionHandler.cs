using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using BankSystem.Models.DB;
using BankSystem.Models.User.Account;
using BankSystem.Utils;

namespace BankSystem.Models.Transaction
{
    public class TransactionHandler
    {
        internal delegate void FinishTransaction();

        internal event FinishTransaction OnTransactionFinished;

        private readonly ConcurrentQueue<Transaction> _transactions;
        private readonly object _syncLock = new object();


        public TransactionHandler()
        {
            _transactions = new ConcurrentQueue<Transaction>();
        }

        internal void Enquequ(Transaction transaction)
        {
            _transactions.Enqueue(transaction);
            new Thread(StartTransaction).Start();
        }


        private User.User _user;
        private Account _account;

        private void StartTransaction()
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

                var status = _user.HasAccount(_account.Id)
                    ? MakeTransaction(transactionType, amount)
                    : TransactionStatus.Error;

                transaction.Status = status;
                transaction.Time = GetCurrentTime();
                transaction.TransactionId = GenerateId();

                SaveToDb(transaction);
            }
        }

        private TransactionStatus MakeTransaction(TransactionType type, decimal amount)
        {
            try
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
                        throw new Exception("Unknown transaction");
                    }
                }
            }
            catch (Exception)
            {
                return TransactionStatus.Error;
            }
            return TransactionStatus.Success;
        }

        private long GetCurrentTime()
        {
            return DateUtils.getCurrentTime();
        }

        private int GenerateId()
        {
            //TODO generate id
            return (int) (GetCurrentTime() / (1000 * _user.GetHashCode()));
        }

        private void SaveToDb(Transaction transaction)
        {
            new Thread(() => { DbManager.GetInstance().GetTransactionDataBase().Put(transaction); }).Start();
        }
    }
}
﻿using BankSystem.Atm.Transactions;
using BankSystem.DB;
using BankSystem.Models;
using BankSystem.Models.User.Account;

namespace BankSystem.Atm
{
    public class Session
    {
        public delegate void TransactionFinished(int transactionId, bool isSuccessful);

        public delegate void TransactionStarted();

        private readonly Account _account;

        private readonly Models.Atm _atm;
        private readonly DbManager _dbManager = DbManager.GetInstance();

        private readonly TransactionManager _transactionManager;
        private readonly Models.User.User _user;

        /// <summary>
        /// </summary>
        /// <param name="atm"></param>
        /// <param name="accountId"></param>
        /// <exception cref="IllegalStateException"></exception>
        public Session(Models.Atm atm, int accountId)
        {
            _atm = atm;

            _account = _dbManager.GetAccountDatabase().Get(accountId);
            if (_account == null) throw new IllegalStateException("Account not found");
            _user = _dbManager.GetUserDataBase().Get(_account.OwnerId);
            if (_user == null) throw new IllegalStateException("User not found");

            _transactionManager = TransactionManager.GetInstance();
        }

        public event TransactionStarted OnTransactionStarted;
        public event TransactionFinished OnTransactionFinished;

        public string GetUserName()
        {
            if (_account == null || _user == null) throw new IllegalStateException();

            return _user.Name;
        }

        public string GetAccountBalance()
        {
            if (_account == null || _user == null) throw new IllegalStateException();

            return _account.Balance.ToString();
        }

        public string GetAccountBalanceOnCheck()
        {
            if (_account == null || _user == null) throw new IllegalStateException();

            return _account.ToString();
        }

        public void MakeTransaction(TransactionType type, decimal amount)
        {
            _transactionManager.OnTransactionFinished += FinishTransaction;
            OnTransactionStarted?.Invoke();

            var transactionBuilder = _transactionManager.CreateTransaction();
            transactionBuilder.SetAccountId(_account.GetId())
                .SetAmount(amount)
                .SetAtmId(_atm.GetId())
                .SetOwnerId(_user.GetId())
                .SetType(type)
                .Start();
        }

        public string GetCheck(int transactionId)
        {
            return _dbManager.GetTransactionDataBase().Get(transactionId).ToString();
        }

        public string GetErrorMessage(int transactionId)
        {
            return _dbManager.GetTransactionDataBase().Get(transactionId).ErrorMessage;
        }

        private void FinishTransaction(Transaction transaction)
        {
            var isSuccess = string.IsNullOrEmpty(transaction.ErrorMessage);
            OnTransactionFinished?.Invoke(transaction.GetId(), isSuccess);
        }
    }
}
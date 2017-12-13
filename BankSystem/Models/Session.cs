using BankSystem.Models.DB;
using BankSystem.Models.Transaction;
using BankSystem.Models.User.Account;

namespace BankSystem.Models
{
    public class Session
    {
        public delegate void TransactionFinished(int transactionId);

        public delegate void TransactionStarted();

        private readonly Account _account;

        private readonly Atm _atm;
        private readonly DbManager _dbManager = DbManager.GetInstance();

        private readonly TransactionManager _transactionManager;
        private readonly User.User _user;

        /// <summary>
        /// </summary>
        /// <param name="atm"></param>
        /// <param name="accountId"></param>
        /// <exception cref="IllegalStateException"></exception>
        public Session(Atm atm, int accountId)
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

        public string GetAccountBalance()
        {
            if (_account == null || _user == null) throw new IllegalStateException();

            return _account.Balance.ToString();
        }

        public void MakeTransaction(TransactionType type, decimal amount)
        {
            _transactionManager.OnTransactionFinished += FinishTransaction;

            _transactionManager.CreateTransaction()
                .SetAccountId(_account.GetId())
                .SetAmount(amount)
                .SetAtmId(_atm.GetId())
                .SetOwnerId(_user.GetId())
                .SetType(type)
                .Start();

            OnTransactionStarted?.Invoke();
        }

        public string GetCheck(int transactionId)
        {
            return _dbManager.GetTransactionDataBase().Get(transactionId).ToString();
        }

        private void FinishTransaction(Transaction.Transaction transaction)
        {
            OnTransactionFinished?.Invoke(transaction.GetId());
        }
    }
}
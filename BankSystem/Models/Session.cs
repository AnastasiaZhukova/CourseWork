using BankSystem.Models.DB;
using BankSystem.Models.Transaction;
using BankSystem.Models.User.Account;

namespace BankSystem.Models
{
    public class Session
    {
        public delegate void TransactionStarted();
        public event TransactionStarted OnTransactionStarted;

        public delegate void TransactionFinished(int transactionId);
        public event TransactionFinished OnTransactionFinished;

        private readonly Atm _atm;
        private readonly User.User _user;
        private readonly Account _account;

        private readonly TransactionManager _transactionManager;

        public Session(Atm atm, Account account)
        {
            _atm = atm;
            _user = DbManager.GetInstance().GetUserDataBase().Get(account.OwnerId);
            _account = account;
            _transactionManager = TransactionManager.GetInstance();
        }

        public void MakeTransaction(TransactionType type, decimal amount)
        {
            _transactionManager.OnTransactionFinished += Finish;

            _transactionManager.CreateTransaction()
                .SetAccountId(_account.GetId())
                .SetAmount(amount)
                .SetAtmId(_atm.GetId())
                .SetOwnerId(_user.GetId())
                .SetType(type)
                .Start();

            OnTransactionStarted?.Invoke();
        }

        private void Finish(Transaction.Transaction transaction)
        {
            OnTransactionFinished?.Invoke(transaction.GetId());
        }

        public string PrintCheck(int transactionId)
        {
            return DbManager.GetInstance().GetTransactionDataBase().Get(transactionId).ToString();
        }
    }
}
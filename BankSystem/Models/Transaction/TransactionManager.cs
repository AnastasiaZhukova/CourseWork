using BankSystem.Models.DB;

namespace BankSystem.Models.Transaction
{
    public class TransactionManager
    {
        private static volatile TransactionManager _instance;
        private static readonly object SyncLock = new object();

        private TransactionHandler _transactionHandler;

        private TransactionManager()
        {
            _transactionHandler = new TransactionHandler();
        }

        public static TransactionManager GetInstance()
        {
            if (_instance != null) return _instance;

            lock (SyncLock)
            {
                if (_instance != null) return _instance;

                _instance = new TransactionManager();
            }

            return _instance;
        }


        public TransactionBuilder CreateTransaction()
        {
            var handler = new TransactionHandler();

            return new TransactionBuilder();
        }

        internal void Start(Transaction transaction)
        {
            _transactionHandler.Enquequ(transaction);
        }

    }
}
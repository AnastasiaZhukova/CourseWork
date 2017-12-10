namespace BankSystem.Models.Transaction
{
    public class TransactionManager
    {
        public delegate void TransactionFinished(Transaction transaction);

        public event TransactionFinished OnTransactionFinished;

        private static volatile TransactionManager _instance;
        private static readonly object SyncLock = new object();

        private readonly TransactionHandler _transactionHandler;

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
            return new TransactionBuilder();
        }

        internal void Start(Transaction transaction)
        {
            _transactionHandler.OnTransactionFinished += OnFinish;
            _transactionHandler.Enquequ(transaction);
        }

        private void OnFinish(Transaction transaction)
        {
            OnTransactionFinished?.Invoke(transaction);
        }
    }
}
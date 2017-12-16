using BankSystem.Models.User.Account;
using Database;

namespace BankSystem.Models.DB
{
    public class DbManager
    {
        public const string SourceNotSetExceptionMessage = "Source provider not set";
        private static DbManager _instance;


        private static readonly object SyncLock = new object();

        private UpdateHandler<Account> _accountUpdateHandler;
        private UpdateHandler<Transaction.Transaction> _transactionUpdateHandler;
        private UpdateHandler<User.User> _userUpdateHandler;
        private volatile DataBase<Account> _accountDataBase;

        private IDbSourceProvider _sourceProvider;
        private volatile DataBase<Transaction.Transaction> _transactionDataBase;
        private volatile DataBase<User.User> _userDataBase;

        private DbManager()
        {
        }

        public static DbManager GetInstance()
        {
            if (_instance != null) return _instance;
            lock (SyncLock)
            {
                _instance = new DbManager();
            }

            return _instance;
        }

        public void SetSourceProvider(IDbSourceProvider provider)
        {
            _sourceProvider = provider;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        public void Initialize()
        {
            SetAccountDb();
            SetUsersDb();
            SetTransactionDb();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        private void SetAccountDb()
        {
            lock (SyncLock)
            {
                if (_accountDataBase != null) return;

                _accountDataBase = DbFactory.GetAccountDataBase(GetAccountDbSource());

                if (_accountDataBase == null) return;
                _accountUpdateHandler = new UpdateHandler<Account>(_accountDataBase);
                _accountDataBase.OnUpdate += _accountUpdateHandler.Save;
            }
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        private void SetUsersDb()
        {
            lock (SyncLock)
            {
                if (_userDataBase != null) return;

                _userDataBase = DbFactory.GetUserDataBase(GetUserDbSource());

                if (_userDataBase == null) return;
                _userUpdateHandler = new UpdateHandler<User.User>(_userDataBase);
                _userDataBase.OnUpdate += _userUpdateHandler.Save;
            }
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        private void SetTransactionDb()
        {
            lock (SyncLock)
            {
                if (_transactionDataBase != null) return;

                _transactionDataBase = DbFactory.GetTransactionDataBase(GetTransactionDbSource());

                if (_transactionDataBase == null) return;
                _transactionUpdateHandler = new UpdateHandler<Transaction.Transaction>(_transactionDataBase);
                _transactionDataBase.OnUpdate += _transactionUpdateHandler.Save;
            }
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        public DataBase<Account> GetAccountDatabase()
        {
            return _accountDataBase;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        public DataBase<User.User> GetUserDataBase()
        {
            return _userDataBase;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InvalidSourceException"></exception>
        /// <exception cref="SourceNotSetException"></exception>
        /// <returns></returns>
        public DataBase<Transaction.Transaction> GetTransactionDataBase()
        {
            return _transactionDataBase;
        }

        private IDbSource GetAccountDbSource()
        {
            if (_sourceProvider == null) throw new SourceNotSetException(SourceNotSetExceptionMessage);
            return _sourceProvider.GetAccountDbSource();
        }

        private IDbSource GetUserDbSource()
        {
            if (_sourceProvider == null) throw new SourceNotSetException(SourceNotSetExceptionMessage);
            return _sourceProvider.GetUserDbSource();
        }

        private IDbSource GetTransactionDbSource()
        {
            if (_sourceProvider == null) throw new SourceNotSetException(SourceNotSetExceptionMessage);
            return _sourceProvider.GetTransactionDbSource();
        }
    }
}
using System;
using BankSystem.Models.User.Account;
using Database;

namespace BankSystem.Models.DB
{
    public class DbManager
    {
        public const string SourceNotSetExceptionMessage = "Source provider not set";
        private static DbManager _instance;

        private readonly UpdateHandler<Account> _accountUpdateHandler;
        private volatile DataBase<Account> _accountDataBase;
        private readonly UpdateHandler<User.User> _userUpdateHandler;
        private volatile DataBase<User.User> _userDataBase;
        private readonly UpdateHandler<Transaction.Transaction> _transactionUpdateHandler;
        private volatile DataBase<Transaction.Transaction> _transactionDataBase;

        private IDbSourceProvider _sourceProvider;


        private static readonly object SyncLock = new object();

        private DbManager()
        {
            _accountUpdateHandler = new UpdateHandler<Account>(_accountDataBase);
            _userUpdateHandler = new UpdateHandler<User.User>(_userDataBase);
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
        /// 
        /// </summary>
        /// <exception cref="Exception">DbSourceProvider not set</exception>
        /// <returns></returns>
        public DataBase<Account> GetAccountDatabase()
        {
            if (_accountDataBase != null) return _accountDataBase;

            lock (SyncLock)
            {
                if (_accountDataBase != null) return _accountDataBase;

                _accountDataBase = DbFactory.GetAccountDataBase(GetAccountDbSource());

                if (_accountDataBase != null)
                {
                    _accountDataBase.OnUpdate += _accountUpdateHandler.Save;
                }
            }

            return _accountDataBase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception">DbSourceProvider not set</exception>
        /// <returns></returns>
        public DataBase<User.User> GetUserDataBase()
        {
            if (_userDataBase != null) return _userDataBase;

            lock (SyncLock)
            {
                if (_userDataBase != null) return _userDataBase;

                _userDataBase = DbFactory.GetUserDataBase(GetUserDbSource());

                if (_userDataBase != null)
                {
                    _userDataBase.OnUpdate += _userUpdateHandler.Save;
                }
            }

            return _userDataBase;
        }


        public DataBase<Transaction.Transaction> GetTransactionDataBase()
        {
            if (_transactionDataBase != null) return _transactionDataBase;

            lock (SyncLock)
            {
                if (_transactionDataBase != null) return _transactionDataBase;

                _transactionDataBase = DbFactory.GetTransactionDataBase(GetTransactionDbSource());

                if (_transactionDataBase != null)
                {
                    _transactionDataBase.OnUpdate += _transactionUpdateHandler.Save;
                }
            }

            return _transactionDataBase;
        }


        private IDbSource GetAccountDbSource()
        {
            if (_sourceProvider == null) throw new Exception(SourceNotSetExceptionMessage);
            return _sourceProvider.GetAccountDbSource();
        }

        private IDbSource GetUserDbSource()
        {
            if (_sourceProvider == null) throw new Exception(SourceNotSetExceptionMessage);
            return _sourceProvider.GetUserDbSource();
        }

        private IDbSource GetTransactionDbSource()
        {
            if (_sourceProvider == null) throw new Exception(SourceNotSetExceptionMessage);
            return _sourceProvider.GetTransactionDbSource();
        }
    }
}
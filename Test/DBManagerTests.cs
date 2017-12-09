using System;
using BankSystem.Models.DB;
using BankSystem.Models.User;
using BankSystem.Models.User.Account;
using Database;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DbManagerTests
    {
        private DbManager _dbManager;
        private DataBase<User> _userDataBase;
        private DataBase<Account> _accountDataBase;


        [SetUp]
        public void SetUp()
        {
            _dbManager = DbManager.GetInstance();
        }

        [Test]
        public void ShouldNotBeNull()
        {
            Assert.True(_dbManager != null);
        }

        [Test]
        public void SourceNotSetException()
        {
            try
            {
                _dbManager.GetAccountDatabase();
                _dbManager.GetUserDataBase();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, DbManager.SourceNotSetExceptionMessage);
            }
        }

        [Test]
        public void ZReadFromDb()
        {
            const int length = 10;


            var provider = new TestDbSourceProvider();
            _dbManager.SetSourceProvider(provider);


            _userDataBase = _dbManager.GetUserDataBase();
            _accountDataBase = _dbManager.GetAccountDatabase();


            Assert.True(_userDataBase != null);
            Assert.True(_accountDataBase != null);


            Assert.AreEqual(length, _userDataBase.GetAll().Count);
            Assert.True(_userDataBase.Get(0) != null);
            Assert.AreEqual(length, (_accountDataBase.GetAll().Count));
            Assert.True(_accountDataBase.Get(70) != null);
        }
    }
}
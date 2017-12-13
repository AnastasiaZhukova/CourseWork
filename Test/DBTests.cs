using BankSystem.Models.User;
using BankSystem.Models.User.Account;
using Database;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DbTests
    {
        [SetUp]
        public void SetUp()
        {
            _userHelper = new DbHelper<User>();
            _accountHelper = new DbHelper<Account>();

            _userSource = new TestSource(UserFile);
            _accountSource = new TestSource(AccountFile);
        }

        private DataBase<User> _userDataBase;
        private DataBase<Account> _accountDataBase;
        private DbHelper<User> _userHelper;
        private DbHelper<Account> _accountHelper;
        private TestSource _userSource;
        private TestSource _accountSource;

        private const string UserFile =
            "C:\\Users\\Asus\\Documents\\Visual Studio 2017\\Projects\\CourseWork_3_sem\\Test\\users.json";

        private const string AccountFile =
            "C:\\Users\\Asus\\Documents\\Visual Studio 2017\\Projects\\CourseWork_3_sem\\Test\\accounts.json";


        private void ReadDataBases()
        {
            _userDataBase = _userHelper.Read(_userSource);
            _accountDataBase = _accountHelper.Read(_accountSource);
        }


        [Test]
        public void ReadFromDb()
        {
            const int length = 10;

            ReadDataBases();

            Assert.True(_userDataBase != null);
            Assert.True(_accountDataBase != null);


            Assert.AreEqual(length, _userDataBase.GetAll().Count);
            Assert.True(_userDataBase.Get(0L) != null);
            Assert.AreEqual(length, _accountDataBase.GetAll().Count);
            Assert.True(_accountDataBase.Get(70L) != null);
        }

        [Test]
        public void SholdNotBeNull()
        {
            Assert.True(_userHelper != null);
            Assert.True(_accountHelper != null);
            Assert.True(_userSource != null);
            Assert.True(_accountSource != null);
        }


        [Test]
        public void UpdateDb()
        {
            ReadDataBases();

            var user = _userDataBase.Get(4);
            var account = _accountDataBase.Get(user.AccountId);

            var balance = account.Balance;
            var startMoney = balance.Amount;

            account.Withdraw(startMoney / 2);

            var newMoney = balance.Amount;

            Assert.AreNotEqual(startMoney, newMoney);

            _accountDataBase.Update(account);

            var afterUpdateAccount = _accountDataBase.Get(user.AccountId);
            var afterUpdateBalance = afterUpdateAccount.Balance;
            var afterUpdateMoney = afterUpdateBalance.Amount;


            Assert.AreNotEqual(startMoney, afterUpdateMoney);
            Assert.AreEqual(newMoney, afterUpdateMoney);
        }
    }
}
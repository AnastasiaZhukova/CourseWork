using System;
using System.Threading;
using BankSystem.Models.User.Account;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class AccountTest
    {
        [SetUp]
        public void SetUp()
        {
            _balance = new Balance(StartAmount);
            _account = new Account(Id, OwnerId, _balance);
        }

        private Account _account;
        private const int Id = 123;
        private const int OwnerId = 567;
        private Balance _balance;
        private const decimal StartAmount = 1000;

        [Test]
        public void MultithreadWithdraw()
        {
            try
            {
                var thread1 = new Thread(() => { _account.Withdraw(700); }) {Name = "Thread 1, 700"};
                var thread2 = new Thread(() => { _account.Withdraw(500); }) {Name = "Thread 2, 700"};
                var thread3 = new Thread(() => { _account.Withdraw(100); }) {Name = "Thread 3, 100"};


                thread1.Start();
                thread2.Start();
                thread3.Start();


                thread1.Join();
                thread2.Join();
                thread3.Join();
            }
            catch (Exception e)
            {
                Assert.NotNull(e);
            }

            Assert.AreNotEqual(StartAmount, _account.Balance.Amount);
        }

        [Test]
        public void SimpleWithdraw()
        {
            _account.Withdraw(100);
            Assert.AreNotEqual(StartAmount, _account.Balance.Amount);
        }
    }
}
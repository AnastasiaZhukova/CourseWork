using System.Collections.Generic;
using BankSystem.Atm.Utils;
using BankSystem.Models;
using BankSystem.Models.DB;
using BankSystem.Models.Transaction;
using BankSystem.Models.User;
using BankSystem.Models.User.Account;
using BankSystem.Utils;
using Database;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class TempTest
    {
        //todo remove constructors

        [Test]
        public void InitAtmSource()
        {
            DbSourceProvider sourceProvider = new DbSourceProvider();
            sourceProvider.UserDb = new DbFileSource("C:\\Users\\Asus\\Desktop\\usersDB.json");
            sourceProvider.AccountDb = new DbFileSource("C:\\Users\\Asus\\Desktop\\accountsDB.json");
            sourceProvider.TransactionDb = new DbFileSource("C:\\Users\\Asus\\Desktop\\transactionsDB.json");
            Atm atm = new Atm(111, sourceProvider);
            AtmSerializer serializer = new AtmSerializer();
            TestSource source=new TestSource("C:\\Users\\Asus\\Desktop\\atm.json");
            serializer.Write(atm,source.GetStream());
        }

        [Test]
        public void InitUsersSource()
        {
            DataBase<User> db = new DataBase<User>();

            for (var i = 1; i <= 100; i++)
            {
                db.Put(new User(i, "User №" + i, i * 10));
            }

            DbHelper<User> helper = new DbHelper<User>();
            TestSource source = new TestSource("C:\\Users\\Asus\\Desktop\\usersDB.json");
            helper.Write(db, source);
        }

        [Test]
        public void InitAccountSource()
        {
            DataBase<Account> db = new DataBase<Account>();

            for (var i = 1; i <= 100; i++)
            {
                int pin = 1000 * i + 100 * i + 10 * i + i;
                Balance balance = new Balance(i * 1000);
                List<int> transactions = new List<int>();
                db.Put(new Account(i * 10, pin, i, balance, transactions));
            }

            DbHelper<Account> helper = new DbHelper<Account>();
            TestSource source = new TestSource("C:\\Users\\Asus\\Desktop\\accountsDB.json");
            helper.Write(db, source);
        }

        [Test]
        public void InitTransactionSource()
        {
            DataBase<Transaction> db = new DataBase<Transaction>();

            DbHelper<Transaction> helper = new DbHelper<Transaction>();
            TestSource source = new TestSource("C:\\Users\\Asus\\Desktop\\transactionsDB.json");
            helper.Write(db, source);
        }
    }
}
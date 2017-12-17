using System;
using BankSystem.DB;
using Database;

namespace Test
{
    public class TestDbSourceProvider : IDbSourceProvider
    {
        //TODO change directories
        private const string UserFile =
            "C:\\Users\\Asus\\Documents\\Visual Studio 2017\\Projects\\CourseWork_3_sem\\Test\\users.json";

        private const string AccountFile =
            "C:\\Users\\Asus\\Documents\\Visual Studio 2017\\Projects\\CourseWork_3_sem\\Test\\accounts.json";


        public IDbSource GetUserDbSource()
        {
            return new TestSource(UserFile);
        }


        public IDbSource GetAccountDbSource()
        {
            return new TestSource(AccountFile);
        }

        public IDbSource GetTransactionDbSource()
        {
            //not used method
            return null;
        }
    }
}
using BankSystem.Models.DB;
using Database;

namespace Test
{
    public class TestDbSourceProvider : IDbSourceProvider
    {
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
            throw new System.NotImplementedException();
        }
    }
}
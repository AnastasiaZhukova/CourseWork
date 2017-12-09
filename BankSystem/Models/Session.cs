using BankSystem.Models.User.Account;

namespace BankSystem.Models
{
    public class Session
    {
        private ATM _atm;
        private User.User _user;
        private Account _account;

        public Session(ATM atm, User.User user, Account account)
        {
            _atm = atm;
            _user = user;
            _account = account;
        }
        
        

        public void PrintCheck(){}

    }
}
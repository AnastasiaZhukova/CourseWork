using BankSystem.Models;

namespace BankSystem.Atm
{
    public class SessionManager
    {
        private readonly Models.Atm _atm;

        public SessionManager(Models.Atm atm)
        {
            _atm = atm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        /// /// <exception cref="IllegalStateException"></exception>
        public Session StartNewSession(int accountId)
        {
            return new Session(_atm, accountId);
        }
    }
}
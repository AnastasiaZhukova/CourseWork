namespace BankSystem.Atm
{
    internal class SessionManager
    {
        private readonly Models.Atm _atm;

        internal SessionManager(Models.Atm atm)
        {
            _atm = atm;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        /// /// <exception cref="IllegalStateException"></exception>
        internal Session StartNewSession(int accountId)
        {
            return new Session(_atm, accountId);
        }
    }
}
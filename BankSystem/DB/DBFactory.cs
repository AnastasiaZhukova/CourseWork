using BankSystem.Models;
using BankSystem.Models.User.Account;
using Database;

namespace BankSystem.DB
{
    internal static class DbFactory
    {
        /// <summary>
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="InvalidSourceException"></exception>
        internal static DataBase<Account> GetAccountDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new InvalidSourceException("No such source");

            var helper = new DbHelper<Account>();
            return helper.Read(pSource);
        }

        /// <summary>
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="InvalidSourceException"></exception>
        internal static DataBase<Models.User.User> GetUserDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new InvalidSourceException("No such source");

            var helper = new DbHelper<Models.User.User>();
            return helper.Read(pSource);
        }

        /// <summary>
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="InvalidSourceException"></exception>
        internal static DataBase<Transaction> GetTransactionDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new InvalidSourceException("No such source");

            var helper = new DbHelper<Transaction>();
            return helper.Read(pSource);
        }
    }
}
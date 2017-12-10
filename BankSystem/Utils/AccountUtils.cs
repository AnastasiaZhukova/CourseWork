using System.Threading;
using BankSystem.Models.DB;
using BankSystem.Models.Transaction;

namespace BankSystem.Utils
{
    public static class AccountUtils
    {
        internal static void RegisterTransaction(int accountId, Transaction transaction)
        {
            new Thread(() =>
            {
                var accountDatabase = DbManager.GetInstance().GetAccountDatabase();

                var account = accountDatabase.Get(accountId);
                account.TransactionIds.Add(transaction.GetId());

                DbManager.GetInstance().GetTransactionDataBase().Put(transaction);
                accountDatabase.Update(account);
            }).Start();
        }

        public static bool IsPincodeCorrect(int accountId, int pin)
        {
            if (pin.ToString().Length != 4) return false;
            var pincode = DbManager.GetInstance().GetAccountDatabase().Get(accountId).Pin;
            return pin == pincode;
        }
    }
}
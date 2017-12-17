using System.Threading;
using BankSystem.DB;
using BankSystem.Models;

namespace BankSystem.Utils
{
    internal static class SessionUtils
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
    }
}
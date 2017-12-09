using System;
using BankSystem.Models.DB;
using Database;

namespace BankSystem.Utils
{
    public class ProgramSourcesProvider : IDbSourceProvider
    {
        //TODO implement
        public IDbSource GetUserDbSource()
        {
            throw new NotImplementedException();
        }

        public IDbSource GetAccountDbSource()
        {
            throw new NotImplementedException();
        }

        public IDbSource GetTransactionDbSource()
        {
            throw new NotImplementedException();
        }
    }
}
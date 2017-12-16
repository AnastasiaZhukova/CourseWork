using System.Runtime.Serialization;
using BankSystem.Models.DB;
using Database;

namespace BankSystem.Utils
{
    [DataContract(Name = "SourceProvider")]
    [KnownType(typeof(DbFileSource))]
    public class DbSourceProvider : IDbSourceProvider
    {
        [DataMember]
        private DbFileSource UserDb { get; set; }

        [DataMember]
        private DbFileSource AccountDb { get; set; }

        [DataMember]
        private DbFileSource TransactionDb { get; set; }

        public IDbSource GetUserDbSource()
        {
            return UserDb;
        }

        public IDbSource GetAccountDbSource()
        {
            return AccountDb;
        }

        public IDbSource GetTransactionDbSource()
        {
            return TransactionDb;
        }
    }
}
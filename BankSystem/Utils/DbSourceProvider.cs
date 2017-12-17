using System.Runtime.Serialization;
using BankSystem.DB;
using Database;

namespace BankSystem.Utils
{
    [DataContract(Name = "SourceProvider")]
    [KnownType(typeof(DbFileSource))]
    public class DbSourceProvider : IDbSourceProvider
    {
        //todo private
        [DataMember]
        public DbFileSource UserDb { get; set; }

        [DataMember]
        public DbFileSource AccountDb { get; set; }

        [DataMember]
        public DbFileSource TransactionDb { get; set; }

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
using System.Runtime.Serialization;
using BankSystem.Utils;
using Database;

namespace BankSystem.Models
{
    //todo must be internal, used onlu for generation json
    [DataContract(Name = "ATM")]
    [KnownType(typeof(DbSourceProvider))]
    public class Atm : IIdentifiable
    {
        [DataMember]
        internal int Id { get; private set; }

        public Atm(int id, DbSourceProvider sourceProvider)
        {
            Id = id;
            SourceProvider = sourceProvider;
        }

        [DataMember]
        public DbSourceProvider SourceProvider { get; private set; }

        public int GetId()
        {
            return Id;
        }
    }
}
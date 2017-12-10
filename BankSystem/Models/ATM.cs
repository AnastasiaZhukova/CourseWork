using System.Runtime.Serialization;
using Database;

namespace BankSystem.Models
{
    [DataContract(Name = "ATM")]
    public class Atm : IIdentifiable
    {
        [DataMember]
        internal int Id { get; private set; }

        [DataMember]
        internal int AvailableMoney { get; private set; }

        public int GetId()
        {
            return Id;
        }
    }
} 
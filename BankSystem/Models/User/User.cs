using System.Runtime.Serialization;
using Database;

namespace BankSystem.Models.User
{
    [DataContract(Name = "User")]
    public class User : IIdentifiable
    {
        internal User(int id, string name, long accountId)
        {
            Id = id;
            Name = name;
            AccountId = accountId;
        }

        [DataMember]
        internal int Id { get; private set; }

        [DataMember]
        internal string Name { get; private set; }

        [DataMember]
        internal long AccountId { get; private set; }

        public int GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
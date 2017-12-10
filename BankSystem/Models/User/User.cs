using System.Runtime.Serialization;
using Database;

namespace BankSystem.Models.User
{
    [DataContract(Name = "User")]
    public class User : IIdentifiable
    {
        [DataMember]
        internal int Id { get; private set; }

        [DataMember]
        internal string Name { get; private set; }

        [DataMember]
        internal long AccountId { get; private set; }

        internal User(int id, string name, long accountId)
        {
            Id = id;
            Name = name;
            AccountId = accountId;
        }

        public int GetId()
        {
            return Id;
        }
    }
}
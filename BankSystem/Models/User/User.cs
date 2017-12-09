using System.Runtime.Serialization;
using Database;

namespace BankSystem.Models.User
{
    [DataContract(Name = "User")]
    public class User : IIdentifiable
    {
        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public long AccountId { get; private set; }

        public User(int id, string name, long accountId)
        {
            Id = id;
            Name = name;
            AccountId = accountId;
        }

        public int GetId()
        {
            return Id;
        }

        public bool HasAccount(int accountId)
        {
            return AccountId == accountId;
        }
    }
}
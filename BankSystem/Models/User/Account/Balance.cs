using System.Runtime.Serialization;

namespace BankSystem.Models.User.Account
{
    [DataContract(Name = "Balance")]
    public class Balance
    {
        [DataMember]
        public decimal Amount { get; private set; }

        public Balance(decimal amount)
        {
            Amount = amount;
        }

        internal void Add(decimal pAmount)
        {
            Amount += pAmount;
        }

        internal void Subtract(decimal pAmount)
        {
            Amount -= pAmount;
        }

        public override string ToString()
        {
            return Amount.ToString();
        }
    }
}
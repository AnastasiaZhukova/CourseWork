using System.Globalization;
using System.Runtime.Serialization;

namespace BankSystem.Models.User.Account
{
    [DataContract(Name = "Balance")]
    public class Balance
    {
        [DataMember]
        internal decimal Amount { get; private set; }

        internal Balance(decimal amount)
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
            return Amount.ToString(CultureInfo.CurrentCulture);
        }
    }
}
using System.Runtime.Serialization;
using System.Text;
using BankSystem.Utils;
using Database;

namespace BankSystem.Models.Transaction
{
    [DataContract(Name = "Transaction")]
    [KnownType(typeof(TransactionType))]
    [KnownType(typeof(TransactionStatus))]
    public class Transaction : IIdentifiable
    {
        internal Transaction(TransactionBuilder pBuilder)
        {
            AtmId = pBuilder.AtmId;
            OwnerId = pBuilder.OwnerId;
            AccountId = pBuilder.AccountId;
            Type = pBuilder.Type;
            Amount = pBuilder.Amount;
        }

        [DataMember]
        private int AtmId { get; set; }

        [DataMember]
        internal int OwnerId { get; private set; }

        [DataMember]
        internal int AccountId { get; private set; }

        [DataMember]
        internal TransactionType Type { get; private set; }

        [DataMember]
        internal decimal Amount { get; private set; }

        [DataMember]
        internal int TransactionId { get; set; }

        [DataMember]
        internal long Time { get; set; }

        [DataMember]
        internal TransactionStatus Status { get; set; }

        [DataMember]
        internal string ErrorMessage { get; set; }

        public int GetId()
        {
            return TransactionId;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("Transaction ID: ").Append(TransactionId).Append("\n");
            builder.Append("ATM ID: ").Append(AtmId).Append("\n");
            builder.Append("User ID: ").Append(OwnerId).Append("\n");
            builder.Append("Account ID: ").Append(AccountId).Append("\n");
            builder.Append("Transaction type: ").Append(Type).Append("\n");
            builder.Append("Amount: ").Append(Amount).Append("\n");
            builder.Append("Time: ").Append(DateUtils.ConvertToUserFriendlyFormat(Time)).Append("\n");
            builder.Append("Status: ").Append(Status).Append("\n");
            if (!(string.IsNullOrEmpty(ErrorMessage) || string.IsNullOrWhiteSpace(ErrorMessage)))
                builder.Append("Error: ").Append(ErrorMessage).Append("\n");

            return builder.ToString();
        }
    }
}
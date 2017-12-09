using System;
using System.Runtime.Serialization;
using BankSystem.Models.DB;
using BankSystem.Utils;
using Database;

namespace BankSystem.Models.Transaction
{
    [DataContract(Name = "Transaction")]
    [KnownType(typeof(TransactionType))]
    [KnownType(typeof(TransactionStatus))]
    public class Transaction : IIdentifiable
    {
        [DataMember] private readonly int _atmId;
        [DataMember] internal readonly int OwnerId;
        [DataMember] internal readonly int AccountId;
        [DataMember] internal readonly TransactionType Type;
        [DataMember] internal readonly decimal Amount;

        [DataMember] internal int TransactionId;
        [DataMember] internal long Time;
        [DataMember] internal TransactionStatus Status;


        internal Transaction(TransactionBuilder pBuilder)
        {
            _atmId = pBuilder.AtmId;
            OwnerId = pBuilder.OwnerId;
            AccountId = pBuilder.AccountId;
            Type = pBuilder.Type;
            Amount = pBuilder.Amount;
        }

        public int GetId()
        {
            return TransactionId;
        }


    }
}
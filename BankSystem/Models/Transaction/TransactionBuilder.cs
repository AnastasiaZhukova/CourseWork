﻿namespace BankSystem.Models.Transaction
{
    public class TransactionBuilder
    {
        internal int AtmId;
        internal int OwnerId;
        internal int AccountId;
        internal TransactionType Type;
        internal decimal Amount;

        public TransactionBuilder SetAtmId(int pAtmId)
        {
            AtmId = pAtmId;
            return this;
        }

        public TransactionBuilder SetOwnerId(int pOwnerId)
        {
            OwnerId = pOwnerId;
            return this;
        }

        public TransactionBuilder SetAccountId(int pAccountId)
        {
            AccountId = pAccountId;
            return this;
        }

        public TransactionBuilder SetType(TransactionType pType)
        {
            Type = pType;
            return this;
        }

        public TransactionBuilder SetAmount(decimal pAmount)
        {
            Amount = pAmount;
            return this;
        }

        public void Start()
        {
            var transaction = new Transaction(this);
            TransactionManager.GetInstance().Start(transaction);
        }
    }
}
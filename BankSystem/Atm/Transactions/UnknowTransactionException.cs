using System;

namespace BankSystem.Atm.Transactions
{
    public class UnknowTransactionException : Exception
    {
        public UnknowTransactionException()
        {
        }

        public UnknowTransactionException(string message) : base(message)
        {
        }
    }
}
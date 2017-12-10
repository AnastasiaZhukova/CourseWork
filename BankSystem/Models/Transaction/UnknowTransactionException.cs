using System;

namespace BankSystem.Models.Transaction
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
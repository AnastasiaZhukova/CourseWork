using System;

namespace BankSystem.Models
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException()
        {
        }

        public IllegalStateException(string message) : base(message)
        {
        }
    }
}
using System;

namespace BankSystem.DB
{
    public class InvalidSourceException : Exception
    {
        public InvalidSourceException()
        {
        }

        public InvalidSourceException(string message) : base(message)
        {
        }
    }
}
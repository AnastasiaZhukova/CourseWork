using System;

namespace BankSystem.Models.DB
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
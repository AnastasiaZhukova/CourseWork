using System;

namespace BankSystem.Models.DB
{
    public class SourceNotSetException : Exception
    {
        public SourceNotSetException()
        {
        }

        public SourceNotSetException(string message) : base(message)
        {
        }
    }
}
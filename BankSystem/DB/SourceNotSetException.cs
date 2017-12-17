using System;

namespace BankSystem.DB
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
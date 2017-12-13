using System;

namespace BankSystem.Atm
{
    public class InitializationException : Exception
    {
        public InitializationException()
        {
        }

        public InitializationException(string message) : base(message)
        {
        }
    }
}
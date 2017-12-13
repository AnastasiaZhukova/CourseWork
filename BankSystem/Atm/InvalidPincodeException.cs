using System;

namespace BankSystem.Atm
{
    public class InvalidPincodeException : Exception
    {
        public InvalidPincodeException()
        {
        }

        public InvalidPincodeException(string message) : base(message)
        {
        }
    }
}
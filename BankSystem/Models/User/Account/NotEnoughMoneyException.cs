using System;

namespace BankSystem.Models.User.Account
{
    internal class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(string message) : base(message)
        {
        }
    }
}
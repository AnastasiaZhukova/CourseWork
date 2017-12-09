using System;

namespace BankSystem.Models.User.Account
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(string message) : base(message)
        {
        }
    }
}
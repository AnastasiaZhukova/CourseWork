using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;
using Database;

namespace BankSystem.Models.User.Account
{
    [DataContract(Name = "Account")]
    [KnownType(typeof(Balance))]
    public class Account : IIdentifiable
    {
        [DataMember]
        internal int Id { get; private set; }

        [DataMember]
        internal int Pin { get; private set; }

        [DataMember]
        internal long OwnerId { get; private set; }

        [DataMember]
        internal Balance Balance { get; private set; }

        [DataMember]
        internal List<int> TransactionIds { get; private set; }

        public int GetId()
        {
            return Id;
        }

        internal Account(int id, long ownerId, Balance balance)
        {
            Id = id;
            OwnerId = ownerId;
            Balance = balance;
        }

        /// <summary>
        /// Deposits certain amount of money into the account
        /// </summary>
        /// <param name="pAmount"></param>
        internal void Deposit(decimal pAmount)
        {
            lock (this)
            {
                Balance.Add(pAmount);
            }
        }

        /// <summary>
        /// Withdraws certain amount of money from the account
        /// </summary>
        /// <param name="pAmount"></param>
        /// <exception cref="NotEnoughMoneyException"></exception>
        internal void Withdraw(decimal pAmount)
        {
            Debug.Print("Try withdraw: " + Thread.CurrentThread.Name);

            lock (this)
            {
                Debug.Print("Got through lock: " + Thread.CurrentThread.Name);

                if (!IsEnoughMoney(pAmount))
                {
                    var message = "Not enough money. " +
                                  "Current balance " + Balance +
                                  " Required amount " + pAmount;

                    Debug.Print("Caught no money exception: " + Thread.CurrentThread.Name
                                + "\n" + message);

                    throw new NotEnoughMoneyException(message);
                }

                Debug.Print("Subracting money: " + Thread.CurrentThread.Name);
                Balance.Subtract(pAmount);
            }
        }

        private bool IsEnoughMoney(decimal pRequiredAmount)
        {
            return Balance.Amount > pRequiredAmount;
        }
    }
}
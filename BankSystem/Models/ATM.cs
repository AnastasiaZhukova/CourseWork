﻿using System.Runtime.Serialization;
using BankSystem.Utils;
using Database;

namespace BankSystem.Models
{
    [DataContract(Name = "ATM")]
    [KnownType(typeof(DbSourceProvider))]
    public class Atm : IIdentifiable
    {
        [DataMember]
        internal int Id { get; private set; }

        [DataMember]
        public DbSourceProvider SourceProvider { get; private set; }

        public int GetId()
        {
            return Id;
        }
    }
}
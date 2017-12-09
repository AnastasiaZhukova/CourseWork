﻿using System;
using BankSystem.Models.User.Account;
using Database;

namespace BankSystem.Models.DB
{
    internal static class DbFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static DataBase<Account> GetAccountDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new Exception("No such source");

            var helper = new DbHelper<Account>();
            return helper.Read(pSource);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static DataBase<User.User> GetUserDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new Exception("No such source");

            var helper = new DbHelper<User.User>();
            return helper.Read(pSource);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSource"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static DataBase<Transaction.Transaction> GetTransactionDataBase(IDbSource pSource)
        {
            if (pSource == null) throw new Exception("No such source");

            var helper = new DbHelper<Transaction.Transaction>();
            return helper.Read(pSource);
        }
    }
}
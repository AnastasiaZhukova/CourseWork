using System;
using System.Collections.Generic;

namespace Database
{
    internal class DbCollection<T> : SynchronizedKeyedCollection<long, T> where T : IIdentifiable

    {
        /// <summary>
        ///     Method that returns object from DataBase by Id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        internal T GetById(long pId)
        {
            try
            {
                return this[pId];
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        internal void Update(T pObject)
        {
            var index = IndexOf(pObject); //get internal index of this object
            SetItem(index, pObject);
        }

        protected override long GetKeyForItem(T item)
        {
            return item.GetId();
        }
    }
}
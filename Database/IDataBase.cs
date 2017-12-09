using System.Collections.Generic;

namespace Database
{
    public interface IDataBase<T> where T : IIdentifiable

    {
        T Get(long pId);

        void Put(T pObject);

        void Update(T pObject);

        List<T> GetAll();
    }
}
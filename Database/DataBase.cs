using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database
{
    [DataContract(Name = "DataBase")]
    [KnownType(typeof(DbCollection<>))]
    public class DataBase<T> : IDataBase<T> where T : IIdentifiable
    {
        public delegate void DataBaseUpdate();

        [DataMember] private DbCollection<T> _dataBase;

        public DataBase()
        {
            _dataBase = new DbCollection<T>();
        }

        public IDbSource DbSource { get; internal set; }


        public T Get(long pId)
        {
            return _dataBase.GetById(pId);
        }

        public void Put(T pObject)
        {
            _dataBase.Add(pObject);

            OnUpdate?.Invoke();
        }

        public void Update(T pObject)
        {
            _dataBase.Update(pObject);

            OnUpdate?.Invoke();
        }

        public List<T> GetAll()
        {
            return _dataBase.ToList();
        }

        public event DataBaseUpdate OnUpdate;
    }
}
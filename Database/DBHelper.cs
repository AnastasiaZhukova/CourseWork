using Database.Utils;

namespace Database
{
    public class DbHelper<T> where T : IIdentifiable
    {
        private readonly Serializer<DataBase<T>> _serializer;
        private readonly object _syncLock = new object();

        public DbHelper()
        {
            _serializer = new Serializer<DataBase<T>>();
        }


        public DataBase<T> Read(IDbSource pSource)
        {
            DataBase<T> dataBase;
            lock (_syncLock)
            {
                var stream = pSource.GetStream();
                dataBase = _serializer.Read(stream);
                StreamUtils.CloseStream(stream);

                dataBase.DbSource = pSource;
            }

            return dataBase;
        }

        public void Write(DataBase<T> pDataBase, IDbSource pTarget)
        {
            lock (_syncLock)
            {
                var stream = pTarget.GetStream();
                _serializer.Write(pDataBase, stream);
                StreamUtils.CloseStream(stream);
            }
        }
    }
}
using Database;

namespace BankSystem.DB
{
    internal class UpdateHandler<T> where T : IIdentifiable
    {
        private readonly DataBase<T> _dataBase;
        private readonly object _syncLock = new object();

        internal UpdateHandler(DataBase<T> dataBase)
        {
            _dataBase = dataBase;
        }

        internal void Save()
        {
            lock (_syncLock)
            {
                var source = _dataBase?.DbSource;
                if (source == null) return;
                var helper = new DbHelper<T>();
                helper.Write(_dataBase, source);
            }
        }
    }
}
using Database;

namespace BankSystem.Models.DB
{
    public class UpdateHandler<T> where T : IIdentifiable
    {
        private readonly DataBase<T> _dataBase;
        private readonly object SyncLock = new object();

        public UpdateHandler(DataBase<T> dataBase)
        {
            _dataBase = dataBase;
        }

        public void Save()
        {
            var source = _dataBase?.DbSource;
            if (source == null) return;
            var helper = new DbHelper<T>();
            helper.Write(_dataBase, source);
        }
    }
}
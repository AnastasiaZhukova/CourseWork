using Database;

namespace BankSystem.DB
{
    public interface IDbSourceProvider
    {
        IDbSource GetUserDbSource();

        IDbSource GetAccountDbSource();

        IDbSource GetTransactionDbSource();
    }
}
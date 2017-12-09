using Database;

namespace BankSystem.Models.DB
{
    public interface IDbSourceProvider
    {
        IDbSource GetUserDbSource();

        IDbSource GetAccountDbSource();

        IDbSource GetTransactionDbSource();
        
    }
}
using BankSystem.DB;

namespace BankSystem.Utils
{
    public static class AccountUtils
    {
        public static bool IsPincodeCorrect(int accountId, int pin)
        {
            //if (pin.ToString().Length != 4) return false;
            var pincode = DbManager.GetInstance().GetAccountDatabase().Get(accountId).Pin;
            return pin == pincode;
        }
    }
}
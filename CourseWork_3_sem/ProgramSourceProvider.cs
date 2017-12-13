using BankSystem.Atm.Utils;

namespace CourseWork_3_sem
{
    public static class ProgramSourceProvider
    {
        //TODO implement
        private const string AtmSourcePath = "";

        public static AtmSource GetAtmSource()
        {
            return new AtmSource(AtmSourcePath);
        }
    }
}
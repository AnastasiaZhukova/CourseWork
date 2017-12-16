using System.IO;
using System.Windows.Forms;
using BankSystem.Atm.Utils;

namespace CourseWork_3_sem
{
    public static class ProgramSourceProvider
    {
        private static readonly string AtmSourcePath = GetPath();

        public static AtmSource GetAtmSource()
        {
            return new AtmSource(AtmSourcePath);
        }

        private static string GetPath()
        {
            return Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\atm.json";
        }
    }
}
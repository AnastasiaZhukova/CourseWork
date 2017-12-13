using System;
using System.Windows.Forms;
using BankSystem.Atm;
using CourseWork_3_sem.Presenters;
using CourseWork_3_sem.Presenters.MainForm;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem
{
    internal static class Program
    {
        private static AtmManager _atmManager;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (!TryInitialize()) return;

            var mainForm = new MainForm();
            mainForm.SetPresenter(new DepositMainFormPresenter(null, null, mainForm));
            Application.Run(mainForm);
        }

        /// <summary>
        /// </summary>
        /// <returns>True if initialize successfully and false otherwise</returns>
        private static bool TryInitialize()
        {
            try
            {
                _atmManager = new AtmManager(ProgramSourceProvider.GetAtmSource());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
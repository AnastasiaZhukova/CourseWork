using System;
using System.Windows.Forms;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.Presenters.MainForm;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters
{
    public class StartFormPresenter
    {
        private readonly AtmManager _atmManager;
        private readonly IStartForm _view;

        public StartFormPresenter(AtmManager atmManger, IStartForm view)
        {
            _atmManager = atmManger;
            _view = view;
        }

        public void StartNewSession(int accountId, int password)
        {
            Session session = null;
            try
            {
                session = _atmManager.StartNewSession(accountId, password);
            }
            catch (InvalidPincodeException)
            {
                _view.ShowInvalidPinDialog();
            }
            catch (Exception)
            {
                _view.ShowAtmNotAvailableDialog();
            }

            if (session == null) return;

            var mainForm = new View.MainForm();

            var startFormPresenter = new StarterMainFormPresenter(_atmManager, mainForm);
            //startFormPresenter.OnSessionFinished += FinishSession;
            Application.Run(mainForm);
        }

        public void FinishSession()
        {
            _view.ClearAll();
            _view.ShowForm();
        }
    }
}
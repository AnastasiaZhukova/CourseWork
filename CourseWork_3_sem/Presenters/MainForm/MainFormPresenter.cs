using System;
using System.Threading;
using System.Windows.Forms;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public abstract class MainFormPresenter : IMainFormPresenter
    {
        private static bool _isTimeUpdateSet;

        protected readonly AtmManager AtmManger;
        protected readonly Session Session;
        protected readonly IMainForm View;

        protected MainFormPresenter()
        {
        }

        private Thread _updateTimeThread;

        protected MainFormPresenter(AtmManager atmManger, Session session, IMainForm view)
        {
            AtmManger = atmManger;
            Session = session;
            View = view;

            if (_isTimeUpdateSet == false)
            {
                _updateTimeThread = new Thread(() =>
                {
                    while (true)
                    {
                        UpdateTime();
                    }
                });
                _updateTimeThread.Start();

                _isTimeUpdateSet = true;
            }

            Initialize();
        }

        protected abstract void Initialize();

        public abstract void OnLeftHighButtonClicked();

        public abstract void OnLeftLowButtonClicked();

        public abstract void OnRightLowButtonClicked();

        public abstract void OnRightHighButtonClicked();

        public abstract void OnInsertCardButtonClicked();

        public abstract void OnTakeMoneyButtonClicked();

        public abstract void OnInsertMoney();

        public void OnExit()
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void UpdateTime()
        {
            View.SetTimeText(DateTime.UtcNow.ToString());
        }
        
    }
}
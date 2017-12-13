using System;
using System.Threading;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public abstract class MainFormPresenter : IMainFormPresenter
    {
        private static bool IsTimeUpdateSet;

        protected AtmManager _atmManger;
        protected Session _session;
        protected IMainForm _view;
        
        protected MainFormPresenter(){}

        protected MainFormPresenter(AtmManager atmManger, Session session, IMainForm view)
        {
            _atmManger = atmManger;
            _session = session;
            _view = view;

            if (IsTimeUpdateSet == false)
            {
                new Thread(() =>
                {
                    
                    while (true)
                    {
                        UpdateTime();
                    }
                }).Start();

                IsTimeUpdateSet = true;
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

        private void UpdateTime()
        {
            _view.SetTimeText(DateTime.UtcNow.ToString());
        }
    }
}
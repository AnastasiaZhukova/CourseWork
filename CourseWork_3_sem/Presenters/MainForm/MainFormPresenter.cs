using System.Threading;
using BankSystem.Atm;
using BankSystem.Models;
using BankSystem.Utils;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public abstract class MainFormPresenter : IMainFormPresenter
    {
        protected static bool IsTimeUpdateSet;

        internal event FinishSession OnSessionFinished;

        internal delegate void FinishSession();

        protected AtmManager _atmManger;
        protected Session _session;
        protected IMainForm _view;

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

        protected void UpdateTime()
        {
            _view.SetTimeText(System.DateTime.UtcNow.ToString());
        }
    }
}
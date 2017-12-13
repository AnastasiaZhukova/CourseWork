using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public abstract class MainFormPresenter : IMainFormPresenter
    {
        protected AtmManager _atmManger;
        protected Session _session;
        protected IMainForm _view;

        protected MainFormPresenter(AtmManager atmManger, Session session, IMainForm view)
        {
            _atmManger = atmManger;
            _session = session;
            _view = view;

            Initialize();
        }

        protected abstract void Initialize();

        public abstract void OnLeftHighButtonClicked();

        public abstract void OnLeftLowButtonClicked();

        public abstract void OnRightLowButtonClicked();

        public abstract void OnRightHighButtonClicked();

        public void OnExitButtonClicked()
        {
            OnSessionFinished?.Invoke();
            _view.CloseForm();
        }

        internal event FinishSession OnSessionFinished;

        internal delegate void FinishSession();
    }
}
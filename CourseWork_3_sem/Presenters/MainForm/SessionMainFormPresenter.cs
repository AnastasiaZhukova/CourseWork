using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class SessionFormPresenter : MainFormPresenter
    {
        public SessionFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger, session,
            view)
        {
        }

        protected override void Initialize()
        {
            _view.SetLeftHighButtonEnabled(true);
            _view.SetLeftHighText("Deposit");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Withdraw");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowText("Return");

            _view.SetRigthHighButtonEnabled(true);
            _view.SetRightLowText("");
        }

        public override void OnLeftHighButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnLeftLowButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnRightLowButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnRightHighButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnInsertCardButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnTakeMoneyButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnInsertMoney()
        {
            throw new System.NotImplementedException();
        }
    }
}
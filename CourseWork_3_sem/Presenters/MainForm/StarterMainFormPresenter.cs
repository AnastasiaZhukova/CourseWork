using System;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    internal class StarterMainFormPresenter : MainFormPresenter
    {
        public StarterMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            _view.SetLeftHighText("Withdraw");
            _view.SetLeftLowText("Deposit");
            _view.SetRightLowText("");
            _view.SetRightHighText("Show balance");
        }

        public override void OnLeftHighButtonClicked()
        {
            //TODO replace
            _view.SetPresenter(new DepositMainFormPresenter(_atmManger, _session, _view));
        }

        public override void OnLeftLowButtonClicked()
        {
            throw new NotImplementedException();
        }

        public override void OnRightLowButtonClicked()
        {
            throw new NotImplementedException();
        }

        public override void OnRightHighButtonClicked()
        {
            throw new NotImplementedException();
        }
    }
}
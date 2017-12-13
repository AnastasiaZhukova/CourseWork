using System;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class DepositMainFormPresenter : MainFormPresenter
    {
        public DepositMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            _view.SetLeftHighButtonEnabled(false);
            _view.SetLeftHighText("");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Return");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowText("Submit");

            _view.SetRigthHighButtonEnabled(false);
            _view.SetRightHighText("");
        }

        public override void OnLeftHighButtonClicked()
        {
            throw new NotImplementedException();
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
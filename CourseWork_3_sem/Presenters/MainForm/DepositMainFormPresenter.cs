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
            _view.SetLeftHighTextBox("");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowTextBox("Return");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowTextBox("Submit");

            _view.SetRigthHighButtonEnabled(false);
            _view.SetRightHighTextBox("");
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
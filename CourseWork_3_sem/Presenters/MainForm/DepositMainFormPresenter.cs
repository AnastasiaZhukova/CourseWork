using System;
using BankSystem.Atm;
using BankSystem.Models;
using BankSystem.Models.Transaction;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class DepositMainFormPresenter : MainFormPresenter
    {
        private double _totalAmount;

        public DepositMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            _view.SetWindowHighText("Insert Money");
            _view.SetWindowLowText("Total: " + _totalAmount);

            _view.SetLeftHighButtonEnabled(false);
            _view.SetLeftHighText("");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Submit");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowText("Cancel");

            _view.SetRigthHighButtonEnabled(false);
            _view.SetRightHighText("");

            _view.SetInsertMoneyFieldEnabled(true);
            _view.SetInsertMoneyFieldText("");

            _view.SetGetMoneyButtonEnabled(false);

            _view.SetCardNumFieldEnabled(false);
            _view.SetCardPinFieldEnabled(false);
            _view.SetInsertButtonEnabled(false);
        }

        public override void OnLeftHighButtonClicked()
        {
        }

        //Submit
        public override void OnLeftLowButtonClicked()
        {
            decimal amount = new decimal(_totalAmount);
            _session.MakeTransaction(TransactionType.Deposit, amount);
            _session.OnTransactionFinished += HandleTransactionFinished;
            
            
            //TODO print check
        }

        private void HandleTransactionFinished(int transactionId)
        {
            
            //TODO
            _session.GetCheck(transactionId);

        }


        //Cancel
        public override void OnRightLowButtonClicked()
        {
            //TODO
        }

        public override void OnRightHighButtonClicked()
        {
        }

        public override void OnInsertCardButtonClicked()
        {
        }

        public override void OnTakeMoneyButtonClicked()
        {
        }

        public override void OnInsertMoney()
        {
            double amount;
            if (Double.TryParse(_view.GetInsertMoneyTextBoxText(), out amount))
            {
                _totalAmount += amount;
            }
        }
    }
}
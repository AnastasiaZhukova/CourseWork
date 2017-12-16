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
            View.SetWindowHighText("Insert Money");
            View.SetWindowLowText("Total: " + _totalAmount);

            View.SetLeftHighButtonEnabled(false);
            View.SetLeftHighText("");

            View.SetLeftLowButtonEnabled(true);
            View.SetLeftLowText("Submit");

            View.SetRightLowButtonEnabled(true);
            View.SetRightLowText("Cancel");

            View.SetRigthHighButtonEnabled(false);
            View.SetRightHighText("");

            View.SetInsertMoneyFieldEnabled(true);
            View.SetInsertMoneyFieldText("");

            View.SetGetMoneyButtonEnabled(false);
            View.SetGetMoneyButtonText("");

            View.SetCardNumFieldEnabled(false);
            View.SetCardPinFieldEnabled(false);
            View.SetInsertButtonEnabled(false);
        }

        //not enabled
        public override void OnLeftHighButtonClicked()
        {
        }

        //Submit
        public override void OnLeftLowButtonClicked()
        {
            if (_totalAmount <= 0)
            {
                ShowError("Invalid amount of money");
                return;
            }
            var amount = new decimal(_totalAmount);

            Session.OnTransactionStarted += HandleTransactionStarted;
            Session.OnTransactionFinished += HandleTransactionFinished;
            Session.MakeTransaction(TransactionType.Deposit, amount);
        }

        private void HandleTransactionStarted()
        {
            Session.OnTransactionStarted -= HandleTransactionStarted;
            View.SetWindowHighText("Wait...");
        }


        private int _transactionId;

        private void HandleTransactionFinished(int transactionId, bool isSuccessful)
        {
            Session.OnTransactionFinished -= HandleTransactionFinished;

            _transactionId = transactionId;
            if (!isSuccessful)
            {
                View.SetWindowHighText("Error");
                ShowError(Session.GetErrorMessage(transactionId));
            }
            else
            {
                View.SetWindowHighText("Success");
            }


            View.SetLeftLowButtonEnabled(false);
            View.SetRightLowButtonEnabled(false);

            var printCheckDialog = new PrintCheckDialog();
            printCheckDialog.OnYes += PrintCheck;
            printCheckDialog.OnNo += Finish;
            printCheckDialog.ShowDialog();
        }

        private void PrintCheck()
        {
            var check = Session.GetCheck(_transactionId);
            var printCheck = new CheckDialog();
            printCheck.SetCheck(check);
            printCheck.OnFinish += Finish;
            printCheck.ShowDialog();
        }

        private void Finish()
        {
            View.SetPresenter(new SessionMainFormPresenter(AtmManger, Session, View));
        }

        private void ShowError(string text)
        {
            var infoDialog = new InformationForm();
            infoDialog.SetInfoText(text);
            infoDialog.OnFinish += Finish;
            infoDialog.ShowDialog();
        }


        //Cancel
        public override void OnRightLowButtonClicked()
        {
            Finish();
        }

        //not enabled
        public override void OnRightHighButtonClicked()
        {
        }

        //not enabled
        public override void OnInsertCardButtonClicked()
        {
        }

        //not enabled
        public override void OnTakeMoneyButtonClicked()
        {
        }

        public override void OnInsertMoney()
        {
            if (!double.TryParse(View.GetInsertMoneyTextBoxText(), out var amount)) return;
            if (amount <= 0) return;
            _totalAmount += amount;
            //update inputed amount
            View.SetWindowLowText(_totalAmount.ToString());
            //clear input box
            View.SetInsertMoneyFieldText("");
        }
    }
}
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

        //not enabled
        public override void OnLeftHighButtonClicked()
        {
        }

        //Submit
        public override void OnLeftLowButtonClicked()
        {
            var amount = new decimal(_totalAmount);
            _session.OnTransactionStarted += HandleTransactionStarted;
            _session.OnTransactionFinished += HandleTransactionFinished;
            _session.MakeTransaction(TransactionType.Deposit, amount);
        }

        private void HandleTransactionStarted()
        {
            _session.OnTransactionStarted -= HandleTransactionStarted;
            _view.SetWindowHighText("Wait...");
        }


        private int _transactionId;

        private void HandleTransactionFinished(int transactionId, bool isSuccessful)
        {
            _view.SetWindowHighText("");

            _session.OnTransactionFinished -= HandleTransactionFinished;

            _transactionId = transactionId;
            var printCheckDialog = new PrintCheckDialog();
            if (isSuccessful)
            {
                printCheckDialog.OnYes += PrintCheck;
                printCheckDialog.OnNo += Finish;
            }
            else
            {
                ShowError(_session.GetErrorMessage(transactionId));
            }
        }

        private void PrintCheck()
        {
            var check = _session.GetCheck(_transactionId);
            var printCheck = new CheckDialog();
            printCheck.SetCheck(check);
            printCheck.OnFinish += Finish;
            printCheck.ShowDialog();
        }

        private void Finish()
        {
            _view.SetPresenter(new SessionFormPresenter(_atmManger, _session, _view));
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
            double amount;
            if (Double.TryParse(_view.GetInsertMoneyTextBoxText(), out amount))
            {
                _totalAmount += amount;
            }
        }
    }
}
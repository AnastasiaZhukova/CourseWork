using BankSystem.Atm;
using BankSystem.Models;
using BankSystem.Models.Transaction;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class WithdrawMainFormPresenter : MainFormPresenter
    {
        private decimal _totalAmount;

        public WithdrawMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            View.SetWindowHighText("");
            View.SetWindowLowText("");

            View.SetLeftHighButtonEnabled(false);
            View.SetLeftHighText("");

            View.SetLeftLowButtonEnabled(false);
            View.SetLeftLowText("");

            View.SetRightLowButtonEnabled(true);
            View.SetRightLowText("Cancel");

            View.SetRigthHighButtonEnabled(true);
            View.SetRightHighText("Input");

            View.SetInsertMoneyFieldEnabled(false);
            View.SetInsertMoneyFieldText("");

            View.SetGetMoneyButtonEnabled(false);
            View.SetGetMoneyButtonText("");

            View.SetCardNumFieldEnabled(false);
            View.SetCardPinFieldEnabled(false);
            View.SetInsertButtonEnabled(false);
        }


        private void Finish()
        {
            View.SetPresenter(new SessionMainFormPresenter(AtmManger, Session, View));
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
                ShowError("Invalid amount");
            }
            else
            {
                Session.OnTransactionStarted += HandleTransactionStarted;
                Session.OnTransactionFinished += HandleTransactionFinished;
                Session.MakeTransaction(TransactionType.Withdraw, _totalAmount);
            }
        }

        private void HandleTransactionStarted()
        {
            View.SetWindowHighText("Wait...");
        }

        private int _transactionId;

        private void HandleTransactionFinished(int transactionId, bool isSuccessful)
        {
            View.SetWindowHighText("");

            Session.OnTransactionFinished -= HandleTransactionFinished;

            _transactionId = transactionId;

            if (isSuccessful)
            {
                View.SetWindowHighText("Please, take money");
                View.SetGetMoneyButtonEnabled(true);
                View.SetGetMoneyButtonText("Take money");
            }
            else
            {
                ShowError(Session.GetErrorMessage(transactionId));
            }
        }

        private void PrintCheck()
        {
            var check = Session.GetCheck(_transactionId);
            var printCheck = new CheckDialog();
            printCheck.SetCheck(check);
            printCheck.OnFinish += Finish;
            printCheck.ShowDialog();
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

        //Input
        public override void OnRightHighButtonClicked()
        {
            GetAmount();
        }

        private void GetAmount()
        {
            var getAmountDialog = new AmountInputDialog();
            getAmountDialog.OnSubmit += HandleOnSubmitEvent;
            getAmountDialog.OnReject += HandleOnRejectEvent;
            getAmountDialog.ShowDialog();
        }


        private void HandleOnSubmitEvent(string amount)
        {
            View.SetLeftLowButtonEnabled(true);
            View.SetLeftLowText("Submit");

            View.SetRightHighText("");
            View.SetRigthHighButtonEnabled(false);

            if (decimal.TryParse(amount, out _totalAmount))
            {
                View.SetWindowHighText("Do you want to withdraw " + _totalAmount + " ?");
            }
            else
            {
                ShowError("Wrong input");
            }
        }

        private void HandleOnRejectEvent()
        {
            Finish();
        }


        //not enabled
        public override void OnInsertCardButtonClicked()
        {
        }

        public override void OnTakeMoneyButtonClicked()
        {
            View.SetGetMoneyButtonEnabled(false);

            var printCheckDialog = new PrintCheckDialog();

            printCheckDialog.OnYes += PrintCheck;
            printCheckDialog.OnNo += Finish;

            printCheckDialog.ShowDialog();
        }

        //not enabled
        public override void OnInsertMoney()
        {
        }
    }
}
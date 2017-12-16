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

            View.SetLeftLowButtonEnabled(true);
            View.SetLeftLowText("Submit");

            View.SetRightLowButtonEnabled(true);
            View.SetRightLowText("Cancel");

            View.SetRigthHighButtonEnabled(false);
            View.SetRightHighText("");

            View.SetInsertMoneyFieldEnabled(false);
            View.SetInsertMoneyFieldText("");
            View.SetGetMoneyButtonEnabled(false);

            View.SetCardNumFieldEnabled(false);
            View.SetCardPinFieldEnabled(false);
            View.SetInsertButtonEnabled(false);

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
            if (decimal.TryParse(amount, out _totalAmount))
            {
                View.SetWindowHighText("Withdraw " + _totalAmount + " ?");
            }
            else
            {
                var infoDialog = new InformationForm();
                infoDialog.OnFinish += Finish;
                infoDialog.SetInfoText("Wrong input");
                infoDialog.ShowDialog();
            }
        }

        private void HandleOnRejectEvent()
        {
            Finish();
        }

        private void Finish()
        {
            View.SetPresenter(new SessionMainFormPresenter(AtmManger, Session, View));
        }

        //not enabled
        public override void OnLeftHighButtonClicked()
        {
        }

        public override void OnLeftLowButtonClicked()
        {
            Session.OnTransactionStarted += HandleTransactionStarted;
            Session.OnTransactionFinished += HandleTransactionFinished;
            Session.MakeTransaction(TransactionType.Withdraw, _totalAmount);
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
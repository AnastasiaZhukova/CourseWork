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
            _view.SetWindowHighText("");
            _view.SetWindowLowText("");

            _view.SetLeftHighButtonEnabled(false);
            _view.SetLeftHighText("");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Submit");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowText("Cancel");

            _view.SetRigthHighButtonEnabled(false);
            _view.SetRightHighText("");

            _view.SetInsertMoneyFieldEnabled(false);
            _view.SetInsertMoneyFieldText("");
            _view.SetGetMoneyButtonEnabled(false);

            _view.SetCardNumFieldEnabled(false);
            _view.SetCardPinFieldEnabled(false);
            _view.SetInsertButtonEnabled(false);

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
                _view.SetWindowHighText("Withdraw " + _totalAmount + " ?");
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
            _view.SetPresenter(new SessionFormPresenter(_atmManger, _session, _view));
        }

        //not enabled
        public override void OnLeftHighButtonClicked()
        {
        }

        public override void OnLeftLowButtonClicked()
        {
            _session.OnTransactionStarted += HandleTransactionStarted;
            _session.OnTransactionFinished += HandleTransactionFinished;
            _session.MakeTransaction(TransactionType.Withdraw, _totalAmount);
        }

        private void HandleTransactionStarted()
        {
        }

        private int _transactionId;

        private void HandleTransactionFinished(int transactionId, bool isSuccessful)
        {
            _view.SetWindowHighText("");

            _session.OnTransactionFinished -= HandleTransactionFinished;

            _transactionId = transactionId;

            if (isSuccessful)
            {
                _view.SetGetMoneyButtonEnabled(true);
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
            var printCheckDialog = new PrintCheckDialog();

            printCheckDialog.OnYes += PrintCheck;
            printCheckDialog.OnNo += Finish;
        }

        //not enabled
        public override void OnInsertMoney()
        {
        }
    }
}
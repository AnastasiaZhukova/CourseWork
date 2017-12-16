using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class ShowBalanceMainFormPresenter : MainFormPresenter
    {
        public ShowBalanceMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            View.SetWindowHighText("On check or screen?");
            View.SetWindowLowText("");

            View.SetLeftHighButtonEnabled(true);
            View.SetLeftHighText("Check");

            View.SetLeftLowButtonEnabled(true);
            View.SetLeftLowText("Screen");

            View.SetRightLowButtonEnabled(true);
            View.SetRightLowText("Cancel");

            View.SetRigthHighButtonEnabled(false);
            View.SetRightHighText("");

            View.SetInsertMoneyFieldEnabled(false);
            View.SetInsertMoneyFieldText("");

            View.SetGetMoneyButtonEnabled(false);
            View.SetGetMoneyButtonText("");

            View.SetCardNumFieldEnabled(false);
            View.SetCardPinFieldEnabled(false);
            View.SetInsertButtonEnabled(false);
        }


        //Check
        public override void OnLeftHighButtonClicked()
        {
            var checkForm = new CheckDialog();
            checkForm.OnFinish += Finish;
            checkForm.SetCheck(Session.GetAccountBalanceOnCheck());
            checkForm.ShowDialog();
        }

        //Screen
        public override void OnLeftLowButtonClicked()
        {
            View.SetLeftHighButtonEnabled(false);
            View.SetLeftHighText("");

            View.SetLeftLowButtonEnabled(false);
            View.SetLeftLowText("");

            View.SetRightLowText("Return");

            View.SetWindowHighText("Balance: ");
            View.SetWindowLowText(Session.GetAccountBalance());
        }

        public override void OnRightLowButtonClicked()
        {
            Finish();
        }

        private void Finish()
        {
            View.SetPresenter(new SessionMainFormPresenter(AtmManger, Session, View));
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

        //not enabled
        public override void OnInsertMoney()
        {
        }
    }
}
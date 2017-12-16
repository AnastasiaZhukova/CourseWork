using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class SessionMainFormPresenter : MainFormPresenter
    {
        public SessionMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session,
            view)
        {
        }

        protected override void Initialize()
        {
            View.SetWindowHighText("International Bank");
            View.SetWindowLowText("Hello " + Session.GetUserName());

            View.SetLeftHighButtonEnabled(true);
            View.SetLeftHighText("Withdraw");

            View.SetLeftLowButtonEnabled(true);
            View.SetLeftLowText("Deposit");

            View.SetRightLowButtonEnabled(true);
            View.SetRightLowText("Return");

            View.SetRigthHighButtonEnabled(true);
            View.SetRightHighText("Balance");

            View.SetInsertMoneyFieldEnabled(false);
            View.SetInsertMoneyFieldText("");
            View.SetGetMoneyButtonEnabled(false);

            View.SetCardNumFieldEnabled(false);
            View.SetCardPinFieldEnabled(false);
            View.SetInsertButtonEnabled(false);
        }

        //Withdraw
        public override void OnLeftHighButtonClicked()
        {
            View.SetPresenter(new WithdrawMainFormPresenter(AtmManger, Session, View));
        }

        //Deposit
        public override void OnLeftLowButtonClicked()
        {
            View.SetPresenter(new DepositMainFormPresenter(AtmManger, Session, View));
        }

        //Return
        public override void OnRightLowButtonClicked()
        {
            View.SetPresenter(new StarterMainFormPresenter(AtmManger, View));
        }

        //Balance
        public override void OnRightHighButtonClicked()
        {
            View.SetPresenter(new ShowBalanceMainFormPresenter(AtmManger, Session, View));
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
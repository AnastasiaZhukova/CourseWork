using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    public class SessionFormPresenter : MainFormPresenter
    {
        public SessionFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger, session,
            view)
        {
        }

        protected override void Initialize()
        {
            _view.SetWindowHighText("International Bank");
            _view.SetWindowLowText("Perform some operations...");

            _view.SetLeftHighButtonEnabled(true);
            _view.SetLeftHighText("Withdraw");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Deposit");

            _view.SetRightLowButtonEnabled(true);
            _view.SetRightLowText("Return");

            _view.SetRigthHighButtonEnabled(true);
            _view.SetRightHighText("Balance");

            _view.SetInsertMoneyFieldEnabled(false);
            _view.SetInsertMoneyFieldText("");
            _view.SetGetMoneyButtonEnabled(false);

            _view.SetCardNumFieldEnabled(false);
            _view.SetCardPinFieldEnabled(false);
            _view.SetInsertButtonEnabled(false);
        }

        //Withdraw
        public override void OnLeftHighButtonClicked()
        {
            _view.SetPresenter(new WithdrawMainFormPresenter(_atmManger, _session, _view));
        }

        //Deposit
        public override void OnLeftLowButtonClicked()
        {
            _view.SetPresenter(new DepositMainFormPresenter(_atmManger, _session, _view));
        }

        //Return
        public override void OnRightLowButtonClicked()
        {
            _view.SetPresenter(new SessionFormPresenter(_atmManger, _session, _view));
        }

        //Balance
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
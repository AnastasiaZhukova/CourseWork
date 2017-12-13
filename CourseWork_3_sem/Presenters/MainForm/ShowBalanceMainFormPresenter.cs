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
            _view.SetWindowHighText("");
            _view.SetWindowLowText("");

            _view.SetLeftHighButtonEnabled(true);
            _view.SetLeftHighText("Check");

            _view.SetLeftLowButtonEnabled(true);
            _view.SetLeftLowText("Screen");

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
        }


        public override void OnLeftHighButtonClicked()
        {
            _view.SetLeftHighText("Balance: ");
            _view.SetLeftLowText(_session.GetAccountBalance());
        }

        public override void OnLeftLowButtonClicked()
        {
            var checkForm = new CheckDialog();
            checkForm.OnFinish += Finish;
            checkForm.SetCheck(_session.GetFullAccountInfo());
            checkForm.ShowDialog();
        }

        public override void OnRightLowButtonClicked()
        {
            Finish();
        }

        private void Finish()
        {
            _view.SetPresenter(new SessionFormPresenter(_atmManger, _session, _view));
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
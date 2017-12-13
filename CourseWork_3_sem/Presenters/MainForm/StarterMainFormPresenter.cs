using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    internal class StarterMainFormPresenter : MainFormPresenter
    {
        public StarterMainFormPresenter(AtmManager atmManger, Session session, IMainForm view) : base(atmManger,
            session, view)
        {
        }

        protected override void Initialize()
        {
            _view.SetWindowHighText("");
            _view.SetWindowLowText("");

            _view.SetLeftHighButtonEnabled(false);
            _view.SetLeftHighText("");

            _view.SetLeftLowButtonEnabled(false);
            _view.SetLeftLowText("");

            _view.SetRightLowButtonEnabled(false);
            _view.SetRightLowText("");

            _view.SetRigthHighButtonEnabled(false);
            _view.SetRightHighText("");

            _view.SetInsertMoneyFieldEnabled(false);
            _view.SetInsertMoneyFieldText("");
            _view.SetGetMoneyButtonEnabled(false);

            _view.SetCardNumFieldEnabled(true);
            _view.SetCardNumFieldText("");
            _view.SetCardPinFieldEnabled(true);
            _view.SetCarPinFieldText("");
            _view.SetInsertButtonEnabled(true);
        }

        public override void OnLeftHighButtonClicked()
        {
        }

        public override void OnLeftLowButtonClicked()
        {
        }

        public override void OnRightLowButtonClicked()
        {
        }

        public override void OnRightHighButtonClicked()
        {
        }

        public override void OnInsertCardButtonClicked()
        {
            //TODO
        }

        public override void OnTakeMoneyButtonClicked()
        {
        }

        public override void OnInsertMoney()
        {
        }
    }
}
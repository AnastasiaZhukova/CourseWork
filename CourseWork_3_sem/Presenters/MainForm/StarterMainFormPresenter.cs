using System;
using BankSystem.Atm;
using BankSystem.Models;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.Presenters.MainForm
{
    internal class StarterMainFormPresenter : MainFormPresenter
    {
        public StarterMainFormPresenter(AtmManager atmManger, IMainForm view) : base(atmManger, null,
            view)
        {
        }

        protected override void Initialize()
        {
            _view.SetWindowHighText("International Bank");
            _view.SetWindowLowText("Please, insert card");

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
            var cardNumFieldText = _view.GetCardNumFieldText();
            var cardPinFieldText = _view.GetCardPinFieldText();

            int id;
            int pin;
            if (int.TryParse(cardNumFieldText, out id))
            {
                if (int.TryParse(cardPinFieldText, out pin))
                {
                    _atmManger.StartNewSession(id, pin);
                }
            }
        }

        public override void OnTakeMoneyButtonClicked()
        {
        }

        public override void OnInsertMoney()
        {
        }
    }
}
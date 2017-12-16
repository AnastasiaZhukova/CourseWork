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
            View.SetWindowHighText("International Bank");
            View.SetWindowLowText("Please, insert card");

            View.SetLeftHighButtonEnabled(false);
            View.SetLeftHighText("");

            View.SetLeftLowButtonEnabled(false);
            View.SetLeftLowText("");

            View.SetRightLowButtonEnabled(false);
            View.SetRightLowText("");

            View.SetRigthHighButtonEnabled(false);
            View.SetRightHighText("");

            View.SetInsertMoneyFieldEnabled(false);
            View.SetInsertMoneyFieldText("");
            View.SetGetMoneyButtonEnabled(false);

            View.SetCardNumFieldEnabled(true);
            View.SetCardNumFieldText("");
            View.SetCardPinFieldEnabled(true);
            View.SetCarPinFieldText("");
            View.SetInsertButtonEnabled(true);
        }

        //not enabled
        public override void OnLeftHighButtonClicked()
        {
        }

        //not enabled
        public override void OnLeftLowButtonClicked()
        {
        }

        //not enabled
        public override void OnRightLowButtonClicked()
        {
        }

        //not enabled
        public override void OnRightHighButtonClicked()
        {
        }

        public override void OnInsertCardButtonClicked()
        {
            var cardNumFieldText = View.GetCardNumFieldText();
            var cardPinFieldText = View.GetCardPinFieldText();

            if (!int.TryParse(cardNumFieldText, out var id) ||
                !int.TryParse(cardPinFieldText, out var pin))
            {
                ShowError();
                return;
            }

            try
            {
                var session = AtmManger.StartNewSession(id, pin);
                View.SetPresenter(new SessionMainFormPresenter(AtmManger, session, View));
            }
            catch (Exception)
            {
                ShowError();
            }
        }

        private static void ShowError()
        {
            var form = new InformationForm();
            form.SetInfoText("Invalid Input");
            form.ShowDialog();
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
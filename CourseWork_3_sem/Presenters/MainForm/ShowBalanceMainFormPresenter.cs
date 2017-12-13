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
            throw new System.NotImplementedException();
        }

        public override void OnLeftHighButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnLeftLowButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnRightLowButtonClicked()
        {
            throw new System.NotImplementedException();
        }

        public override void OnRightHighButtonClicked()
        {
            throw new System.NotImplementedException();
        }
    }
}
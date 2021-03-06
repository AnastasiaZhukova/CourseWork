﻿namespace CourseWork_3_sem.Presenters.MainForm
{
    public interface IMainFormPresenter
    {
        void OnLeftHighButtonClicked();
        void OnLeftLowButtonClicked();
        void OnRightLowButtonClicked();
        void OnRightHighButtonClicked();

        void OnInsertCardButtonClicked();
        void OnTakeMoneyButtonClicked();
        void OnInsertMoney();

        void OnExit();
    }
}
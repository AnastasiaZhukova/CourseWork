using CourseWork_3_sem.Presenters;
using CourseWork_3_sem.Presenters.MainForm;

namespace CourseWork_3_sem.View
{
    public interface IMainForm
    {
        void SetPresenter(IMainFormPresenter presenter);

        void SetTimeText(string text);

        void SetWindowHighText(string text);
        void SetWindowLowText(string text);

        void SetLeftHighText(string text);
        void SetLeftLowText(string text);
        void SetRightLowText(string text);
        void SetRightHighText(string text);

        void SetLeftHighButtonEnabled(bool enabled);
        void SetLeftLowButtonEnabled(bool enabled);
        void SetRightLowButtonEnabled(bool enabled);
        void SetRigthHighButtonEnabled(bool enabled);

        void SetInsertMoneyFieldEnabled(bool enabled);
        void SetInsertMoneyFieldText(string text);
        string GetInsertMoneyTextBoxText();

        void SetGetMoneyButtonEnabled(bool enabled);

        void SetCardNumFieldEnabled(bool enabled);
        void SetCardNumFieldText(string text);
        string GetCardNumFieldText();

        void SetCardPinFieldEnabled(bool enabled);
        void SetCarPinFieldText(string text);
        string GetCardPinFieldText();

        void SetInsertButtonEnabled(bool enabled);

        void CloseForm();
        void ShowForm();
    }
}
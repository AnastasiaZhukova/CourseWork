using CourseWork_3_sem.Presenters;
using CourseWork_3_sem.Presenters.MainForm;

namespace CourseWork_3_sem.View
{
    public interface IMainForm
    {
        void SetPresenter(IMainFormPresenter presenter);

        void SetTimeText(string text);
        void SetDateText(string text);

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

        void SetInputFieldEnabled(bool enabled);
        string GetInputTextBoxText();

        void SetGetMoneyButtonEnabled(bool enabled);

        string GetCardNumFieldText();
        string GetCardPinFieldText();

        void SetInsertButtonEnabled(bool enabled);

        void CloseForm();
        void ShowForm();
    }
}
using CourseWork_3_sem.Presenters;
using CourseWork_3_sem.Presenters.MainForm;

namespace CourseWork_3_sem.View
{
    public interface IMainForm
    {
        void SetPresenter(IMainFormPresenter presenter);

        void SetMainTextBox(string text);
        void SetLeftHighTextBox(string text);
        void SetLeftLowTextBox(string text);
        void SetRightLowTextBox(string text);
        void SetRightHighTextBox(string text);

        void SetInputTextBoxVisible(bool visible);
        string GetInputTextBoxText();

        void SetLeftHighButtonEnabled(bool enabled);
        void SetLeftLowButtonEnabled(bool enabled);
        void SetRightLowButtonEnabled(bool enabled);
        void SetRigthHighButtonEnabled(bool enabled);

        void CloseForm();
        void ShowForm();
    }
}
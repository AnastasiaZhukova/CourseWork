namespace CourseWork_3_sem.View
{
    public interface IStartForm
    {
        void ShowInvalidPinDialog();

        void ShowAtmNotAvailableDialog();

        void HideForm();

        void ShowForm();

        void ClearAll();
    }
}
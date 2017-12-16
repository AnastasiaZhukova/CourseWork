using System;
using System.Windows.Forms;

namespace CourseWork_3_sem.View
{
    public partial class PrintCheckDialog : Form
    {
        internal delegate void Result();

        internal event Result OnYes;
        internal event Result OnNo;

        public PrintCheckDialog()
        {
            InitializeComponent();
        }

        private bool _isOk;

        private void button_Yes_Click(object sender, EventArgs e)
        {
            _isOk = true;
            OnYes?.Invoke();
            FinishForm();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            FinishForm();
        }

        private void PrintCheckDialog_Leave(object sender, EventArgs e)
        {
            FinishForm();
        }

        private void PrintCheckDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            FinishForm();
        }

        private void FinishForm()
        {
            if (!_isOk) OnNo?.Invoke();
            Close();
        }
    }
}
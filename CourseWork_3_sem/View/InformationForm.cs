using System;
using System.Windows.Forms;

namespace CourseWork_3_sem.View
{
    public partial class InformationForm : Form
    {
        internal delegate void Finish();

        internal event Finish OnFinish;

        public InformationForm()
        {
            InitializeComponent();
        }

        public void SetInfoText(string text)
        {
            textBox_Info.Text = text;
        }

        private bool _isOk;

        private void button_Ok_Click(object sender, EventArgs e)
        {
            _isOk = true;
            OnFinish?.Invoke();
            FinishForm();
        }

        private void InformationForm_Leave(object sender, EventArgs e)
        {
            FinishForm();
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FinishForm();
        }

        private void FinishForm()
        {
            if (!_isOk) OnFinish?.Invoke();
            Close();
        }
    }
}
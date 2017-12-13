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

        private void button_Ok_Click(object sender, EventArgs e)
        {
            OnFinish?.Invoke();
        }

        private void InformationForm_Leave(object sender, EventArgs e)
        {
            OnFinish?.Invoke();
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFinish?.Invoke();
        }
    }
}
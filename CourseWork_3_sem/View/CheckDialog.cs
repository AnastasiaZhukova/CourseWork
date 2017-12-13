using System;
using System.Windows.Forms;

namespace CourseWork_3_sem.View
{
    public partial class CheckDialog : Form
    {
        internal delegate void Finish();

        internal event Finish OnFinish;

        public CheckDialog()
        {
            InitializeComponent();
        }

        public void SetCheck(string check)
        {
            textBox_Check.Text = check;
        }

        private void button_Take_Click(object sender, EventArgs e)
        {
            OnFinish?.Invoke();
        }

        private void CheckDialog_Leave(object sender, EventArgs e)
        {
            OnFinish?.Invoke();
        }

        private void CheckDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFinish?.Invoke();
        }
    }
}
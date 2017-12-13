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

        private void button_Yes_Click(object sender, EventArgs e)
        {
            OnYes?.Invoke();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            OnNo?.Invoke();
        }

        private void PrintCheckDialog_Leave(object sender, EventArgs e)
        {
            OnNo?.Invoke();
        }

        private void PrintCheckDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnNo?.Invoke();
        }
    }
}
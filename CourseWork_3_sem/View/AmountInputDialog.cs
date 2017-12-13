using System;
using System.Windows.Forms;

namespace CourseWork_3_sem.View
{
    public partial class AmountInputDialog : Form
    {
        internal delegate void Submit(string amount);

        internal delegate void Reject();

        internal event Submit OnSubmit;
        internal event Reject OnReject;


        public AmountInputDialog()
        {
            InitializeComponent();
        }

        private void textBox_InputAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void AmountInputDialog_Leave(object sender, EventArgs e)
        {
            OnReject?.Invoke();
        }

        private void AmountInputDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnReject?.Invoke();
        }
    }
}
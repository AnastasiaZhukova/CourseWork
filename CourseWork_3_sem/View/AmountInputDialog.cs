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

        private bool _isSubmitted;

        private void textBox_InputAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var eKeyChar = e.KeyChar;
            if (!char.IsDigit(eKeyChar) && !char.IsControl(eKeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(eKeyChar) && eKeyChar != '\b')
            {
                e.Handled = true;
            }

            if (!char.IsControl(eKeyChar) || eKeyChar != '\r')
            {
                return;
            }

            e.Handled = true;
            OnSubmit?.Invoke(textBox_InputAmount.Text);
            _isSubmitted = true;
            Close();
        }

        private void AmountInputDialog_Leave(object sender, EventArgs e)
        {
            OnReject?.Invoke();
            Close();
        }


        private void AmountInputDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isSubmitted) OnReject?.Invoke();
            Close();
        }
    }
}
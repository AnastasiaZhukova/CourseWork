using System;
using System.Windows.Forms;
using CourseWork_3_sem.Presenters;

namespace CourseWork_3_sem.View
{
    public partial class StartForm : Form, IStartForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private StartFormPresenter Presenter { get; set; }

        public void ShowInvalidPinDialog()
        {
            throw new NotImplementedException();
        }

        public void ShowAtmNotAvailableDialog()
        {
            throw new NotImplementedException();
        }

        public void HideForm()
        {
            if (Visible)
                Visible = false;
        }

        public void ShowForm()
        {
            if (Visible != true)
                Visible = true;
        }

        public void ClearAll()
        {
            textBox_CardNumber.Text = null;
            textBox_Password.Text = null;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox_CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_CardNumber.Text)
                && !string.IsNullOrEmpty(textBox_Password.Text))
            {
            }
        }
    }
}
using System;
using System.Diagnostics;
using System.Windows.Forms;
using CourseWork_3_sem.Presenters;
using CourseWork_3_sem.Presenters.MainForm;

namespace CourseWork_3_sem.View
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal IMainFormPresenter Presenter { get; set; }

        public void SetPresenter(IMainFormPresenter presenter)
        {
            Presenter = presenter;
            Debug.Print("New presenter set" + presenter.GetType());
        }

        public void SetMainTextBox(string text)
        {
            textBox_Main.Text = text;
        }

        public void SetLeftHighTextBox(string text)
        {
            textBox_LeftHigh.Text = text;
        }

        public void SetLeftLowTextBox(string text)
        {
            textBox_LeftLow.Text = text;
        }

        public void SetRightLowTextBox(string text)
        {
            textBox_RightLow.Text = text;
        }

        public void SetRightHighTextBox(string text)
        {
            textBox_RightHigh.Text = text;
        }

        public void SetInputTextBoxVisible(bool visible)
        {
            textBox_InputAmount.Visible = visible;
        }

        public string GetInputTextBoxText()
        {
            return textBox_InputAmount.Text;
        }

        public void SetLeftHighButtonEnabled(bool enabled)
        {
            button_LeftHight.Enabled = enabled;
        }

        public void SetLeftLowButtonEnabled(bool enabled)
        {
            button_LeftLow.Enabled = enabled;
        }

        public void SetRightLowButtonEnabled(bool enabled)
        {
            button_RightLow.Enabled = enabled;
        }

        public void SetRigthHighButtonEnabled(bool enabled)
        {
            button_RightHigh.Enabled = enabled;
        }

        public void CloseForm()
        {
            Close();
        }

        public void ShowForm()
        {
            Show();
        }

        private void button_LeftHight_Click(object sender, EventArgs e)
        {
            Presenter.OnLeftHighButtonClicked();
        }

        private void button_LeftLow_Click(object sender, EventArgs e)
        {
            Presenter.OnLeftLowButtonClicked();
        }

        private void textBox_InputAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button_RightHigh_Click(object sender, EventArgs e)
        {
            Presenter.OnRightHighButtonClicked();
        }

        private void button_RightLow_Click(object sender, EventArgs e)
        {
            Presenter.OnRightLowButtonClicked();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Presenter.OnExitButtonClicked();
        }
    }
}
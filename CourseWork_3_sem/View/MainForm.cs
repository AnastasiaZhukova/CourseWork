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

        public void SetTimeText(string text)
        {
            label_Time.Text = text;
        }

        public void SetDateText(string text)
        {
            label_Date.Text = text;
        }

        public void SetWindowHighText(string text)
        {
            label_WindowHigh.Text = text;
        }

        public void SetWindowLowText(string text)
        {
            label_WindowLow.Text = text;
        }

        public void SetLeftHighText(string text)
        {
            text_LeftHigh.Text = text;
        }

        public void SetLeftLowText(string text)
        {
            text_LeftLow.Text = text;
        }

        public void SetRightLowText(string text)
        {
            text_RightLow.Text = text;
        }

        public void SetRightHighText(string text)
        {
            text_RightHigh.Text = text;
        }

        public void SetInputFieldEnabled(bool enabled)
        {
            textBox_InputAmount.Visible = enabled;
        }

        public string GetInputTextBoxText()
        {
            return textBox_InputAmount.Text;
        }

        public void SetGetMoneyButtonEnabled(bool enabled)
        {
            button_TakeMoney.Enabled = enabled;
        }

        public string GetCardNumFieldText()
        {
            return textBox_CardNum.Text;
        }

        public string GetCardPinFieldText()
        {
            return textBox_Pin.Text;
        }

        public void SetInsertButtonEnabled(bool enabled)
        {
            button_InsertCard.Enabled = enabled;
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


        /*****************************************************************/
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button_LH_Click(object sender, EventArgs e)
        {
        }

        private void button_LL_Click(object sender, EventArgs e)
        {
        }

        private void button_RH_Click(object sender, EventArgs e)
        {
        }

        private void button_RL_Click(object sender, EventArgs e)
        {
        }

        private void button_TakeMoney_Click(object sender, EventArgs e)
        {
        }

        private void textBox_CardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox_CardPin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button_InsertCard_Click(object sender, EventArgs e)
        {
        }
    }
}
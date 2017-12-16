using System;
using System.Diagnostics;
using System.Drawing;
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

        private IMainFormPresenter Presenter { get; set; }

        public void SetPresenter(IMainFormPresenter presenter)
        {
            Presenter = presenter;
            Debug.Print("New presenter set" + presenter.GetType());
        }

        public void SetTimeText(string text)
        {
            if (label_Time.InvokeRequired && !label_Time.Disposing)
            {
                label_Time.Invoke(new Action(() => { label_Time.Text = text; }));
            }
            else
            {
                label_Time.Text = text;
            }
        }

        public void SetWindowHighText(string text)
        {
            if (label_WindowHigh.InvokeRequired)
            {
                label_WindowHigh.Invoke(new Action(() => { label_WindowHigh.Text = text; }));
            }
            else
            {
                label_WindowHigh.Text = text;
            }
        }

        public void SetWindowLowText(string text)
        {
            if (label_WindowLow.InvokeRequired)
            {
                label_WindowLow.Invoke(new Action(() => { label_WindowLow.Text = text; }));
            }
            else
            {
                label_WindowLow.Text = text;
            }
        }

        public void SetLeftHighText(string text)
        {
            if (text_LeftHigh.InvokeRequired)
            {
                text_LeftHigh.Invoke(new Action(() => { text_LeftHigh.Text = text; }));
            }
            else
            {
                text_LeftHigh.Text = text;
            }
        }

        public void SetLeftLowText(string text)
        {
            if (text_LeftLow.InvokeRequired)
            {
                text_LeftLow.Invoke(new Action(() => { text_LeftLow.Text = text; }));
            }
            else
            {
                text_LeftLow.Text = text;
            }
        }

        public void SetRightLowText(string text)
        {
            if (text_RightLow.InvokeRequired)
            {
                text_RightLow.Invoke(new Action(() => { text_RightLow.Text = text; }));
            }
            else
            {
                text_RightLow.Text = text;
            }
        }

        public void SetRightHighText(string text)
        {
            if (text_RightHigh.InvokeRequired)
            {
                text_RightHigh.Invoke(new Action(() => { text_RightHigh.Text = text; }));
            }
            else
            {
                text_RightHigh.Text = text;
            }
        }

        public void SetInsertMoneyFieldEnabled(bool enabled)
        {
            Color backColor;
            if (enabled) backColor = Color.LightGreen;
            else backColor = SystemColors.Window;

            if (textBox_InputAmount.InvokeRequired)
            {
                textBox_InputAmount.Invoke(new Action(() =>
                {
                    textBox_InputAmount.Enabled = enabled;
                    textBox_InputAmount.BackColor = backColor;
                }));
            }
            else
            {
                textBox_InputAmount.Enabled = enabled;
                textBox_InputAmount.BackColor = backColor;
            }
        }

        public void SetInsertMoneyFieldText(string text)
        {
            if (textBox_InputAmount.InvokeRequired)
            {
                textBox_InputAmount.Invoke(new Action(() => { textBox_InputAmount.Text = text; }));
            }
            else
            {
                textBox_InputAmount.Text = text;
            }
        }

        public string GetInsertMoneyTextBoxText()
        {
            return textBox_InputAmount.Text;
        }

        public void SetGetMoneyButtonEnabled(bool enabled)
        {
            if (button_TakeMoney.InvokeRequired)
            {
                button_TakeMoney.Invoke(new Action(() => { button_TakeMoney.Enabled = enabled; }));
            }
            else
            {
                button_TakeMoney.Enabled = enabled;
            }
        }

        public void SetGetMoneyButtonText(string text)
        {
            if (button_TakeMoney.InvokeRequired)
            {
                button_TakeMoney.Invoke(new Action(() => { button_TakeMoney.Text = text; }));
            }
            else
            {
                button_TakeMoney.Text = text;
            }
        }

        public void SetCardNumFieldEnabled(bool enabled)
        {
            if (textBox_CardNum.InvokeRequired)
            {
                textBox_CardNum.Invoke(new Action(() => { textBox_CardNum.Enabled = enabled; }));
            }
            else
            {
                textBox_CardNum.Enabled = enabled;
            }
        }

        public void SetCardNumFieldText(string text)
        {
            if (textBox_CardNum.InvokeRequired)
            {
                textBox_CardNum.Invoke(new Action(() => { textBox_CardNum.Text = text; }));
            }
            else
            {
                textBox_CardNum.Text = text;
            }
        }

        public string GetCardNumFieldText()
        {
            return textBox_CardNum.Text;
        }

        public void SetCardPinFieldEnabled(bool enabled)
        {
            if (textBox_CardPin.InvokeRequired)
            {
                textBox_CardPin.Invoke(new Action(() => { textBox_CardPin.Enabled = enabled; }));
            }
            else
            {
                textBox_CardPin.Enabled = enabled;
            }
        }

        public void SetCarPinFieldText(string text)
        {
            if (textBox_CardPin.InvokeRequired)
            {
                textBox_CardPin.Invoke(new Action(() => { textBox_CardPin.Text = text; }));
            }
            else
            {
                textBox_CardPin.Text = text;
            }
        }

        public string GetCardPinFieldText()
        {
            return textBox_CardPin.Text;
        }

        public void SetInsertButtonEnabled(bool enabled)
        {
            if (button_InsertCard.InvokeRequired)
            {
                button_InsertCard.Invoke(new Action(() => { button_InsertCard.Enabled = enabled; }));
            }
            else
            {
                button_InsertCard.Enabled = enabled;
            }
        }

        public void SetLeftHighButtonEnabled(bool enabled)
        {
            if (button_LH.InvokeRequired)
            {
                button_LH.Invoke(new Action(() => { button_LH.Enabled = enabled; }));
            }
            else
            {
                button_LH.Enabled = enabled;
            }
        }

        public void SetLeftLowButtonEnabled(bool enabled)
        {
            if (button_LL.InvokeRequired)
            {
                button_LL.Invoke(new Action(() => { button_LL.Enabled = enabled; }));
            }
            else
            {
                button_LL.Enabled = enabled;
            }
        }

        public void SetRightLowButtonEnabled(bool enabled)
        {
            if (button_RL.InvokeRequired)
            {
                button_RL.Invoke(new Action(() => { button_RL.Enabled = enabled; }));
            }
            else
            {
                button_RL.Enabled = enabled;
            }
        }

        public void SetRigthHighButtonEnabled(bool enabled)
        {
            if (button_RH.InvokeRequired)
            {
                button_RH.Invoke(new Action(() => { button_RH.Enabled = enabled; }));
            }
            else
            {
                button_RH.Enabled = enabled;
            }
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

            if (!char.IsControl(eKeyChar) || eKeyChar != '\r') return;

            e.Handled = true;
            Presenter.OnInsertMoney();
        }

        private void button_LH_Click(object sender, EventArgs e)
        {
            Presenter.OnLeftHighButtonClicked();
        }

        private void button_LL_Click(object sender, EventArgs e)
        {
            Presenter.OnLeftLowButtonClicked();
        }

        private void button_RH_Click(object sender, EventArgs e)
        {
            Presenter.OnRightHighButtonClicked();
        }

        private void button_RL_Click(object sender, EventArgs e)
        {
            Presenter.OnRightLowButtonClicked();
        }

        private void button_TakeMoney_Click(object sender, EventArgs e)
        {
            Presenter.OnTakeMoneyButtonClicked();
        }

        private void textBox_CardNum_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void textBox_CardPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            var eKeyChar = e.KeyChar;
/*            if (textBox_CardPin.Text.Length >= 4 && !char.IsControl(eKeyChar))
            {
                e.Handled = true;
            }*/
            if (!char.IsDigit(eKeyChar) && !char.IsControl(eKeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(eKeyChar) && eKeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button_InsertCard_Click(object sender, EventArgs e)
        {
            Presenter.OnInsertCardButtonClicked();
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            Presenter.OnExit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Presenter.OnExit();
        }
    }
}
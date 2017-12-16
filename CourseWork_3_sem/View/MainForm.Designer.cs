using System.Windows.Forms;
using CourseWork_3_sem.View;

namespace CourseWork_3_sem.View
{
    partial class MainForm : Form, IMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_InputAmount = new System.Windows.Forms.TextBox();
            this.label_InputAmount = new System.Windows.Forms.Label();
            this.text_RightLow = new System.Windows.Forms.TextBox();
            this.text_RightHigh = new System.Windows.Forms.TextBox();
            this.text_LeftHigh = new System.Windows.Forms.TextBox();
            this.text_LeftLow = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button_InsertCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CardPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CardNum = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.label_Pin = new System.Windows.Forms.Label();
            this.textBox_Pin = new System.Windows.Forms.TextBox();
            this.label_Insert = new System.Windows.Forms.Label();
            this.textBox_CardNumber = new System.Windows.Forms.TextBox();
            this.button_RL = new System.Windows.Forms.Button();
            this.button_RH = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_TakeMoney = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_WindowLow = new System.Windows.Forms.Label();
            this.label_WindowHigh = new System.Windows.Forms.Label();
            this.button_LL = new System.Windows.Forms.Button();
            this.button_LH = new System.Windows.Forms.Button();
            this.panel_Input = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_InputAmount
            // 
            this.textBox_InputAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_InputAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_InputAmount.Enabled = false;
            this.textBox_InputAmount.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_InputAmount.Location = new System.Drawing.Point(8, 38);
            this.textBox_InputAmount.Name = "textBox_InputAmount";
            this.textBox_InputAmount.Size = new System.Drawing.Size(387, 24);
            this.textBox_InputAmount.TabIndex = 1;
            this.textBox_InputAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InputAmount_KeyPress);
            // 
            // label_InputAmount
            // 
            this.label_InputAmount.AutoSize = true;
            this.label_InputAmount.BackColor = System.Drawing.Color.Silver;
            this.label_InputAmount.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InputAmount.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_InputAmount.Location = new System.Drawing.Point(3, 7);
            this.label_InputAmount.Name = "label_InputAmount";
            this.label_InputAmount.Size = new System.Drawing.Size(378, 19);
            this.label_InputAmount.TabIndex = 15;
            this.label_InputAmount.Text = "Insert money here(press Enter to insert):";
            // 
            // text_RightLow
            // 
            this.text_RightLow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_RightLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_RightLow.Enabled = false;
            this.text_RightLow.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_RightLow.Location = new System.Drawing.Point(315, 419);
            this.text_RightLow.Name = "text_RightLow";
            this.text_RightLow.ReadOnly = true;
            this.text_RightLow.Size = new System.Drawing.Size(198, 36);
            this.text_RightLow.TabIndex = 12;
            this.text_RightLow.Tag = "RL";
            this.text_RightLow.Text = "RightLow";
            this.text_RightLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_RightHigh
            // 
            this.text_RightHigh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_RightHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_RightHigh.Enabled = false;
            this.text_RightHigh.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_RightHigh.Location = new System.Drawing.Point(315, 379);
            this.text_RightHigh.Name = "text_RightHigh";
            this.text_RightHigh.ReadOnly = true;
            this.text_RightHigh.Size = new System.Drawing.Size(198, 36);
            this.text_RightHigh.TabIndex = 12;
            this.text_RightHigh.Tag = "RH";
            this.text_RightHigh.Text = "RightHigh";
            this.text_RightHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_LeftHigh
            // 
            this.text_LeftHigh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_LeftHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_LeftHigh.Enabled = false;
            this.text_LeftHigh.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_LeftHigh.Location = new System.Drawing.Point(73, 379);
            this.text_LeftHigh.Name = "text_LeftHigh";
            this.text_LeftHigh.ReadOnly = true;
            this.text_LeftHigh.Size = new System.Drawing.Size(198, 36);
            this.text_LeftHigh.TabIndex = 12;
            this.text_LeftHigh.Tag = "LH";
            this.text_LeftHigh.Text = "LeftHigh";
            // 
            // text_LeftLow
            // 
            this.text_LeftLow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_LeftLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_LeftLow.Enabled = false;
            this.text_LeftLow.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_LeftLow.Location = new System.Drawing.Point(73, 419);
            this.text_LeftLow.Name = "text_LeftLow";
            this.text_LeftLow.ReadOnly = true;
            this.text_LeftLow.Size = new System.Drawing.Size(198, 36);
            this.text_LeftLow.TabIndex = 12;
            this.text_LeftLow.Tag = "LL";
            this.text_LeftLow.Text = "LeftLow";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button_Insert);
            this.panel2.Controls.Add(this.label_Pin);
            this.panel2.Controls.Add(this.textBox_Pin);
            this.panel2.Controls.Add(this.label_Insert);
            this.panel2.Controls.Add(this.textBox_CardNumber);
            this.panel2.Location = new System.Drawing.Point(657, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 723);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.button_InsertCard);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_CardPin);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_CardNum);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 723);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(290, 688);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(146, 312);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(256, 312);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(104, 104);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // button_InsertCard
            // 
            this.button_InsertCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_InsertCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_InsertCard.Font = new System.Drawing.Font("Consolas", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_InsertCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_InsertCard.Location = new System.Drawing.Point(20, 207);
            this.button_InsertCard.Name = "button_InsertCard";
            this.button_InsertCard.Size = new System.Drawing.Size(340, 38);
            this.button_InsertCard.TabIndex = 4;
            this.button_InsertCard.Text = "Insert";
            this.button_InsertCard.UseVisualStyleBackColor = false;
            this.button_InsertCard.Click += new System.EventHandler(this.button_InsertCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(317, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pin";
            // 
            // textBox_CardPin
            // 
            this.textBox_CardPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CardPin.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CardPin.Location = new System.Drawing.Point(257, 152);
            this.textBox_CardPin.Name = "textBox_CardPin";
            this.textBox_CardPin.PasswordChar = '*';
            this.textBox_CardPin.Size = new System.Drawing.Size(108, 31);
            this.textBox_CardPin.TabIndex = 2;
            this.textBox_CardPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_CardPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CardPin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card number";
            // 
            // textBox_CardNum
            // 
            this.textBox_CardNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CardNum.Location = new System.Drawing.Point(22, 68);
            this.textBox_CardNum.Name = "textBox_CardNum";
            this.textBox_CardNum.Size = new System.Drawing.Size(345, 30);
            this.textBox_CardNum.TabIndex = 0;
            this.textBox_CardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_CardNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CardNum_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(290, 688);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(146, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_Insert
            // 
            this.button_Insert.Font = new System.Drawing.Font("Consolas", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Insert.Location = new System.Drawing.Point(20, 207);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(340, 38);
            this.button_Insert.TabIndex = 4;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // label_Pin
            // 
            this.label_Pin.AutoSize = true;
            this.label_Pin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Pin.Location = new System.Drawing.Point(320, 127);
            this.label_Pin.Name = "label_Pin";
            this.label_Pin.Size = new System.Drawing.Size(40, 22);
            this.label_Pin.TabIndex = 3;
            this.label_Pin.Text = "Pin";
            // 
            // textBox_Pin
            // 
            this.textBox_Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pin.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pin.Location = new System.Drawing.Point(257, 152);
            this.textBox_Pin.Name = "textBox_Pin";
            this.textBox_Pin.PasswordChar = '*';
            this.textBox_Pin.Size = new System.Drawing.Size(104, 31);
            this.textBox_Pin.TabIndex = 2;
            this.textBox_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Insert
            // 
            this.label_Insert.AutoSize = true;
            this.label_Insert.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Insert.Location = new System.Drawing.Point(240, 66);
            this.label_Insert.Name = "label_Insert";
            this.label_Insert.Size = new System.Drawing.Size(120, 22);
            this.label_Insert.TabIndex = 1;
            this.label_Insert.Text = "Card number";
            // 
            // textBox_CardNumber
            // 
            this.textBox_CardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CardNumber.Location = new System.Drawing.Point(20, 91);
            this.textBox_CardNumber.Name = "textBox_CardNumber";
            this.textBox_CardNumber.Size = new System.Drawing.Size(341, 30);
            this.textBox_CardNumber.TabIndex = 0;
            this.textBox_CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_RL
            // 
            this.button_RL.Enabled = false;
            this.button_RL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RL.ForeColor = System.Drawing.Color.Orange;
            this.button_RL.Location = new System.Drawing.Point(519, 419);
            this.button_RL.Name = "button_RL";
            this.button_RL.Size = new System.Drawing.Size(59, 43);
            this.button_RL.TabIndex = 10;
            this.button_RL.Text = "___";
            this.button_RL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_RL.UseVisualStyleBackColor = true;
            this.button_RL.Click += new System.EventHandler(this.button_RL_Click);
            // 
            // button_RH
            // 
            this.button_RH.Enabled = false;
            this.button_RH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RH.ForeColor = System.Drawing.Color.Orange;
            this.button_RH.Location = new System.Drawing.Point(519, 372);
            this.button_RH.Name = "button_RH";
            this.button_RH.Size = new System.Drawing.Size(59, 43);
            this.button_RH.TabIndex = 12;
            this.button_RH.Text = "___";
            this.button_RH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_RH.UseVisualStyleBackColor = true;
            this.button_RH.Click += new System.EventHandler(this.button_RH_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_TakeMoney);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel_Input);
            this.panel4.Location = new System.Drawing.Point(19, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 722);
            this.panel4.TabIndex = 14;
            // 
            // button_TakeMoney
            // 
            this.button_TakeMoney.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_TakeMoney.Enabled = false;
            this.button_TakeMoney.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_TakeMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TakeMoney.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TakeMoney.Location = new System.Drawing.Point(26, 612);
            this.button_TakeMoney.Name = "button_TakeMoney";
            this.button_TakeMoney.Size = new System.Drawing.Size(535, 66);
            this.button_TakeMoney.TabIndex = 20;
            this.button_TakeMoney.UseVisualStyleBackColor = false;
            this.button_TakeMoney.Click += new System.EventHandler(this.button_TakeMoney_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.text_RightHigh);
            this.panel1.Controls.Add(this.text_LeftLow);
            this.panel1.Controls.Add(this.text_RightLow);
            this.panel1.Controls.Add(this.button_LL);
            this.panel1.Controls.Add(this.text_LeftHigh);
            this.panel1.Controls.Add(this.button_RL);
            this.panel1.Controls.Add(this.button_LH);
            this.panel1.Controls.Add(this.button_RH);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 465);
            this.panel1.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label_Time);
            this.panel5.Controls.Add(this.label_WindowLow);
            this.panel5.Controls.Add(this.label_WindowHigh);
            this.panel5.Location = new System.Drawing.Point(0, -3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(578, 362);
            this.panel5.TabIndex = 18;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(8, 8);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(54, 19);
            this.label_Time.TabIndex = 2;
            this.label_Time.Text = "15:03";
            // 
            // label_WindowLow
            // 
            this.label_WindowLow.BackColor = System.Drawing.Color.Transparent;
            this.label_WindowLow.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WindowLow.Location = new System.Drawing.Point(66, 209);
            this.label_WindowLow.Name = "label_WindowLow";
            this.label_WindowLow.Size = new System.Drawing.Size(460, 120);
            this.label_WindowLow.TabIndex = 1;
            this.label_WindowLow.Text = "VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryV" +
    "eryVeryVeryVeryVeryVery";
            this.label_WindowLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WindowHigh
            // 
            this.label_WindowHigh.BackColor = System.Drawing.Color.Transparent;
            this.label_WindowHigh.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WindowHigh.Location = new System.Drawing.Point(66, 76);
            this.label_WindowHigh.Name = "label_WindowHigh";
            this.label_WindowHigh.Size = new System.Drawing.Size(460, 120);
            this.label_WindowHigh.TabIndex = 0;
            this.label_WindowHigh.Text = "VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryV" +
    "eryVeryVeryVeryVeryVery";
            this.label_WindowHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_LL
            // 
            this.button_LL.Enabled = false;
            this.button_LL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LL.ForeColor = System.Drawing.Color.Orange;
            this.button_LL.Location = new System.Drawing.Point(3, 419);
            this.button_LL.Name = "button_LL";
            this.button_LL.Size = new System.Drawing.Size(59, 43);
            this.button_LL.TabIndex = 17;
            this.button_LL.Text = "___";
            this.button_LL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_LL.UseVisualStyleBackColor = true;
            this.button_LL.Click += new System.EventHandler(this.button_LL_Click);
            // 
            // button_LH
            // 
            this.button_LH.Enabled = false;
            this.button_LH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LH.ForeColor = System.Drawing.Color.Orange;
            this.button_LH.Location = new System.Drawing.Point(3, 372);
            this.button_LH.Name = "button_LH";
            this.button_LH.Size = new System.Drawing.Size(59, 43);
            this.button_LH.TabIndex = 16;
            this.button_LH.Text = "___";
            this.button_LH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_LH.UseVisualStyleBackColor = true;
            this.button_LH.Click += new System.EventHandler(this.button_LH_Click);
            // 
            // panel_Input
            // 
            this.panel_Input.Controls.Add(this.label_InputAmount);
            this.panel_Input.Controls.Add(this.textBox_InputAmount);
            this.panel_Input.Location = new System.Drawing.Point(150, 509);
            this.panel_Input.Name = "panel_Input";
            this.panel_Input.Size = new System.Drawing.Size(411, 78);
            this.panel_Input.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1051, 765);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_Input.ResumeLayout(false);
            this.panel_Input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_InputAmount;
  
        private System.Windows.Forms.TextBox text_LeftHigh;
        private System.Windows.Forms.TextBox text_LeftLow;
        private System.Windows.Forms.TextBox text_RightLow;
        private System.Windows.Forms.TextBox text_RightHigh;

        private System.Windows.Forms.Label label_InputAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label_Pin;
        private System.Windows.Forms.TextBox textBox_Pin;
        private System.Windows.Forms.Label label_Insert;
        private System.Windows.Forms.TextBox textBox_CardNumber;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Button button_RL;
        private Button button_RH;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button_InsertCard;
        private Label label1;
        private TextBox textBox_CardPin;
        private Label label2;
        private TextBox textBox_CardNum;
        private Panel panel4;
        private Panel panel_Input;
        private Button button_LL;
        private Button button_LH;
        private Panel panel1;
        private Panel panel5;
        private Button button_TakeMoney;
        private Label label_Time;
        private Label label_WindowLow;
        private Label label_WindowHigh;
    }
}
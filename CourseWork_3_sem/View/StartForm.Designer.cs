namespace CourseWork_3_sem.View
{
    partial class StartForm
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
            this.textBox_CardNumber = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Pincode = new System.Windows.Forms.Label();
            this.button_Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CardNumber
            // 
            this.textBox_CardNumber.Location = new System.Drawing.Point(207, 141);
            this.textBox_CardNumber.Name = "textBox_CardNumber";
            this.textBox_CardNumber.Size = new System.Drawing.Size(336, 26);
            this.textBox_CardNumber.TabIndex = 0;
            this.textBox_CardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CardNumber_KeyPress);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(207, 211);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(336, 26);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(63, 141);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(103, 20);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "Card Number";
            // 
            // label_Pincode
            // 
            this.label_Pincode.AutoSize = true;
            this.label_Pincode.Location = new System.Drawing.Point(63, 217);
            this.label_Pincode.Name = "label_Pincode";
            this.label_Pincode.Size = new System.Drawing.Size(31, 20);
            this.label_Pincode.TabIndex = 3;
            this.label_Pincode.Text = "Pin";
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(451, 268);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(92, 41);
            this.button_Insert.TabIndex = 4;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 515);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.label_Pincode);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_CardNumber);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CardNumber;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Pincode;
        private System.Windows.Forms.Button button_Insert;
    }
}
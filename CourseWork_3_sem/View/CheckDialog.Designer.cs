namespace CourseWork_3_sem.View
{
    partial class CheckDialog
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
            this.textBox_Check = new System.Windows.Forms.TextBox();
            this.button_Take = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Check
            // 
            this.textBox_Check.Enabled = false;
            this.textBox_Check.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Check.Location = new System.Drawing.Point(13, 13);
            this.textBox_Check.Multiline = true;
            this.textBox_Check.Name = "textBox_Check";
            this.textBox_Check.ReadOnly = true;
            this.textBox_Check.Size = new System.Drawing.Size(346, 551);
            this.textBox_Check.TabIndex = 0;
            // 
            // button_Take
            // 
            this.button_Take.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Take.Location = new System.Drawing.Point(195, 571);
            this.button_Take.Name = "button_Take";
            this.button_Take.Size = new System.Drawing.Size(164, 28);
            this.button_Take.TabIndex = 1;
            this.button_Take.Text = "Take";
            this.button_Take.UseVisualStyleBackColor = true;
            this.button_Take.Click += new System.EventHandler(this.button_Take_Click);
            // 
            // CheckDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 611);
            this.Controls.Add(this.button_Take);
            this.Controls.Add(this.textBox_Check);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckDialog";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckDialog_FormClosed);
            this.Leave += new System.EventHandler(this.CheckDialog_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Check;
        private System.Windows.Forms.Button button_Take;
    }
}
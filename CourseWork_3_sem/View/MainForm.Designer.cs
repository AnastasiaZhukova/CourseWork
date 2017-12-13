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
            this.textBox_InputAmount = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_LeftLow = new System.Windows.Forms.Button();
            this.textBox_LeftLow = new System.Windows.Forms.TextBox();
            this.textBox_LeftHigh = new System.Windows.Forms.TextBox();
            this.button_LeftHight = new System.Windows.Forms.Button();
            this.textBox_RightHigh = new System.Windows.Forms.TextBox();
            this.textBox_RightLow = new System.Windows.Forms.TextBox();
            this.button_RightHigh = new System.Windows.Forms.Button();
            this.button_RightLow = new System.Windows.Forms.Button();
            this.textBox_Main = new System.Windows.Forms.TextBox();
            this.label_InputAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_InputAmount
            // 
            this.textBox_InputAmount.Location = new System.Drawing.Point(3, 285);
            this.textBox_InputAmount.Name = "textBox_InputAmount";
            this.textBox_InputAmount.Size = new System.Drawing.Size(359, 26);
            this.textBox_InputAmount.TabIndex = 1;
            this.textBox_InputAmount.Visible = false;
            this.textBox_InputAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InputAmount_KeyPress);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(423, 457);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(128, 45);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label_InputAmount);
            this.panel1.Controls.Add(this.textBox_Main);
            this.panel1.Controls.Add(this.textBox_RightLow);
            this.panel1.Controls.Add(this.textBox_RightHigh);
            this.panel1.Controls.Add(this.textBox_LeftHigh);
            this.panel1.Controls.Add(this.textBox_LeftLow);
            this.panel1.Controls.Add(this.textBox_InputAmount);
            this.panel1.Location = new System.Drawing.Point(99, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 410);
            this.panel1.TabIndex = 7;
            // 
            // button_LeftLow
            // 
            this.button_LeftLow.Location = new System.Drawing.Point(12, 389);
            this.button_LeftLow.Name = "button_LeftLow";
            this.button_LeftLow.Size = new System.Drawing.Size(81, 41);
            this.button_LeftLow.TabIndex = 9;
            this.button_LeftLow.UseVisualStyleBackColor = true;
            this.button_LeftLow.Click += new System.EventHandler(this.button_LeftLow_Click);
            // 
            // textBox_LegtLow
            // 
            this.textBox_LeftLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LeftLow.Location = new System.Drawing.Point(3, 366);
            this.textBox_LeftLow.Name = "textBox_LeftLow";
            this.textBox_LeftLow.ReadOnly = true;
            this.textBox_LeftLow.Size = new System.Drawing.Size(157, 41);
            this.textBox_LeftLow.TabIndex = 11;
            this.textBox_LeftLow.Text = "LeftLow";
            this.textBox_LeftLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_LeftHigh
            // 
            this.textBox_LeftHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LeftHigh.Location = new System.Drawing.Point(3, 319);
            this.textBox_LeftHigh.Name = "textBox_LeftHigh";
            this.textBox_LeftHigh.ReadOnly = true;
            this.textBox_LeftHigh.Size = new System.Drawing.Size(157, 41);
            this.textBox_LeftHigh.TabIndex = 12;
            this.textBox_LeftHigh.Text = "LeftHigh";
            this.textBox_LeftHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_LeftHight
            // 
            this.button_LeftHight.Location = new System.Drawing.Point(12, 342);
            this.button_LeftHight.Name = "button_LeftHight";
            this.button_LeftHight.Size = new System.Drawing.Size(81, 41);
            this.button_LeftHight.TabIndex = 10;
            this.button_LeftHight.UseVisualStyleBackColor = true;
            this.button_LeftHight.Click += new System.EventHandler(this.button_LeftHight_Click);
            // 
            // textBox_RightHigh
            // 
            this.textBox_RightHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RightHigh.Location = new System.Drawing.Point(205, 319);
            this.textBox_RightHigh.Name = "textBox_RightHigh";
            this.textBox_RightHigh.ReadOnly = true;
            this.textBox_RightHigh.Size = new System.Drawing.Size(157, 41);
            this.textBox_RightHigh.TabIndex = 13;
            this.textBox_RightHigh.Text = "RightHigh";
            this.textBox_RightHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_RightLow
            // 
            this.textBox_RightLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RightLow.Location = new System.Drawing.Point(205, 366);
            this.textBox_RightLow.Name = "textBox_RightLow";
            this.textBox_RightLow.ReadOnly = true;
            this.textBox_RightLow.Size = new System.Drawing.Size(157, 41);
            this.textBox_RightLow.TabIndex = 14;
            this.textBox_RightLow.Text = "RightLow";
            this.textBox_RightLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_RightHigh
            // 
            this.button_RightHigh.Location = new System.Drawing.Point(470, 342);
            this.button_RightHigh.Name = "button_RightHigh";
            this.button_RightHigh.Size = new System.Drawing.Size(81, 41);
            this.button_RightHigh.TabIndex = 11;
            this.button_RightHigh.UseVisualStyleBackColor = true;
            this.button_RightHigh.Click += new System.EventHandler(this.button_RightHigh_Click);
            // 
            // button_RightLow
            // 
            this.button_RightLow.Location = new System.Drawing.Point(470, 389);
            this.button_RightLow.Name = "button_RightLow";
            this.button_RightLow.Size = new System.Drawing.Size(81, 41);
            this.button_RightLow.TabIndex = 12;
            this.button_RightLow.UseVisualStyleBackColor = true;
            this.button_RightLow.Click += new System.EventHandler(this.button_RightLow_Click);
            // 
            // textBox_Main
            // 
            this.textBox_Main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Main.Location = new System.Drawing.Point(3, 3);
            this.textBox_Main.Multiline = true;
            this.textBox_Main.Name = "textBox_Main";
            this.textBox_Main.ReadOnly = true;
            this.textBox_Main.Size = new System.Drawing.Size(359, 252);
            this.textBox_Main.TabIndex = 13;
            // 
            // label_InputAmount
            // 
            this.label_InputAmount.AutoSize = true;
            this.label_InputAmount.Location = new System.Drawing.Point(4, 262);
            this.label_InputAmount.Name = "label_InputAmount";
            this.label_InputAmount.Size = new System.Drawing.Size(50, 20);
            this.label_InputAmount.TabIndex = 15;
            this.label_InputAmount.Text = "Input:";
            this.label_InputAmount.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 514);
            this.Controls.Add(this.button_RightLow);
            this.Controls.Add(this.button_RightHigh);
            this.Controls.Add(this.button_LeftHight);
            this.Controls.Add(this.button_LeftLow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Exit);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_InputAmount;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_LeftLow;
        private System.Windows.Forms.TextBox textBox_LeftHigh;
        private System.Windows.Forms.TextBox textBox_LeftLow;
        private System.Windows.Forms.TextBox textBox_Main;
        private System.Windows.Forms.TextBox textBox_RightLow;
        private System.Windows.Forms.TextBox textBox_RightHigh;
        private System.Windows.Forms.Button button_LeftHight;
        private System.Windows.Forms.Button button_RightHigh;
        private System.Windows.Forms.Button button_RightLow;
        private System.Windows.Forms.Label label_InputAmount;
    }
}
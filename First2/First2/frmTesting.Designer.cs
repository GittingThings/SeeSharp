﻿namespace First2
{
    partial class frmTesting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            txtArraySize = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(345, 114);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Test";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtArraySize
            // 
            txtArraySize.Location = new Point(330, 143);
            txtArraySize.Name = "txtArraySize";
            txtArraySize.Size = new Size(100, 23);
            txtArraySize.TabIndex = 1;
           

            // 
            // frmTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArraySize);
            Controls.Add(btnStart);
            Name = "frmTesting";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnStart;
        private TextBox txtArraySize;
    }
}
#endregion
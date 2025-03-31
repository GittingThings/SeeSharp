namespace LPS
{
    partial class Form2
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
            btnConvert = new Button();
            lbloutput = new Label();
            label2 = new Label();
            txtinput = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(317, 178);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lbloutput
            // 
            lbloutput.AutoSize = true;
            lbloutput.Location = new Point(334, 141);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(93, 15);
            lbloutput.TabIndex = 1;
            lbloutput.Text = "Output Doubled";
            lbloutput.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 101);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Input:";
            // 
            // txtinput
            // 
            txtinput.Location = new Point(317, 98);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(100, 23);
            txtinput.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(713, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(txtinput);
            Controls.Add(label2);
            Controls.Add(lbloutput);
            Controls.Add(btnConvert);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Label lbloutput;
        private Label label2;
        private TextBox txtinput;
        private Button btnExit;
    }
}
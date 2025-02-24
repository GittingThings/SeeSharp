namespace Calculator
{
    partial class frmConvert
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
            lblInput = new Label();
            lbloutput = new Label();
            txtinput = new TextBox();
            btnconvert = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(235, 127);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(82, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input Number";
            // 
            // lbloutput
            // 
            lbloutput.AutoSize = true;
            lbloutput.Location = new Point(250, 174);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(48, 15);
            lbloutput.TabIndex = 1;
            lbloutput.Text = "Output:";
            lbloutput.Click += lbloutput_Click;
            // 
            // txtinput
            // 
            txtinput.Location = new Point(341, 124);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(115, 23);
            txtinput.TabIndex = 2;
            txtinput.TextChanged += txtinput_TextChanged;
            // 
            // btnconvert
            // 
            btnconvert.Location = new Point(341, 208);
            btnconvert.Name = "btnconvert";
            btnconvert.Size = new Size(112, 25);
            btnconvert.TabIndex = 3;
            btnconvert.Text = "Convert";
            btnconvert.UseVisualStyleBackColor = true;
            btnconvert.Click += btnconvert_Click;
            // 
            // frmConvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnconvert);
            Controls.Add(txtinput);
            Controls.Add(lbloutput);
            Controls.Add(lblInput);
            Name = "frmConvert";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private Label lbloutput;
        private TextBox txtinput;
        private Button btnconvert;
    }
}

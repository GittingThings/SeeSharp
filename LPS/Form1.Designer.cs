namespace LPS
{
    partial class Form1
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
            btnFor = new Button();
            btnWhileLoop = new Button();
            label1 = new Label();
            txtMaxNum = new TextBox();
            lbCountdown = new ListBox();
            btnOpenForm = new Button();
            SuspendLayout();
            // 
            // btnFor
            // 
            btnFor.Location = new Point(277, 120);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(121, 23);
            btnFor.TabIndex = 0;
            btnFor.Text = "For Loop";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnWhileLoop
            // 
            btnWhileLoop.Location = new Point(404, 120);
            btnWhileLoop.Name = "btnWhileLoop";
            btnWhileLoop.Size = new Size(108, 23);
            btnWhileLoop.TabIndex = 1;
            btnWhileLoop.Text = "While Loop";
            btnWhileLoop.UseVisualStyleBackColor = true;
            btnWhileLoop.Click += btnWhileLoop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 64);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Type in max number";
            // 
            // txtMaxNum
            // 
            txtMaxNum.Location = new Point(320, 91);
            txtMaxNum.Name = "txtMaxNum";
            txtMaxNum.Size = new Size(146, 23);
            txtMaxNum.TabIndex = 3;
            // 
            // lbCountdown
            // 
            lbCountdown.FormattingEnabled = true;
            lbCountdown.ItemHeight = 15;
            lbCountdown.Location = new Point(277, 149);
            lbCountdown.Name = "lbCountdown";
            lbCountdown.Size = new Size(235, 274);
            lbCountdown.TabIndex = 4;
            // 
            // btnOpenForm
            // 
            btnOpenForm.Location = new Point(713, 12);
            btnOpenForm.Name = "btnOpenForm";
            btnOpenForm.Size = new Size(75, 23);
            btnOpenForm.TabIndex = 5;
            btnOpenForm.Text = "Open Form";
            btnOpenForm.UseVisualStyleBackColor = true;
            btnOpenForm.Click += btnOpenForm_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenForm);
            Controls.Add(lbCountdown);
            Controls.Add(txtMaxNum);
            Controls.Add(label1);
            Controls.Add(btnWhileLoop);
            Controls.Add(btnFor);
            Name = "Form1";
            Text = "Number Countdown & Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFor;
        private Button btnWhileLoop;
        private Label label1;
        private TextBox txtMaxNum;
        private ListBox lbCountdown;
        private Button btnOpenForm;
    }
}

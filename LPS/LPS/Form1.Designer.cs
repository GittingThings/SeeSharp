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
            this.btnFor = new Button();
            this.btnWhileLoop = new Button();
            this.label1 = new Label();
            this.txtMaxNum = new TextBox();
            this.lbCountdown = new ListBox();
            this.SuspendLayout();

            // 
            // btnFor
            // 
            this.btnFor.Location = new Point(277, 120);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new Size(121, 23);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "For Loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new EventHandler(this.btnFor_Click);

            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new Point(404, 120);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new Size(108, 23);
            this.btnWhileLoop.TabIndex = 1;
            this.btnWhileLoop.Text = "While Loop";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new EventHandler(this.btnWhileLoop_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(338, 64);
            this.label1.Name = "label1";
            this.label1.Size = new Size(115, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type in max number";

            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new Point(320, 91);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new Size(146, 23);
            this.txtMaxNum.TabIndex = 3;

            // 
            // lbCountdown
            // 
            this.lbCountdown.FormattingEnabled = true;
            this.lbCountdown.ItemHeight = 15;
            this.lbCountdown.Location = new Point(277, 149);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new Size(235, 274);
            this.lbCountdown.TabIndex = 4;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.txtMaxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.btnFor);
            this.Name = "Form1";
            this.Text = "Number Countdown & Sales";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnFor;
        private Button btnWhileLoop;
        private Label label1;
        private TextBox txtMaxNum;
        private ListBox lbCountdown;
    }
}

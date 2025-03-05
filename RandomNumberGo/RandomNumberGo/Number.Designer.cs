namespace RandomNumberGo
{
    partial class Number
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
            button = new Button();
            label1 = new Label();
            label2 = new Label();
            Output = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(298, 221);
            button.Name = "button";
            button.Size = new Size(175, 23);
            button.TabIndex = 0;
            button.Text = "Press For Random Number!!!!!";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 81);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "RandomNumberGo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 109);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 2;
            label2.Text = "Game where you guess a number";
            // 
            // Output
            // 
            Output.Location = new Point(292, 148);
            Output.Name = "Output";
            Output.Size = new Size(189, 23);
            Output.TabIndex = 3;
            Output.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 184);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter Number!";
            // 
            // Number
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Output);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button);
            Name = "Number";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label label1;
        private Label label2;
        private TextBox Output;
        private Label label3;
    }
}

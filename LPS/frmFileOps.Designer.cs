namespace LPS
{
    partial class frmFileOps
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
            btnCloseForm = new Button();
            txtInputOps = new TextBox();
            lblInputOps = new Label();
            btnSave = new Button();
            btnRead = new Button();
            lblFileContents = new Label();
            btnSeeForm = new Button();
            SuspendLayout();
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(713, 12);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(75, 23);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "Close Form";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // txtInputOps
            // 
            txtInputOps.Location = new Point(284, 125);
            txtInputOps.Name = "txtInputOps";
            txtInputOps.Size = new Size(221, 23);
            txtInputOps.TabIndex = 1;
            // 
            // lblInputOps
            // 
            lblInputOps.AutoSize = true;
            lblInputOps.Location = new Point(240, 128);
            lblInputOps.Name = "lblInputOps";
            lblInputOps.Size = new Size(38, 15);
            lblInputOps.TabIndex = 2;
            lblInputOps.Text = "Input:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(303, 154);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(406, 154);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 4;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblFileContents
            // 
            lblFileContents.AutoSize = true;
            lblFileContents.Location = new Point(303, 195);
            lblFileContents.Name = "lblFileContents";
            lblFileContents.Size = new Size(0, 15);
            lblFileContents.TabIndex = 5;
            // 
            // btnSeeForm
            // 
            btnSeeForm.Location = new Point(12, 12);
            btnSeeForm.Name = "btnSeeForm";
            btnSeeForm.Size = new Size(75, 23);
            btnSeeForm.TabIndex = 6;
            btnSeeForm.Text = "button1";
            btnSeeForm.UseVisualStyleBackColor = true;
            btnSeeForm.Click += btnSeeForm_Click;
            // 
            // frmFileOps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeForm);
            Controls.Add(lblFileContents);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(lblInputOps);
            Controls.Add(txtInputOps);
            Controls.Add(btnCloseForm);
            Name = "frmFileOps";
            Text = "frmFileOps";
            Load += frmFileOps_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCloseForm;
        private TextBox txtInputOps;
        private Label lblInputOps;
        private Button btnSave;
        private Button btnRead;
        private Label lblFileContents;
        private Button btnSeeForm;
    }
}
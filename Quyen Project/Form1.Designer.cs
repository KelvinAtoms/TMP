namespace Quyen_Project
{
    partial class frmBaiTap1
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblYourName = new Label();
            lblYear = new Label();
            txtYourName = new TextBox();
            txtYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(210, 212);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 0;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(434, 212);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 0;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(655, 212);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblYourName
            // 
            lblYourName.AutoSize = true;
            lblYourName.Location = new Point(91, 39);
            lblYourName.Name = "lblYourName";
            lblYourName.Size = new Size(129, 27);
            lblYourName.TabIndex = 1;
            lblYourName.Text = "Your Name:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(91, 126);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(143, 27);
            lblYear.TabIndex = 1;
            lblYear.Text = "Year of Birth:";
            // 
            // txtYourName
            // 
            txtYourName.Location = new Point(235, 32);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(504, 34);
            txtYourName.TabIndex = 2;
            txtYourName.Leave += txtYourName_Leave;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(235, 119);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(504, 34);
            txtYear.TabIndex = 2;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // frmBaiTap1
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(960, 258);
            Controls.Add(txtYear);
            Controls.Add(txtYourName);
            Controls.Add(lblYear);
            Controls.Add(lblYourName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Font = new Font("Tahoma", 11F);
            Margin = new Padding(4);
            Name = "frmBaiTap1";
            Text = "2Steps Project";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label lblYear;
        private Label lblYourName;
        private Button btnExit;
        private Button btnClear;
        private Button btnShow;
        private TextBox txtYear;
        private TextBox txtYourName;
    }
}

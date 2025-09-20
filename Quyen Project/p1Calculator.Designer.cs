namespace Quyen_Project
{
    partial class p1Calculator
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
            lblCalculatorName = new Label();
            lblAInput = new Label();
            lblBInput = new Label();
            lblUocsochunglonnhat = new Label();
            lblBoisochungnhonhat = new Label();
            txtBInput = new TextBox();
            txtUocsochunglonnhat = new TextBox();
            txtBoisochungnhonhat = new TextBox();
            txtAInput = new TextBox();
            btnDo = new Button();
            btnContinue = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblCalculatorName
            // 
            lblCalculatorName.AutoSize = true;
            lblCalculatorName.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCalculatorName.ForeColor = Color.Red;
            lblCalculatorName.Location = new Point(264, 43);
            lblCalculatorName.Name = "lblCalculatorName";
            lblCalculatorName.Size = new Size(299, 25);
            lblCalculatorName.TabIndex = 0;
            lblCalculatorName.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // lblAInput
            // 
            lblAInput.AutoSize = true;
            lblAInput.Location = new Point(81, 96);
            lblAInput.Name = "lblAInput";
            lblAInput.Size = new Size(97, 25);
            lblAInput.TabIndex = 1;
            lblAInput.Text = "Nhập số a:";
            // 
            // lblBInput
            // 
            lblBInput.AutoSize = true;
            lblBInput.Location = new Point(81, 127);
            lblBInput.Name = "lblBInput";
            lblBInput.Size = new Size(99, 25);
            lblBInput.TabIndex = 1;
            lblBInput.Text = "Nhập số b:";
            // 
            // lblUocsochunglonnhat
            // 
            lblUocsochunglonnhat.AutoSize = true;
            lblUocsochunglonnhat.Location = new Point(81, 155);
            lblUocsochunglonnhat.Name = "lblUocsochunglonnhat";
            lblUocsochunglonnhat.Size = new Size(201, 25);
            lblUocsochunglonnhat.TabIndex = 1;
            lblUocsochunglonnhat.Text = "Ước số chung lớn nhất: ";
            // 
            // lblBoisochungnhonhat
            // 
            lblBoisochungnhonhat.AutoSize = true;
            lblBoisochungnhonhat.Location = new Point(81, 183);
            lblBoisochungnhonhat.Name = "lblBoisochungnhonhat";
            lblBoisochungnhonhat.Size = new Size(200, 25);
            lblBoisochungnhonhat.TabIndex = 1;
            lblBoisochungnhonhat.Text = "Bội số chung nhỏ nhất: ";
            // 
            // txtBInput
            // 
            txtBInput.Location = new Point(316, 121);
            txtBInput.Name = "txtBInput";
            txtBInput.Size = new Size(150, 31);
            txtBInput.TabIndex = 2;
            // 
            // txtUocsochunglonnhat
            // 
            txtUocsochunglonnhat.Location = new Point(316, 152);
            txtUocsochunglonnhat.Name = "txtUocsochunglonnhat";
            txtUocsochunglonnhat.Size = new Size(150, 31);
            txtUocsochunglonnhat.TabIndex = 2;
            // 
            // txtBoisochungnhonhat
            // 
            txtBoisochungnhonhat.Location = new Point(316, 183);
            txtBoisochungnhonhat.Name = "txtBoisochungnhonhat";
            txtBoisochungnhonhat.Size = new Size(150, 31);
            txtBoisochungnhonhat.TabIndex = 2;
            // 
            // txtAInput
            // 
            txtAInput.Location = new Point(316, 93);
            txtAInput.Name = "txtAInput";
            txtAInput.Size = new Size(150, 31);
            txtAInput.TabIndex = 2;
            // 
            // btnDo
            // 
            btnDo.Location = new Point(107, 269);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(112, 34);
            btnDo.TabIndex = 3;
            btnDo.Text = "Do";
            btnDo.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(343, 269);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(112, 34);
            btnContinue.TabIndex = 3;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(577, 269);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // p1Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 355);
            Controls.Add(btnExit);
            Controls.Add(btnContinue);
            Controls.Add(btnDo);
            Controls.Add(txtBoisochungnhonhat);
            Controls.Add(txtUocsochunglonnhat);
            Controls.Add(txtAInput);
            Controls.Add(txtBInput);
            Controls.Add(lblBoisochungnhonhat);
            Controls.Add(lblUocsochunglonnhat);
            Controls.Add(lblBInput);
            Controls.Add(lblAInput);
            Controls.Add(lblCalculatorName);
            Name = "p1Calculator";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalculatorName;
        private Label lblAInput;
        private Label lblBInput;
        private Label lblUocsochunglonnhat;
        private Label lblBoisochungnhonhat;
        private TextBox txtBInput;
        private TextBox txtUocsochunglonnhat;
        private TextBox txtBoisochungnhonhat;
        private TextBox txtAInput;
        private Button btnDo;
        private Button btnContinue;
        private Button btnExit;
    }
}
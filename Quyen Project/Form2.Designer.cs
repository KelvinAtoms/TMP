namespace Quyen_Project
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
            lblDangkytaikhoan = new Label();
            lblTen = new Label();
            lblEmail = new Label();
            lblMatkhau = new Label();
            txtTen = new TextBox();
            lblXacnhanmatkhau = new Label();
            txtEmail = new TextBox();
            txtMatkhau = new TextBox();
            txtXacnhanmatkhau = new TextBox();
            btnDangky = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblEnter = new Label();
            txtEnter = new TextBox();
            SuspendLayout();
            // 
            // lblDangkytaikhoan
            // 
            lblDangkytaikhoan.AutoSize = true;
            lblDangkytaikhoan.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDangkytaikhoan.ForeColor = Color.Blue;
            lblDangkytaikhoan.Location = new Point(336, 21);
            lblDangkytaikhoan.Name = "lblDangkytaikhoan";
            lblDangkytaikhoan.Size = new Size(185, 25);
            lblDangkytaikhoan.TabIndex = 0;
            lblDangkytaikhoan.Text = "Đăng ký tài khoản";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(44, 66);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(129, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên đăng nhập";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(112, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Địa chỉ email";
            // 
            // lblMatkhau
            // 
            lblMatkhau.AutoSize = true;
            lblMatkhau.Location = new Point(44, 139);
            lblMatkhau.Name = "lblMatkhau";
            lblMatkhau.Size = new Size(86, 25);
            lblMatkhau.TabIndex = 1;
            lblMatkhau.Text = "Mật khẩu";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(226, 66);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(390, 31);
            txtTen.TabIndex = 2;
            // 
            // lblXacnhanmatkhau
            // 
            lblXacnhanmatkhau.AutoSize = true;
            lblXacnhanmatkhau.Location = new Point(44, 173);
            lblXacnhanmatkhau.Name = "lblXacnhanmatkhau";
            lblXacnhanmatkhau.Size = new Size(163, 25);
            lblXacnhanmatkhau.TabIndex = 1;
            lblXacnhanmatkhau.Text = "Xác nhận mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 31);
            txtEmail.TabIndex = 2;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(226, 141);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(390, 31);
            txtMatkhau.TabIndex = 2;
            // 
            // txtXacnhanmatkhau
            // 
            txtXacnhanmatkhau.Location = new Point(226, 178);
            txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            txtXacnhanmatkhau.Size = new Size(390, 31);
            txtXacnhanmatkhau.TabIndex = 2;
            // 
            // btnDangky
            // 
            btnDangky.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            btnDangky.ForeColor = Color.Blue;
            btnDangky.Location = new Point(336, 223);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(112, 34);
            btnDangky.TabIndex = 3;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 66);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 104);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 147);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 1;
            label3.Text = "(*)";
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(671, 68);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(52, 25);
            lblEnter.TabIndex = 4;
            lblEnter.Text = "Enter";
            // 
            // txtEnter
            // 
            txtEnter.Location = new Point(729, 66);
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(46, 31);
            txtEnter.TabIndex = 5;
            txtEnter.TextChanged += txtEnter_TextChanged;
            txtEnter.KeyPress += txtEnter_KeyPress;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(txtEnter);
            Controls.Add(lblEnter);
            Controls.Add(btnDangky);
            Controls.Add(txtXacnhanmatkhau);
            Controls.Add(txtMatkhau);
            Controls.Add(txtEmail);
            Controls.Add(txtTen);
            Controls.Add(lblXacnhanmatkhau);
            Controls.Add(lblMatkhau);
            Controls.Add(lblEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTen);
            Controls.Add(lblDangkytaikhoan);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangkytaikhoan;
        private Label lblTen;
        private Label lblEmail;
        private Label lblMatkhau;
        private TextBox txtTen;
        private Label lblXacnhanmatkhau;
        private TextBox txtEmail;
        private TextBox txtMatkhau;
        private TextBox txtXacnhanmatkhau;
        private Button btnDangky;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblEnter;
        private TextBox txtEnter;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Quyen_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s+]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Email khong hop le", "Haha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("(*) khong duoc de trong", "DM");
                return;
            }
            if (txtMatkhau.Text != txtXacnhanmatkhau.Text)
            {
                MessageBox.Show("Mat khau khong khop", "DM");
                return;
            }
            string info = $"Ten dang nhap: {txtTen.Text}"
                + "\nEmail: " + txtEmail.Text + "\nMat khau: " + txtMatkhau.Text;
            MessageBox.Show(info, "Thong tin dang ky");
        }

        private void txtEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLyNhanSu.DAL;
using QLyNhanSu.BLL;
using QLyNhanSu.DTO;
using excel = Microsoft.Office.Interop.Excel;

using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Configuration;
using MongoDB.Driver.Core.Configuration;
namespace QLyNhanSu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.isLogin = false;
            frmMain.Show();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }
        SqlConnection conn = new SqlConnection();
        DataAccess ac = new DataAccess();
        public string LoginUsername = "";

       
        private void button2_Click(object sender, EventArgs e)
        {

            string tenDangNhap = txtUsername.Text;
            LoginUsername = tenDangNhap;
            string matkhau = AccountFunction.CalculateMD5Hash(txtPassword.Text.Trim());

            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();

            }
            

            bool dangNhapThanhCong = ac.kiemtra_dangnhap("TaiKhoan", tenDangNhap, matkhau, "username", "password");

            if (dangNhapThanhCong)
            {
                frmMain.isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu đăng nhập không hợp lệ hoặc tài khoản của bạn đã bị vô hiệu hóa! Vui lòng kiểm tra lại.", "ĐĂNG NHẬP THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }
        private frmMain frmMain = new frmMain();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.isLogin = false;
            frmMain.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
    }
}

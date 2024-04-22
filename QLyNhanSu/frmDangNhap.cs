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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ReadSettings(); // Read Account
            ImageHelper.RoundBorder(pictureBox1); // Round border Logo

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.isLogin = false;
            frmMain.Show();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPass.Checked)
            {
                txtPassword.PasswordChar = false;
            }
            else { txtPassword.PasswordChar = true; }
        }
        SqlConnection conn = new SqlConnection();
        DataAccess ac = new DataAccess();
        public string LoginUsername = "";
        public event EventHandler LoginSuccess;
        private void button2_Click(object sender, EventArgs e)
        {

            string tenDangNhap = txtUsername.Texts;
            LoginUsername = tenDangNhap;
            string matkhau = AccountFunction.CalculateMD5Hash(txtPassword.Texts.Trim());

            SaveSettings();


            bool dangNhapThanhCong = ac.kiemtra_dangnhap("TaiKhoan", tenDangNhap, matkhau, "username", "password");

            if (dangNhapThanhCong)
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
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
        private void ReadSettings()
        {
            if (Properties.Settings.Default.RememberMe == "true")
            {
                txtUsername.Texts = Properties.Settings.Default.Username;
                txtPassword.Texts = Properties.Settings.Default.Password;
                ckbRemember.Checked = true;
            }
            else
            {
                txtUsername.Texts = "";
                txtPassword.Texts = "";
                ckbRemember.Checked = false;
            }
        }
        private void SaveSettings()
        {
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.Username = this.txtUsername.Texts;
                Properties.Settings.Default.Password = this.txtPassword.Texts;
                Properties.Settings.Default.RememberMe = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "false";
                Properties.Settings.Default.Save();
            }
        }
    }
}

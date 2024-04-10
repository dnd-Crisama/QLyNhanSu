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
            string matKhau = txtPassword.Text;
            

            bool dangNhapThanhCong = ac.kiemtra_dangnhap("TaiKhoan", tenDangNhap, matKhau, "username", "password");

            if (dangNhapThanhCong)
            {
                frmMain.isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

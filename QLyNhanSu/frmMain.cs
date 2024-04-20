using System.Windows.Forms;
using static QLyNhanSu.frmDangNhap;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace QLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateDateTime();
        }
        public static bool isLogin = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime currentTime = DateTime.Now;
            lblTime.Text = "Ngày giờ hiện tại: " + currentTime.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void KiemTraDangNhap()
        {
            if (isLogin == false)
            {
                stripChamCong.Enabled = false;
                stripChucNang.Enabled = false;
                stripDanhMuc.Enabled = false;
                stripNhanSu.Enabled = false;
                stripChucNang.Enabled = false;
                stripNguoiDung.Enabled = false;
                stripHeThong.Enabled = false;
                stripDangNhap.Text = "Đăng nhập";
                stripDangNhap.Image = Properties.Resources.image_2024_03_31_102858918_690px;
            }
            else
            {
                stripChamCong.Enabled = true;
                stripChucNang.Enabled = true;
                stripDanhMuc.Enabled = true;
                stripNhanSu.Enabled = true;
                stripChucNang.Enabled = true;
                stripNguoiDung.Enabled = true;
                stripHeThong.Enabled = true;
            }
        }
        private void stripChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChamCong frmChamCong = new frmChamCong();
            frmChamCong.ShowDialog();
            this.Show();
        }

        private void cấuHìnhHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcauhinh frmcauhinh = new frmcauhinh();
            frmcauhinh.ShowDialog();
            this.Show();
        }

        private void stripThoat_Click(object sender, EventArgs e)
        {
            isLogin = false;
            stripDangNhap.Click += stripDangNhap_Click;
            KiemTraDangNhap();
        }

        private void stripHeThong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcauhinh frmcauhinh = new frmcauhinh();
            frmcauhinh.ShowDialog();
            this.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KiemTraDangNhap();

        }

        private void stripDangNhap_Click(object sender, EventArgs e)
        {          
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            if (isLogin)
            {
                KiemTraDangNhap();
                stripDangNhap.Text = "Xin chào " + frmDangNhap.LoginUsername;
                lbltaikhoan.Text = frmDangNhap.LoginUsername;
                stripDangNhap.Image = Properties.Resources.desktop_wallpaper_mcdonalds_yoimiya_in_2021_mcdonalds_cute_anime_thumbnail;
                stripDangNhap.Click -= stripDangNhap_Click;
                this.Show();
            }
            

        }

        private void stripQLHoSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHoSoNhanSu frmQuanLyHoSoNhanSu = new frmQuanLyHoSoNhanSu();
            frmQuanLyHoSoNhanSu.ShowDialog();
            this.Show();

        }

        private void stripQLTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyTaiKhoan frmQuanLyTaiKhoan = new frmQuanLyTaiKhoan();
            frmQuanLyTaiKhoan.ShowDialog();
            this.Show();
        }

        private void stripQLNhanSu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            frmQuanLyNhanVien.ShowDialog();
            this.Show();
        }

        private void stripQLPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanVien frmQuanLyPhongBan = new frmQuanLyNhanVien();
            frmQuanLyPhongBan.ShowDialog();
            this.Show();
        }

        private void stripQLTacVu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDanhMucChucVu frmQuanLyDanhMucChucVu = new frmQuanLyDanhMucChucVu();
            frmQuanLyDanhMucChucVu.ShowDialog();
            this.Show();
        }

        private void stripQLTroCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDanhMucTroCap frmQuanLyDanhMucTroCap = new frmQuanLyDanhMucTroCap();
            frmQuanLyDanhMucTroCap.ShowDialog();
            this.Show();
        }

        private void stripQLSoLuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyHeSoLuong frmQuanLyHeSoLuong = new frmQuanLyHeSoLuong();
            frmQuanLyHeSoLuong.ShowDialog();
            this.Show();
        }
    }
}

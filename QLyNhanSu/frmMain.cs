using System.Windows.Forms;
using static QLyNhanSu.frmDangNhap;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using QLyNhanSu.DAL;

namespace QLyNhanSu
{
    public partial class frmMain : Form
    {
        private Timer timer;
        private Random random;
        
        private string[] quotes = { "Hello World!", "Sometime in life you gotta just 'LEGO'!.", "If two pregnant women fight, it's kind of like two babies having a mecha battle", "Phương Nam phim. Hân hạnh giới thiệu bộ phim. Anh em siêu nhân Deka/ Lực lượng đặc nhiệm S.P.D. S,P.D có nghĩa là đội biệt động đặc nhiệm Deka. Họ thuộc phân khu Trái Đất của cảnh sát vũ trụ. Họ gồm có năm thám tử đầy nhiệt huyết. Nhiệm vụ của họ là triệt hạ những tên tội phạm đến từ vũ trụ để bảo vệ niềm hòa bình cuối cùng của con người trên hành tinh này.", "Cuối cùng mới có một bộ anime mà nhân vật chính đúng chuẩn hình mẫu lý tưởng của tao. Một kẻ lạnh lùng và ít nói. Đám bạn không hiểu tại sao tao trở nên im lặng và luôn được 5 điểm bài kiểm tra. Chúng nó không biết năng lực thực sự của tao và không hề biết tao xuất chúng tới mức nào. Tao chẳng coi chúng là gì ngoài công cụ. Tao ước mình có thể vào trong thế giới anime và bộc lộ con người thực sự của mình. Tao là Ayanokouji Kiyotaka" };
        public frmMain()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            InitializeQuoteLabel();
            InitializeTimer();
            UpdateDateTime();
        }
        public  static bool isLogin = false;
        private int quoteIndex = 0;
        #region Timer 
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime currentTime = DateTime.Now;
            lblTime.Text = "Ngày giờ hiện tại: " + currentTime.ToString("dd/MM/yyyy HH:mm:ss");
        }
        #endregion
        #region RANDOM QUOTES
        private void InitializeQuoteLabel()
        {
            lblQuote.AutoSize = true;
            lblQuote.Text = GetRandomQuote();
            lblQuote.Location = new Point(0, 0);
            panelQuote.AutoSize = false;

            panelQuote.Controls.Add(lblQuote);
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10; // Tốc độ di chuyển của dòng trích dẫn
            timer.Tick += Timer_TickQuote;
            timer.Start();
        }

        private string GetRandomQuote()
        {
            random = new Random();
            int index = random.Next(quotes.Length);
            return quotes[index];
        }
        private void Timer_TickQuote(object sender, EventArgs e)
        {
            if (lblQuote.Right < 0)
            {
                lblQuote.Left = panelQuote.Width;
                int currentQuoteIndex = quoteIndex;
                do
                {
                    quoteIndex = GetRandomQuoteIndex();
                } while (quoteIndex == currentQuoteIndex);
                lblQuote.Text = quotes[quoteIndex];
            }
            else
            {
                lblQuote.Left -= 1;
            }
        }
        private int GetRandomQuoteIndex()
        {
            random = new Random();
            return random.Next(quotes.Length);
        }
        #endregion

        public void KiemTraDangNhap()
        {
            if (isLogin == false)
            {
                stripChamCong.Enabled = false;
                stripChucNang.Enabled = false;
                stripDanhMuc.Enabled = false;
                stripNhanSu.Enabled = false;
                stripChucNang.Enabled = false;
                stripQLTaiKhoan.Enabled = false;
                stripHeThong.Enabled = false;
                stripDangNhap.Text = "Đăng nhập";
                stripDangNhap.Image = null;
            }
            else
            {
                stripChamCong.Enabled = true;
                stripChucNang.Enabled = true;
                stripDanhMuc.Enabled = true;
                stripNhanSu.Enabled = true;
                stripChucNang.Enabled = true;
                stripQLTaiKhoan.Enabled = true;
                stripHeThong.Enabled = true;
            }
        }
        private void stripChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frmChamCong = new frmChamCong();
            openChildForm(frmChamCong);
        }

        private void cấuHìnhHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcauhinh frmcauhinh = new frmcauhinh();
            openChildForm(frmcauhinh);
        }

        private void stripThoat_Click(object sender, EventArgs e)
        {
            isLogin = false;
            stripDangNhap.Click += stripDangNhap_Click;
            KiemTraDangNhap();
            hideSubMenu();
        }

        private void stripHeThong_Click(object sender, EventArgs e)
        {
            frmcauhinh frmcauhinh = new frmcauhinh();
            openChildForm (frmcauhinh);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            customizeDesing();
            KiemTraDangNhap();
            LoadImage();
        }

        private void stripDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.LoginSuccess += FrmDangNhap_LoginSuccess;
            openChildForm(frmDangNhap);
            KiemTraDangNhap();
            if (isLogin)
            {
                KiemTraDangNhap();
                stripDangNhap.Text = " Xin chào " + frmDangNhap.LoginUsername;
                stripDangNhap.Image = ImageHelper.ResizeImage(Properties.Resources.desktop_wallpaper_mcdonalds_yoimiya_in_2021_mcdonalds_cute_anime_thumbnail, 24, 24);
                stripDangNhap.Click -= stripDangNhap_Click;
                this.Show();
            }
            hideSubMenu();
        }
        private void FrmDangNhap_LoginSuccess(object sender, EventArgs e)
        {
            isLogin = true;
            KiemTraDangNhap();
            if (isLogin)
            {
                stripDangNhap.Text = " Xin chào " + ((frmDangNhap)sender).LoginUsername;
                stripDangNhap.Image = ImageHelper.ResizeImage(Properties.Resources.desktop_wallpaper_mcdonalds_yoimiya_in_2021_mcdonalds_cute_anime_thumbnail, 24, 24);
                stripDangNhap.Click -= stripDangNhap_Click;
                this.Show();
            }
        }
        private void stripQLHoSo_Click(object sender, EventArgs e)
        {

            frmQuanLyHoSoNhanSu frmQuanLyHoSoNhanSu = new frmQuanLyHoSoNhanSu();
            openChildForm(frmQuanLyHoSoNhanSu);
            hideSubMenu();

        }

        private void stripQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQuanLyTaiKhoan = new frmQuanLyTaiKhoan();
            openChildForm(frmQuanLyTaiKhoan);
            this.Show();
        }

        private void stripQLNhanSu_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            openChildForm(frmQuanLyNhanVien);
            hideSubMenu();
        }

        private void stripQLPhongBan_Click(object sender, EventArgs e)
        {

            frmQuanLyPhongBan frmQuanLyPhongBan = new frmQuanLyPhongBan();
            openChildForm(frmQuanLyPhongBan);
            hideSubMenu();
        }

        private void stripQLTacVu_Click(object sender, EventArgs e)
        {

            frmQuanLyDanhMucChucVu frmQuanLyDanhMucChucVu = new frmQuanLyDanhMucChucVu();
            openChildForm(frmQuanLyDanhMucChucVu);
            hideSubMenu();
        }

        private void stripQLTroCap_Click(object sender, EventArgs e)
        {

            frmQuanLyDanhMucTroCap frmQuanLyDanhMucTroCap = new frmQuanLyDanhMucTroCap();
            openChildForm(frmQuanLyDanhMucTroCap);
            hideSubMenu();
        }

        private void stripQLSoLuong_Click(object sender, EventArgs e)
        {

            frmQuanLyHeSoLuong frmQuanLyHeSoLuong = new frmQuanLyHeSoLuong();
            openChildForm(frmQuanLyHeSoLuong);
            hideSubMenu();
        }
        // UI REWORK

        private void customizeDesing()
        {
            panelMenuHeThong.Visible = false;
            panelMenuChucNang.Visible = false;
            panelMenuDanhMuc.Visible = false;
            panelMenuNhanSu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMenuHeThong.Visible == true)
                panelMenuHeThong.Visible = false;
            if (panelMenuChucNang.Visible == true)
                panelMenuChucNang.Visible = false;
            if (panelMenuDanhMuc.Visible == true)
                panelMenuDanhMuc.Visible = false;
            if (panelMenuNhanSu.Visible == true)
                panelMenuNhanSu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Submenu
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuHeThong);
        }

        private void button4_Click(object sender, EventArgs e) //QUAN LY LUONG
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e) // TINH LUONG
        {
            frmtinhluong frmtinhluong = new frmtinhluong();
            openChildForm(frmtinhluong);
            hideSubMenu();
        }

        private void stripChucNang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuChucNang);
        }

        private void stripNhanSu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuNhanSu);
        }

        private void stripDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuDanhMuc);
        }
        #endregion
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFormMain_Click(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm != this)
            {
                activeForm.Close();
            }
        }
                private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();          
        }
        private void LoadImage()
        {
            btnHeThong.Image =  ImageHelper.ResizeImage(Properties.Resources._14380713, 24, 24);
            btnThoat.Image = ImageHelper.ResizeImage(Properties.Resources._15181205,24, 24);
            stripChamCong.Image = ImageHelper.ResizeImage(Properties.Resources._9746397, 24, 24);
            stripChucNang.Image = ImageHelper.ResizeImage(Properties.Resources._6826735, 24, 24);
            stripNhanSu.Image = ImageHelper.ResizeImage(Properties.Resources._9954874, 24, 24);
            stripDanhMuc.Image = ImageHelper.ResizeImage(Properties.Resources._3139112, 24, 24);
            stripQLTaiKhoan.Image = ImageHelper.ResizeImage(Properties.Resources._3177440, 24, 24);
            stripHeThong.Image = ImageHelper.ResizeImage(Properties.Resources._3067416, 24, 24);
        }
    }
}

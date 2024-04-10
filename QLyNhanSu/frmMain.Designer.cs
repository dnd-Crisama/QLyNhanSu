namespace QLyNhanSu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            stripTaiKhoan = new ToolStripMenuItem();
            stripDangNhap = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            stripThoat = new ToolStripMenuItem();
            stripChamCong = new ToolStripMenuItem();
            stripChucNang = new ToolStripMenuItem();
            stripQLLuong = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            stripTinhLuong = new ToolStripMenuItem();
            stripNhanSu = new ToolStripMenuItem();
            stripQLNhanSu = new ToolStripMenuItem();
            stripQLHoSo = new ToolStripMenuItem();
            stripDanhMuc = new ToolStripMenuItem();
            stripQLPhongBan = new ToolStripMenuItem();
            stripQLTacVu = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            stripQLTroCap = new ToolStripMenuItem();
            stripQLSoLuong = new ToolStripMenuItem();
            stripNguoiDung = new ToolStripMenuItem();
            stripQLTaiKhoan = new ToolStripMenuItem();
            stripQLQuyen = new ToolStripMenuItem();
            stripTroGiup = new ToolStripMenuItem();
            stripHuongDan = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            stripThongTinPM = new ToolStripMenuItem();
            stripTacGia = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            stripTroGiup1 = new ToolStripMenuItem();
            stripHeThong = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbltaikhoan = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            lblquyen = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblngaygio = new ToolStripStatusLabel();
            toolStripStatusLabel9 = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            lblThongBaoChung = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTime = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripTaiKhoan, stripChamCong, stripChucNang, stripNhanSu, stripDanhMuc, stripNguoiDung, stripTroGiup, stripHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1350, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // stripTaiKhoan
            // 
            stripTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { stripDangNhap, toolStripSeparator1, stripThoat });
            stripTaiKhoan.Image = Properties.Resources._14380713;
            stripTaiKhoan.Name = "stripTaiKhoan";
            stripTaiKhoan.Size = new Size(82, 24);
            stripTaiKhoan.Text = "Tài khản";
            // 
            // stripDangNhap
            // 
            stripDangNhap.Image = Properties.Resources.image_2024_03_31_102858918_690px;
            stripDangNhap.Name = "stripDangNhap";
            stripDangNhap.Size = new Size(132, 22);
            stripDangNhap.Text = "Đăng nhập";
            stripDangNhap.Click += stripDangNhap_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(129, 6);
            // 
            // stripThoat
            // 
            stripThoat.ForeColor = Color.Red;
            stripThoat.Image = Properties.Resources._15181205;
            stripThoat.Name = "stripThoat";
            stripThoat.Size = new Size(132, 22);
            stripThoat.Text = "Thoát";
            stripThoat.Click += stripThoat_Click;
            // 
            // stripChamCong
            // 
            stripChamCong.Image = (Image)resources.GetObject("stripChamCong.Image");
            stripChamCong.Name = "stripChamCong";
            stripChamCong.Size = new Size(101, 24);
            stripChamCong.Text = "Chấm công";
            stripChamCong.Click += stripChamCong_Click;
            // 
            // stripChucNang
            // 
            stripChucNang.DropDownItems.AddRange(new ToolStripItem[] { stripQLLuong, toolStripSeparator4, stripTinhLuong });
            stripChucNang.Image = Properties.Resources._6826735;
            stripChucNang.Name = "stripChucNang";
            stripChucNang.Size = new Size(97, 24);
            stripChucNang.Text = "Chức năng";
            // 
            // stripQLLuong
            // 
            stripQLLuong.Name = "stripQLLuong";
            stripQLLuong.Size = new Size(149, 22);
            stripQLLuong.Text = "Quản lý lương";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(146, 6);
            // 
            // stripTinhLuong
            // 
            stripTinhLuong.Name = "stripTinhLuong";
            stripTinhLuong.Size = new Size(149, 22);
            stripTinhLuong.Text = "Tính lương";
            // 
            // stripNhanSu
            // 
            stripNhanSu.DropDownItems.AddRange(new ToolStripItem[] { stripQLNhanSu, stripQLHoSo });
            stripNhanSu.Image = Properties.Resources._9746397;
            stripNhanSu.Name = "stripNhanSu";
            stripNhanSu.Size = new Size(83, 24);
            stripNhanSu.Text = "Nhân sự";
            // 
            // stripQLNhanSu
            // 
            stripQLNhanSu.Name = "stripQLNhanSu";
            stripQLNhanSu.Size = new Size(192, 22);
            stripQLNhanSu.Text = "Quản lý nhân sự";
            // 
            // stripQLHoSo
            // 
            stripQLHoSo.Name = "stripQLHoSo";
            stripQLHoSo.Size = new Size(192, 22);
            stripQLHoSo.Text = "Quản lý hồ sơ nhân sự";
            // 
            // stripDanhMuc
            // 
            stripDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { stripQLPhongBan, stripQLTacVu, toolStripSeparator5, stripQLTroCap, stripQLSoLuong });
            stripDanhMuc.Image = Properties.Resources._3139112;
            stripDanhMuc.Name = "stripDanhMuc";
            stripDanhMuc.Size = new Size(94, 24);
            stripDanhMuc.Text = "Danh mục";
            // 
            // stripQLPhongBan
            // 
            stripQLPhongBan.Name = "stripQLPhongBan";
            stripQLPhongBan.Size = new Size(180, 22);
            stripQLPhongBan.Text = "Quản lý phòng ban";
            // 
            // stripQLTacVu
            // 
            stripQLTacVu.Name = "stripQLTacVu";
            stripQLTacVu.Size = new Size(180, 22);
            stripQLTacVu.Text = "Quản lý chức vụ";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // stripQLTroCap
            // 
            stripQLTroCap.Name = "stripQLTroCap";
            stripQLTroCap.Size = new Size(180, 22);
            stripQLTroCap.Text = "Quản lý trợ cấp";
            // 
            // stripQLSoLuong
            // 
            stripQLSoLuong.Name = "stripQLSoLuong";
            stripQLSoLuong.Size = new Size(180, 22);
            stripQLSoLuong.Text = "Quản lý số lương";
            // 
            // stripNguoiDung
            // 
            stripNguoiDung.DropDownItems.AddRange(new ToolStripItem[] { stripQLTaiKhoan, stripQLQuyen });
            stripNguoiDung.Image = Properties.Resources._32d33ae6fe6a483a86411652f7a3775a_7318876557544328823;
            stripNguoiDung.Name = "stripNguoiDung";
            stripNguoiDung.Size = new Size(103, 24);
            stripNguoiDung.Text = "Người dùng";
            // 
            // stripQLTaiKhoan
            // 
            stripQLTaiKhoan.Name = "stripQLTaiKhoan";
            stripQLTaiKhoan.Size = new Size(180, 22);
            stripQLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // stripQLQuyen
            // 
            stripQLQuyen.Name = "stripQLQuyen";
            stripQLQuyen.Size = new Size(180, 22);
            stripQLQuyen.Text = "Quản lý quyền";
            // 
            // stripTroGiup
            // 
            stripTroGiup.DropDownItems.AddRange(new ToolStripItem[] { stripHuongDan, toolStripSeparator2, stripThongTinPM, stripTacGia, toolStripSeparator3, stripTroGiup1 });
            stripTroGiup.Image = Properties.Resources._4961759;
            stripTroGiup.Name = "stripTroGiup";
            stripTroGiup.Size = new Size(82, 24);
            stripTroGiup.Text = "Trợ giúp";
            // 
            // stripHuongDan
            // 
            stripHuongDan.Name = "stripHuongDan";
            stripHuongDan.Size = new Size(186, 22);
            stripHuongDan.Text = "Hướng dẫn sử dụng";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // stripThongTinPM
            // 
            stripThongTinPM.Name = "stripThongTinPM";
            stripThongTinPM.Size = new Size(186, 22);
            stripThongTinPM.Text = "Thông tin phần mềm";
            // 
            // stripTacGia
            // 
            stripTacGia.Name = "stripTacGia";
            stripTacGia.Size = new Size(186, 22);
            stripTacGia.Text = "Tác giả";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // stripTroGiup1
            // 
            stripTroGiup1.Name = "stripTroGiup1";
            stripTroGiup1.Size = new Size(186, 22);
            stripTroGiup1.Text = "Trợ giúp";
            // 
            // stripHeThong
            // 
            stripHeThong.Image = Properties.Resources._3067416;
            stripHeThong.Name = "stripHeThong";
            stripHeThong.Size = new Size(89, 24);
            stripHeThong.Text = "Hệ thống";
            stripHeThong.Click += stripHeThong_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbltaikhoan, toolStripStatusLabel2, toolStripStatusLabel6, lblquyen, toolStripStatusLabel4, lblngaygio, toolStripStatusLabel9, toolStripStatusLabel8, lblThongBaoChung, toolStripStatusLabel3, toolStripProgressBar1, toolStripStatusLabel5 });
            statusStrip1.Location = new Point(0, 707);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1350, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(53, 17);
            toolStripStatusLabel1.Text = "Xin chào";
            // 
            // lbltaikhoan
            // 
            lbltaikhoan.ForeColor = Color.Red;
            lbltaikhoan.Name = "lbltaikhoan";
            lbltaikhoan.Size = new Size(52, 17);
            lbltaikhoan.Text = "Acheron";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(10, 17);
            toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(45, 17);
            toolStripStatusLabel6.Text = "Quyền:";
            // 
            // lblquyen
            // 
            lblquyen.ForeColor = Color.BlueViolet;
            lblquyen.Name = "lblquyen";
            lblquyen.Size = new Size(75, 17);
            lblquyen.Text = "Quản trị viên";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(87, 17);
            toolStripStatusLabel4.Text = "Phiên làm việc:";
            // 
            // lblngaygio
            // 
            lblngaygio.ForeColor = Color.RoyalBlue;
            lblngaygio.Name = "lblngaygio";
            lblngaygio.Size = new Size(65, 17);
            lblngaygio.Text = "01/04/2024";
            // 
            // toolStripStatusLabel9
            // 
            toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            toolStripStatusLabel9.Size = new Size(10, 17);
            toolStripStatusLabel9.Text = "|";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(62, 17);
            toolStripStatusLabel8.Text = "Trạng thái:";
            // 
            // lblThongBaoChung
            // 
            lblThongBaoChung.ForeColor = Color.Green;
            lblThongBaoChung.Name = "lblThongBaoChung";
            lblThongBaoChung.Size = new Size(24, 17);
            lblThongBaoChung.Text = "Tốt";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(10, 17);
            toolStripStatusLabel3.Text = "|";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.RightToLeft = RightToLeft.Yes;
            toolStripStatusLabel5.Size = new Size(17, 17);
            toolStripStatusLabel5.Text = "in";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 52);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(431, 2);
            label1.Name = "label1";
            label1.Size = new Size(449, 40);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._355861759_670321011806471_2971325253730285293_n;
            pictureBox1.Location = new Point(0, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1351, 627);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.DarkMagenta;
            lblTime.Location = new Point(1095, 6);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 17);
            lblTime.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 729);
            Controls.Add(lblTime);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân sự";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem stripTaiKhoan;
        public ToolStripMenuItem stripDangNhap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem stripThoat;
        private ToolStripMenuItem stripChamCong;
        private ToolStripMenuItem stripChucNang;
        private ToolStripMenuItem stripQLLuong;
        private ToolStripMenuItem stripTinhLuong;
        private ToolStripMenuItem stripNhanSu;
        private ToolStripMenuItem stripQLNhanSu;
        private ToolStripMenuItem stripQLHoSo;
        private ToolStripMenuItem stripDanhMuc;
        private ToolStripMenuItem stripNguoiDung;
        private ToolStripMenuItem stripQLTaiKhoan;
        private ToolStripMenuItem stripQLQuyen;
        private ToolStripMenuItem stripTroGiup;
        private ToolStripMenuItem stripHuongDan;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem stripThongTinPM;
        private ToolStripMenuItem stripTacGia;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem stripTroGiup1;
        private ToolStripMenuItem stripHeThong;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem stripQLPhongBan;
        private ToolStripMenuItem stripQLTacVu;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem stripQLTroCap;
        private ToolStripMenuItem stripQLSoLuong;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel toolStripStatusLabel8;
        public ToolStripStatusLabel lblThongBaoChung;
        public ToolStripStatusLabel lblngaygio;
        public ToolStripStatusLabel lblquyen;
        public ToolStripStatusLabel lbltaikhoan;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblTime;
    }
}

namespace QLyNhanSu
{
    partial class frmQuanLyNhanVien
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
            toolStrip1 = new ToolStrip();
            btnLoad = new ToolStripButton();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnCancel = new ToolStripButton();
            btnSave = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            btnSearch = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnExport = new ToolStripButton();
            label1 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtCMT = new TextBox();
            txtNgaySinh = new TextBox();
            txtMa = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            cbbPhongBan = new ComboBox();
            cbbTroCap = new ComboBox();
            cbbHeSoLuong = new ComboBox();
            cbbChucVu = new ComboBox();
            cbbHoSo = new ComboBox();
            panel3 = new Panel();
            ptbHinhAnh = new PictureBox();
            label13 = new Label();
            dataGridViewNV = new DataGridView();
            lblEx = new Label();
            lblTenNV = new Label();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNV).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoad, btnAdd, btnEdit, btnCancel, btnSave, toolStripLabel1, txtSearch, btnSearch, btnDelete, btnExport });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLoad
            // 
            btnLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoad.Image = Properties.Resources.Flat_restart_icon_svg;
            btnLoad.ImageTransparentColor = Color.Magenta;
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(24, 24);
            btnLoad.Text = "toolStripButton1";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.toolStripButton2_Image;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(24, 24);
            btnAdd.Text = "toolStripButton2";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources.toolStripButton3_Image;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(24, 24);
            btnEdit.Text = "toolStripButton3";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCancel.Image = Properties.Resources._399274;
            btnCancel.ImageTransparentColor = Color.Magenta;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(24, 24);
            btnCancel.Text = "toolStripButton8";
            btnCancel.Click += btnCanel_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources._489707;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(24, 24);
            btnSave.Text = "toolStripButton5";
            btnSave.Click += btnSave_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(57, 24);
            toolStripLabel1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(88, 27);
            // 
            // btnSearch
            // 
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = Properties.Resources.pngtree_magnifying_glass_icon_image_1128382;
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 24);
            btnSearch.Text = "toolStripButton6";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources._6861362;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(24, 24);
            btnDelete.Text = "toolStripButton7";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExport.Image = Properties.Resources._9913406;
            btnExport.ImageTransparentColor = Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(24, 24);
            btnExport.Text = "toolStripButton4";
            btnExport.Click += btnExcelIX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Thông tin";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtCMT);
            panel1.Controls.Add(txtNgaySinh);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(10, 48);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 212);
            panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 167);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Hoạt động";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "Mã:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 118);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtCMT
            // 
            txtCMT.Location = new Point(115, 64);
            txtCMT.Margin = new Padding(3, 2, 3, 2);
            txtCMT.Name = "txtCMT";
            txtCMT.Size = new Size(199, 23);
            txtCMT.TabIndex = 3;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(115, 89);
            txtNgaySinh.Margin = new Padding(3, 2, 3, 2);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(199, 23);
            txtNgaySinh.TabIndex = 4;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(115, 9);
            txtMa.Margin = new Padding(3, 2, 3, 2);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(94, 23);
            txtMa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(115, 39);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(199, 23);
            txtTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 72);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 6;
            label4.Text = "Chứng minh thư:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 97);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 7;
            label5.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 123);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 44);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 10;
            label8.Text = "Hồ sơ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 72);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 11;
            label9.Text = "Phòng ban:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 97);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 12;
            label10.Text = "Chức vụ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 120);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 13;
            label11.Text = "Hệ số lương:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 150);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 14;
            label12.Text = "Trợ cấp:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbPhongBan);
            panel2.Controls.Add(cbbTroCap);
            panel2.Controls.Add(cbbHeSoLuong);
            panel2.Controls.Add(cbbChucVu);
            panel2.Controls.Add(cbbHoSo);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(368, 49);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 212);
            panel2.TabIndex = 26;
            // 
            // cbbPhongBan
            // 
            cbbPhongBan.FormattingEnabled = true;
            cbbPhongBan.Location = new Point(116, 66);
            cbbPhongBan.Margin = new Padding(3, 2, 3, 2);
            cbbPhongBan.Name = "cbbPhongBan";
            cbbPhongBan.Size = new Size(203, 23);
            cbbPhongBan.TabIndex = 19;
            // 
            // cbbTroCap
            // 
            cbbTroCap.FormattingEnabled = true;
            cbbTroCap.Location = new Point(116, 141);
            cbbTroCap.Margin = new Padding(3, 2, 3, 2);
            cbbTroCap.Name = "cbbTroCap";
            cbbTroCap.Size = new Size(203, 23);
            cbbTroCap.TabIndex = 18;
            // 
            // cbbHeSoLuong
            // 
            cbbHeSoLuong.FormattingEnabled = true;
            cbbHeSoLuong.Location = new Point(116, 114);
            cbbHeSoLuong.Margin = new Padding(3, 2, 3, 2);
            cbbHeSoLuong.Name = "cbbHeSoLuong";
            cbbHeSoLuong.Size = new Size(203, 23);
            cbbHeSoLuong.TabIndex = 17;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(116, 89);
            cbbChucVu.Margin = new Padding(3, 2, 3, 2);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(203, 23);
            cbbChucVu.TabIndex = 16;
            // 
            // cbbHoSo
            // 
            cbbHoSo.FormattingEnabled = true;
            cbbHoSo.Location = new Point(116, 38);
            cbbHoSo.Margin = new Padding(3, 2, 3, 2);
            cbbHoSo.Name = "cbbHoSo";
            cbbHoSo.Size = new Size(203, 23);
            cbbHoSo.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(ptbHinhAnh);
            panel3.Location = new Point(732, 49);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 212);
            panel3.TabIndex = 27;
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Location = new Point(3, 8);
            ptbHinhAnh.Margin = new Padding(3, 2, 3, 2);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(275, 202);
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHinhAnh.TabIndex = 29;
            ptbHinhAnh.TabStop = false;
            ptbHinhAnh.Click += ptbHinhAnh_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(744, 31);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 28;
            label13.Text = "Hồ sơ";
            // 
            // dataGridViewNV
            // 
            dataGridViewNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNV.Location = new Point(0, 276);
            dataGridViewNV.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNV.Name = "dataGridViewNV";
            dataGridViewNV.RowHeadersWidth = 51;
            dataGridViewNV.Size = new Size(1058, 445);
            dataGridViewNV.TabIndex = 29;
            dataGridViewNV.CellClick += dataGridView1_CellClick;
            dataGridViewNV.DataError += DataGridView_DataError;
            // 
            // lblEx
            // 
            lblEx.AutoSize = true;
            lblEx.ForeColor = Color.Green;
            lblEx.Location = new Point(10, 727);
            lblEx.Name = "lblEx";
            lblEx.Size = new Size(59, 15);
            lblEx.TabIndex = 30;
            lblEx.Text = "Trạng thái";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenNV.ForeColor = Color.Black;
            lblTenNV.Location = new Point(802, 24);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(0, 21);
            lblTenNV.TabIndex = 31;
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 748);
            Controls.Add(lblTenNV);
            Controls.Add(lblEx);
            Controls.Add(dataGridViewNV);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyNhanVien";
            Load += frmQuanLyTaiKhoan_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnLoad;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnExport;
        private ToolStripButton btnCancel;
        private ToolStripButton btnSave;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtSearch;
        private ToolStripButton btnSearch;
        private ToolStripButton btnDelete;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtNgaySinh;
        private TextBox txtEmail;
        private TextBox txtCMT;
        private Panel panel2;
        private CheckBox checkBox1;
        private ComboBox cbbPhongBan;
        private ComboBox cbbTroCap;
        private ComboBox cbbHeSoLuong;
        private ComboBox cbbChucVu;
        private ComboBox cbbHoSo;
        private Panel panel3;
        private Label label13;
        private DataGridView dataGridViewNV;
        private Label lblEx;
        public PictureBox ptbHinhAnh;
        private Label lblTenNV;
    }
}
namespace QLyNhanSu
{
    partial class frmcauhinh
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
            toolStripSeparator1 = new ToolStripSeparator();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnCancel = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSave = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            btnSearch = new ToolStripButton();
            btnExcelIX = new ToolStripButton();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            txtMa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtHuongDan = new RichTextBox();
            label3 = new Label();
            txtTacGia = new TextBox();
            label2 = new Label();
            txtGioiThieu = new RichTextBox();
            txtTen = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            lblEx = new ToolStripStatusLabel();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoad, toolStripSeparator1, btnAdd, btnEdit, toolStripSeparator3, btnCancel, toolStripSeparator2, btnDelete, toolStripSeparator4, btnSave, toolStripLabel1, txtSearch, btnSearch, btnExcelIX });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLoad
            // 
            btnLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoad.Image = Properties.Resources._560512;
            btnLoad.ImageTransparentColor = Color.Magenta;
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(23, 22);
            btnLoad.Text = "Load";
            btnLoad.Click += btnLoad_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources._1828819;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(23, 22);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources._1827933;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(23, 22);
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnCancel
            // 
            btnCancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCancel.Image = Properties.Resources._399274;
            btnCancel.ImageTransparentColor = Color.Magenta;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(23, 22);
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCanel_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources._6861362;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(23, 22);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources._489707;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(23, 22);
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(59, 22);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 25);
            // 
            // btnSearch
            // 
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = Properties.Resources._2310707;
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(23, 22);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExcelIX
            // 
            btnExcelIX.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcelIX.Image = Properties.Resources._9913406;
            btnExcelIX.ImageTransparentColor = Color.Magenta;
            btnExcelIX.Name = "btnExcelIX";
            btnExcelIX.Size = new Size(23, 22);
            btnExcelIX.Text = "Xuất file Excel";
            btnExcelIX.Click += btnExcelIX_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(1084, 698);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 25);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1084, 723);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtMa);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtHuongDan);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtTacGia);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtGioiThieu);
            splitContainer1.Panel1.Controls.Add(txtTen);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1084, 698);
            splitContainer1.SplitterDistance = 373;
            splitContainer1.TabIndex = 0;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(215, 31);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(214, 23);
            txtMa.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 31);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 8;
            label5.Text = "Mã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 223);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 7;
            label4.Text = "Hướng dẫn sử dụng";
            // 
            // txtHuongDan
            // 
            txtHuongDan.Location = new Point(215, 220);
            txtHuongDan.Name = "txtHuongDan";
            txtHuongDan.Size = new Size(825, 96);
            txtHuongDan.TabIndex = 6;
            txtHuongDan.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 121);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Giới thiệu";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(215, 89);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(825, 23);
            txtTacGia.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Tác giả";
            // 
            // txtGioiThieu
            // 
            txtGioiThieu.Location = new Point(215, 118);
            txtGioiThieu.Name = "txtGioiThieu";
            txtGioiThieu.Size = new Size(825, 96);
            txtGioiThieu.TabIndex = 2;
            txtGioiThieu.Text = "";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(215, 60);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(825, 23);
            txtTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên chương trình";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEx });
            statusStrip1.Location = new Point(0, 299);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEx
            // 
            lblEx.ForeColor = Color.Blue;
            lblEx.Name = "lblEx";
            lblEx.Size = new Size(61, 17);
            lblEx.Text = "Trạng Thái";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1084, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmcauhinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 748);
            Controls.Add(toolStripContainer1);
            Controls.Add(toolStrip1);
            Name = "frmcauhinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cấu hình hệ thống";
            Load += frmcauhinh_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripButton btnLoad;
        private ToolStripButton btnAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnEdit;
        private ToolStripButton btnCancel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnDelete;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtSearch;
        private ToolStripButton btnSearch;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnExcelIX;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSave;
        private SplitContainer splitContainer1;
        private Label label4;
        private RichTextBox txtHuongDan;
        private Label label3;
        private TextBox txtTacGia;
        private Label label2;
        private RichTextBox txtGioiThieu;
        private TextBox txtTen;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtMa;
        private Label label5;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel lblEx;
    }
}
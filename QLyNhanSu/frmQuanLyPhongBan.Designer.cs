namespace QLyNhanSu
{
    partial class frmQuanLyPhongBan
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
            toolStripButton5 = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKiHieu = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            dataGridViewPB = new DataGridView();
            lblEx = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPB).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoad, btnAdd, btnEdit, btnCancel, btnSave, toolStripLabel1, txtSearch, btnSearch, btnDelete, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 27);
            toolStrip1.TabIndex = 3;
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
            btnCancel.Text = "toolStripButton4";
            btnCancel.Click += btnCanel_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources._489707;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(24, 24);
            btnSave.Text = "toolStripButton8";
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
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources._9913406;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(24, 24);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += btnExcelIX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 102);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 76);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "Mã:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 126);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Kí hiệu:";
            // 
            // txtKiHieu
            // 
            txtKiHieu.Location = new Point(185, 121);
            txtKiHieu.Margin = new Padding(3, 2, 3, 2);
            txtKiHieu.Name = "txtKiHieu";
            txtKiHieu.Size = new Size(292, 23);
            txtKiHieu.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(185, 97);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(292, 23);
            txtTen.TabIndex = 2;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(185, 68);
            txtMa.Margin = new Padding(3, 2, 3, 2);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(292, 23);
            txtMa.TabIndex = 1;
            // 
            // dataGridViewPB
            // 
            dataGridViewPB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPB.Location = new Point(10, 192);
            dataGridViewPB.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPB.Name = "dataGridViewPB";
            dataGridViewPB.RowHeadersWidth = 51;
            dataGridViewPB.Size = new Size(1044, 522);
            dataGridViewPB.TabIndex = 14;
            dataGridViewPB.CellClick += dataGridView1_CellClick;
            // 
            // lblEx
            // 
            lblEx.AutoSize = true;
            lblEx.ForeColor = Color.Green;
            lblEx.Location = new Point(12, 724);
            lblEx.Name = "lblEx";
            lblEx.Size = new Size(59, 15);
            lblEx.TabIndex = 15;
            lblEx.Text = "Trạng thái";
            // 
            // frmQuanLyPhongBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 748);
            Controls.Add(lblEx);
            Controls.Add(dataGridViewPB);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(txtKiHieu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQuanLyPhongBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyPhongBan";
            Load += frmQuanLyPhongBan_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnLoad;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnCancel;
        private ToolStripButton btnSave;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtSearch;
        private ToolStripButton btnSearch;
        private ToolStripButton btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKiHieu;
        private TextBox txtTen;
        private TextBox txtMa;
        private DataGridView dataGridViewPB;
        private ToolStripButton toolStripButton5;
        private Label lblEx;
    }
}
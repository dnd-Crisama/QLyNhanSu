namespace QLyNhanSu
{
    partial class frmQuanLyTaiKhoan
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMa = new TextBox();
            txtRePass = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            checkBox1 = new CheckBox();
            dataGridViewTK = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblEx = new ToolStripStatusLabel();
            cbbQuyen = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTK).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoad, btnAdd, btnEdit, btnCancel, btnSave, toolStripLabel1, txtSearch, btnSearch, btnDelete, btnExport });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1239, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLoad
            // 
            btnLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoad.Image = Properties.Resources._560512;
            btnLoad.ImageTransparentColor = Color.Magenta;
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(29, 24);
            btnLoad.Text = "toolStripButton1";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources._1828819;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "toolStripButton2";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources._1827933;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "toolStripButton3";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCancel.Image = Properties.Resources._399274;
            btnCancel.ImageTransparentColor = Color.Magenta;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(29, 24);
            btnCancel.Text = "toolStripButton4";
            btnCancel.Click += btnCanel_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources._489707;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 24);
            btnSave.Text = "toolStripButton5";
            btnSave.Click += btnSave_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(72, 24);
            toolStripLabel1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            // 
            // btnSearch
            // 
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = Properties.Resources.pngtree_magnifying_glass_icon_image_1128382;
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(29, 24);
            btnSearch.Text = "toolStripButton6";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources._6861362;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(29, 24);
            btnDelete.Text = "toolStripButton7";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExport.Image = Properties.Resources._9913406;
            btnExport.ImageTransparentColor = Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(29, 24);
            btnExport.Text = "toolStripButton8";
            btnExport.Click += btnExcelIX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 107);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 137);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Quyền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 179);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 212);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 248);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 5;
            label5.Text = "Nhắc lại mật khảu:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(209, 100);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(235, 27);
            txtMa.TabIndex = 1;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(209, 241);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(380, 27);
            txtRePass.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(209, 172);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(380, 27);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(209, 204);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(380, 27);
            txtPass.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.ForeColor = Color.Green;
            checkBox1.Location = new Point(209, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Trạng thái";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridViewTK
            // 
            dataGridViewTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTK.Location = new Point(0, 369);
            dataGridViewTK.Name = "dataGridViewTK";
            dataGridViewTK.RowHeadersWidth = 51;
            dataGridViewTK.Size = new Size(1225, 568);
            dataGridViewTK.TabIndex = 12;
            dataGridViewTK.CellContentClick += dataGridView1_CellClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEx });
            statusStrip1.Location = new Point(0, 971);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1239, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEx
            // 
            lblEx.ForeColor = Color.CornflowerBlue;
            lblEx.Name = "lblEx";
            lblEx.Size = new Size(75, 20);
            lblEx.Text = "Trạng thái";
            // 
            // cbbQuyen
            // 
            cbbQuyen.FormattingEnabled = true;
            cbbQuyen.Location = new Point(209, 137);
            cbbQuyen.Margin = new Padding(3, 4, 3, 4);
            cbbQuyen.Name = "cbbQuyen";
            cbbQuyen.Size = new Size(247, 28);
            cbbQuyen.TabIndex = 2;
            // 
            // frmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 997);
            Controls.Add(cbbQuyen);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewTK);
            Controls.Add(checkBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtRePass);
            Controls.Add(txtMa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "frmQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            Load += frmQuanLyTaiKhoan_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTK).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripButton btnExport;
        private ToolStripButton btnSearch;
        private ToolStripButton btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMa;
        private TextBox txtRePass;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox checkBox1;
        private DataGridView dataGridViewTK;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEx;
        private ComboBox cbbQuyen;
    }
   

}

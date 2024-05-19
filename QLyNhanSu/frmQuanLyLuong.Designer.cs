namespace QLyNhanSu
{
    partial class frmQuanLyLuong
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
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txttimkiem = new ToolStripTextBox();
            toolStripButton6 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            txtngaychot = new TextBox();
            txtngayphat = new TextBox();
            txtmanv = new TextBox();
            txtmabangluong = new TextBox();
            txtnoidung = new TextBox();
            txttennv = new TextBox();
            label6 = new Label();
            txttienluong = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            txtchucvu = new TextBox();
            label2 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton5, toolStripLabel1, txttimkiem, toolStripButton6, toolStripButton2, toolStripButton10 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 27);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Flat_restart_icon_svg;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Tải lại";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.toolStripButton3_Image;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "Chỉnh sửa";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Enabled = false;
            toolStripButton5.Image = Properties.Resources.toolStripButton5_Image;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "Lưu";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(72, 24);
            toolStripLabel1.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(100, 27);
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.pngtree_magnifying_glass_icon_image_1128382;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "Tìm kiếm";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources._399274;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Xóa";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = Properties.Resources._9913406;
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(29, 24);
            toolStripButton10.Text = "Export excel";
            toolStripButton10.Click += toolStripButton10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1076, 559);
            dataGridView1.TabIndex = 29;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(527, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 30;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtngaychot
            // 
            txtngaychot.Enabled = false;
            txtngaychot.Location = new Point(527, 56);
            txtngaychot.Name = "txtngaychot";
            txtngaychot.Size = new Size(193, 27);
            txtngaychot.TabIndex = 31;
            // 
            // txtngayphat
            // 
            txtngayphat.Enabled = false;
            txtngayphat.Location = new Point(527, 89);
            txtngayphat.Name = "txtngayphat";
            txtngayphat.Size = new Size(193, 27);
            txtngayphat.TabIndex = 34;
            // 
            // txtmanv
            // 
            txtmanv.Enabled = false;
            txtmanv.Location = new Point(148, 89);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(227, 27);
            txtmanv.TabIndex = 32;
            // 
            // txtmabangluong
            // 
            txtmabangluong.Enabled = false;
            txtmabangluong.Location = new Point(148, 56);
            txtmabangluong.Name = "txtmabangluong";
            txtmabangluong.Size = new Size(227, 27);
            txtmabangluong.TabIndex = 33;
            // 
            // txtnoidung
            // 
            txtnoidung.Enabled = false;
            txtnoidung.Location = new Point(752, 89);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(305, 60);
            txtnoidung.TabIndex = 36;
            // 
            // txttennv
            // 
            txttennv.Enabled = false;
            txttennv.Location = new Point(148, 122);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(227, 27);
            txttennv.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 59);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 44;
            label6.Text = "Nội dung";
            // 
            // txttienluong
            // 
            txttienluong.Enabled = false;
            txttienluong.Location = new Point(527, 122);
            txttienluong.Name = "txttienluong";
            txttienluong.Size = new Size(193, 27);
            txttienluong.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 393);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 92);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 42;
            label5.Text = "Ngày phát lương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 125);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 45;
            label4.Text = "Tiền lương";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 59);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 38;
            label8.Text = "Ngày chốt lương";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 92);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 39;
            label9.Text = "Mã nhân viên";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 125);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 43;
            label10.Text = "Tên nhân viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 59);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 40;
            label11.Text = "Mã bảng lương";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 158);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 43;
            label1.Text = "Chức vụ";
            // 
            // txtchucvu
            // 
            txtchucvu.Enabled = false;
            txtchucvu.Location = new Point(148, 155);
            txtchucvu.Name = "txtchucvu";
            txtchucvu.Size = new Size(227, 27);
            txtchucvu.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 158);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 45;
            label2.Text = "Đã phát lương";
            // 
            // frmQuanLyLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 787);
            Controls.Add(checkBox1);
            Controls.Add(txtngaychot);
            Controls.Add(txtngayphat);
            Controls.Add(txtmanv);
            Controls.Add(txtmabangluong);
            Controls.Add(txtnoidung);
            Controls.Add(txtchucvu);
            Controls.Add(txttennv);
            Controls.Add(label6);
            Controls.Add(txttienluong);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyLuong";
            Text = "Form1";
            Load += frmQuanLyLuong_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txttimkiem;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton10;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private TextBox txtngaychot;
        private TextBox txtngayphat;
        private TextBox txtmanv;
        private TextBox txtmabangluong;
        private TextBox txtnoidung;
        private TextBox txttennv;
        private Label label6;
        private TextBox txttienluong;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label1;
        private TextBox txtchucvu;
        private Label label2;
        private ToolStripButton toolStripButton2;
    }
}
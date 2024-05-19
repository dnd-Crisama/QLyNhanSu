namespace QLyNhanSu
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button4 = new Button();
            ckbShowPass = new CheckBox();
            ckbRemember = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new DAL.RJTextBox();
            txtPassword = new DAL.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ddddddddddd;
            pictureBox1.Image = Properties.Resources._6624c82abd9aa;
            pictureBox1.Location = new Point(192, 83);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1055, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(45, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = Properties.Resources.ddddddddddd;
            pictureBox3.Image = Properties.Resources._10542551;
            pictureBox3.Location = new Point(290, 398);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LightBlue;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(290, 597);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 59);
            button2.TabIndex = 3;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(650, 597);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 59);
            button4.TabIndex = 4;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ckbShowPass
            // 
            ckbShowPass.Anchor = AnchorStyles.None;
            ckbShowPass.AutoSize = true;
            ckbShowPass.BackgroundImage = Properties.Resources.ddddddddddd;
            ckbShowPass.ForeColor = Color.SteelBlue;
            ckbShowPass.Location = new Point(666, 496);
            ckbShowPass.Margin = new Padding(3, 4, 3, 4);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(139, 24);
            ckbShowPass.TabIndex = 11;
            ckbShowPass.Text = "Show Password?";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // ckbRemember
            // 
            ckbRemember.Anchor = AnchorStyles.None;
            ckbRemember.AutoSize = true;
            ckbRemember.BackgroundImage = Properties.Resources.ddddddddddd;
            ckbRemember.ForeColor = Color.SteelBlue;
            ckbRemember.Location = new Point(290, 496);
            ckbRemember.Margin = new Padding(3, 4, 3, 4);
            ckbRemember.Name = "ckbRemember";
            ckbRemember.Size = new Size(129, 24);
            ckbRemember.TabIndex = 12;
            ckbRemember.Text = "Remember me";
            ckbRemember.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.ddddddddddd;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1100, 787);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.ddddddddddd;
            pictureBox2.Image = Properties.Resources._3177440;
            pictureBox2.Location = new Point(290, 300);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.DarkSlateBlue;
            txtUsername.BorderColor = Color.DarkBlue;
            txtUsername.BorderFocusColor = Color.DarkViolet;
            txtUsername.BorderRadius = 15;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(366, 313);
            txtUsername.Margin = new Padding(5);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(11, 9, 11, 9);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "   USERNAME";
            txtUsername.Size = new Size(430, 39);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.DarkSlateBlue;
            txtPassword.BorderColor = Color.DarkBlue;
            txtPassword.BorderFocusColor = Color.DarkViolet;
            txtPassword.BorderRadius = 15;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(366, 416);
            txtPassword.Margin = new Padding(5);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(11, 9, 11, 9);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "   PASSWORD";
            txtPassword.Size = new Size(430, 39);
            txtPassword.TabIndex = 2;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 787);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(ckbShowPass);
            Controls.Add(ckbRemember);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(600, 250);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.Manual;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button4;
        private CheckBox ckbShowPass;
        private CheckBox ckbRemember;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private DAL.RJTextBox txtUsername;
        private DAL.RJTextBox txtPassword;
    }
}
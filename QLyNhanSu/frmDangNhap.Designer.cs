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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            panel3 = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button4 = new Button();
            ckbShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 530);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(208, 354);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 5;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(66, 291);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 4;
            label2.Text = "Employee Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 229);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 3;
            label1.Text = "Welcome to the";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hoyoverse_icon_logo_22;
            pictureBox1.Location = new Point(56, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(306, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(694, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 30);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(321, 129);
            label4.Name = "label4";
            label4.Size = new Size(258, 30);
            label4.TabIndex = 5;
            label4.Text = "Đăng nhập vào hệ thống";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(299, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 70);
            panel3.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " USERNAME";
            txtUsername.Size = new Size(301, 23);
            txtUsername.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3177440;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(299, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(435, 70);
            panel4.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 23);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " PASSWORD";
            txtPassword.Size = new Size(301, 23);
            txtPassword.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._10542551;
            pictureBox3.Location = new Point(12, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(340, 405);
            button2.Name = "button2";
            button2.Size = new Size(107, 50);
            button2.TabIndex = 8;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(582, 405);
            button4.Name = "button4";
            button4.Size = new Size(107, 50);
            button4.TabIndex = 10;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.ForeColor = Color.SteelBlue;
            ckbShowPass.Location = new Point(582, 367);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(113, 19);
            ckbShowPass.TabIndex = 11;
            ckbShowPass.Text = "Show Password?";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 530);
            Controls.Add(ckbShowPass);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label4;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button4;
        private CheckBox ckbShowPass;
        public TextBox txtUsername;
    }
}
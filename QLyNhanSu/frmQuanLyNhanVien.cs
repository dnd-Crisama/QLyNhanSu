﻿using QLyNhanSu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyNhanSu
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

        }
        void LayDLNV()
        {
            String query = "SELECT * FROM dbo.NhanVien";
            dataGridViewNV.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        void HienThiDLNV()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.NhanVien  WHERE NhanVien.id = " + A;
            dataGridViewNV.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLNV();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HienThiDLNV();
        }
    }
}

﻿using QLyNhanSu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyNhanSu
{
    public partial class frmQuanLyDanhMucTroCap : Form
    {
        public frmQuanLyDanhMucTroCap()
        {
            InitializeComponent();

        }
        void LayDLTC()
        {
            String query = "SELECT * FROM dbo.HoSoNhanVien";
            Dataprovider provider = new Dataprovider();
            dataGridViewTC.DataSource = provider.ExecuteQuery(query);
        }
        void HienThiDLTC()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.PhongBan  WHERE PhongBan.id = " + A;
            Dataprovider provider = new Dataprovider();
            dataGridViewTC.DataSource = provider.ExecuteQuery(query);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLTC();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           HienThiDLTC();
        }
    }
}

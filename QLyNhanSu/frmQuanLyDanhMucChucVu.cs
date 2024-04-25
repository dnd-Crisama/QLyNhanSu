using QLyNhanSu.BLL;
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
    public partial class frmQuanLyDanhMucChucVu : Form
    {
        public frmQuanLyDanhMucChucVu()
        {
            InitializeComponent();

        }
        void LayDLCV()
        {
            String query = "SELECT * FROM dbo.HoSoNhanVien";
            Dataprovider provider = new Dataprovider();
            dataGridViewCV.DataSource = provider.ExecuteQuery(query);
        }
        void HienThiDLCV()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.PhongBan  WHERE PhongBan.id = " + A;
            Dataprovider provider = new Dataprovider();
            dataGridViewCV.DataSource = provider.ExecuteQuery(query);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLCV();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
             HienThiDLCV();
        }
    }
}

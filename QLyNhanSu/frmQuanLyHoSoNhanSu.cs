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
using System.Data.SqlClient;
namespace QLyNhanSu
{
    public partial class frmQuanLyHoSoNhanSu : Form
    {
        public frmQuanLyHoSoNhanSu()
        {
            InitializeComponent();

        }
        void LayDLHSNS()
        {
            String query = "SELECT * FROM dbo.HoSoNhanVien";
            dataGridViewHSNS.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        void HienThiDLHSNS()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.HoSoNhanVien  WHERE HoSoNhanVien.id = " + A;
            dataGridViewHSNS.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLHSNS();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HienThiDLHSNS();
        }
    }
}

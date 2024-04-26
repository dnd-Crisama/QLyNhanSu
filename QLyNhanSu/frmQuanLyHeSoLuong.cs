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
    public partial class frmQuanLyHeSoLuong : Form
    {
        public frmQuanLyHeSoLuong()
        {
            InitializeComponent();

        }
        void LayDLHSL()
        {
            String query = "SELECT * FROM dbo.HeSoLuong";
            dataGridViewHSL.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        void HienThiDLHSL()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.HeSoLuong  WHERE HeSoLuong.id = " + A;
            dataGridViewHSL.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLHSL();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HienThiDLHSL();
        }
    }
}

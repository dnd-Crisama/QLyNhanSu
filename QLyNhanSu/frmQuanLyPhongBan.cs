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
    public partial class frmQuanLyPhongBan : Form
    {
        public frmQuanLyPhongBan()
        {
            InitializeComponent();

        }
        void LayDLPB()
        {
            String query = "SELECT * FROM dbo.PhongBan";
            Dataprovider provider = new Dataprovider();
            dataGridViewPB.DataSource = provider.ExecuteQuery(query);
        }
        void HienThiDLPB ()
        {
            String A = toolStripTextBox1.Text;
            String query = "SELECT * FROM dbo.PhongBan  WHERE PhongBan.id = "+ A;
            Dataprovider provider = new Dataprovider();
            dataGridViewPB.DataSource = provider.ExecuteQuery(query);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLPB();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            HienThiDLPB();
        }
    }
}

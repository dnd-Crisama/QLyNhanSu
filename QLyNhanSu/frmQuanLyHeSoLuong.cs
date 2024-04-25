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
            String query = "SELECT * FROM dbo.HoSoNhanVien";
            Dataprovider provider = new Dataprovider();
            dataGridViewHSL.DataSource = provider.ExecuteQuery(query);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLHSL();
        }
    }
}

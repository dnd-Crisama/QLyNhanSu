namespace QLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void stripChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frmChamCong = new frmChamCong();
            frmChamCong.ShowDialog();
        }
    }
}

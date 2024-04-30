using Microsoft.Office.Interop.Excel;
using QLyNhanSu.BLL;
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLyNhanSu
{
    public partial class frmQuanLyDanhMucTroCap : Form
    {
        public frmQuanLyDanhMucTroCap()
        {
            InitializeComponent();

        }

        public string _stus = "0";
        private static int mahientai;
        DataAccess ac = new DataAccess();

        trocapbll xuly = new trocapbll();
        trocapdto doituong = new trocapdto();
        void LayDLHSL()
        {
            String query = "SELECT * FROM dbo.TroCap";
            dataGridViewTC.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        public void load_data()
        {
            var dt = xuly.hien();
            dataGridViewTC.DataSource = dt;
            mahientai = dataGridViewTC.RowCount - 1;
            txtma.Text = mahientai.ToString();
        }
        public void xoa_text()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtgiatri.Text = "";
            txtten.Focus();
        }
        public void them()
        {
            try
            {
                load_doituong();
                xuly.them(doituong);
                load_data();
                xoa_text();
                lblEx.Text = "Thêm thành công dữ liệu.";
                mahientai++;
                txtma.Text = mahientai.ToString();
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
                txtten.Focus();
            }
        }
        public void sua()
        {
            try
            {
                if (int.Parse(txtma.Text) < 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo!", MessageBoxButtons.OK);
                    lblEx.Text = "Chưa chọn dữ liệu.";
                }
                else
                {
                    load_doituong();
                    xuly.sua(doituong);
                    load_data();
                    xoa_text();
                    lblEx.Text = "Cập nhật dữ liệu thành công!";
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
                txtten.Focus();
            }
        }

        public void xoa()
        {
            try
            {
                if (int.Parse(txtma.Text) < 0)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo!", MessageBoxButtons.OK);
                    lblEx.Text = "Chưa chọn dữ liệu.";
                }
                else
                {
                    load_doituong();
                    xuly.xoa(doituong);
                    load_data();
                    xoa_text();
                    lblEx.Text = "Xóa dữ liệu thành công!";
                    if (mahientai > 0)
                    {
                        mahientai--;
                    }
                    txtma.Text = mahientai.ToString();
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
                txtten.Focus();
            }
        }
        public void luu()
        {
            if (_stus == "1")
            {
                them();
            }
            else
            {
                sua();
            }
            trangthai_btn(true);
            trangthai_txt(true);
            load_data();
        }
        public void trangthai_txt(bool _trangthai)
        {
            txtma.ReadOnly = _trangthai;
            txtten.ReadOnly = _trangthai;
            txtgiatri.ReadOnly = _trangthai;
        }
        public void trangthai_btn(bool _trangthai)
        {
            toolStripButton2.Enabled = _trangthai;
            toolStripButton3.Enabled = _trangthai;
            toolStripButton7.Enabled = _trangthai;
            toolStripButton5.Enabled = !_trangthai;
            toolStripButton8.Enabled = !_trangthai;
        }
        public void timkiem()
        {
            var dt = xuly.timkiem(txttimkiem.Text);
            dataGridViewTC.DataSource = dt;
        }
        QLyNhanSu.DAL.Excel exec = new QLyNhanSu.DAL.Excel();
        public void export_excel()
        {
            var dt = xuly.hien();
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                var chuoi = f.FileName;
                lblEx.Text = chuoi;
                lblEx.Text = exec.Exports(dt, lblEx.Text);
            }
            else
            {
                lblEx.Text = "Không thực hiện được!";
            }
        }
        public void xuat_excel()
        {
            var dt = xuly.hien();
            try
            {
                if ((dt == null) || (dt.Columns.Count == 0))
                    lblEx.Text = "không có dữ liệu";
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel file (*.xls)|*xls";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = (Worksheet)excelApp.ActiveSheet;
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i + 1] = dt.Columns[i].ColumnName;

                    }
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        for (var j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = dt.Rows[i][j];
                        }
                    }
                    int socot = dt.Columns.Count;
                    int sohang = dt.Rows.Count;

                    worksheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                    Excel.Range caption = worksheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                    caption.Select();
                    caption.FormulaR1C1 = "DỮ LIỆU";
                    caption.Font.FontStyle = "Bold";

                    caption.HorizontalAlignment = Excel.Constants.xlCenter;
                    caption.Font.Bold = true;
                    caption.VerticalAlignment = Excel.Constants.xlCenter;
                    caption.Font.Size = 15;

                    caption.Interior.ColorIndex = 33;
                    caption.RowHeight = 30;

                    Excel.Range header = worksheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                    header.Select();

                    header.HorizontalAlignment = Excel.Constants.xlCenter;
                    header.Font.Bold = true;
                    header.Font.Size = 13;
                    header.HorizontalAlignment = Excel.Constants.xlCenter;
                    for (int i = 0; i < sohang; i++)
                    {
                        ((Excel.Range)worksheet.Cells[1, i + 1]).EntireColumn.AutoFit();
                    }
                    //save file
                    worksheet.SaveAs(f.FileName);
                    excelApp.Quit();
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = "Không thực hiện được!" + ex.Message;
            }
        }
        public void load_excel(string path)
        {
            dataGridViewTC.DataSource = exec.Import(path);
        }
        public void load_doituong()
        {
            doituong.id = int.Parse(txtma.Text);
            doituong.ten = txtten.Text;
            doituong.giatri = float.Parse(txtgiatri.Text);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTC.Rows[e.RowIndex];
                txtma.Text = row.Cells[0].Value.ToString();
                txtten.Text = row.Cells[1].Value.ToString();
                txtgiatri.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                txtma.Text = "0";
                txtten.Text = "";
                txtgiatri.Text = "";
            }
        }
        public bool check_data(string _value)
        {
            return ac.check_tontai("NhanVien", "cmt", _value);
        }
        private void frmQuanLyDanhMucTroCap_Load(object sender, EventArgs e)
        {
            load_data();
            trangthai_btn(true);
            trangthai_txt(true);

            dataGridViewTC.Columns["id"].DisplayIndex = 0;
            dataGridViewTC.Columns["ten"].DisplayIndex = 1;
            dataGridViewTC.Columns["giatri"].DisplayIndex = 2;

            dataGridViewTC.Columns[0].HeaderText = "ID";
            dataGridViewTC.Columns[1].HeaderText = "Tên";
            dataGridViewTC.Columns[2].HeaderText = "Giá trị";

            dataGridViewTC.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            load_data();
            txtma.Clear();
            txtten.Clear();
            txtgiatri.Clear();
            txtma.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            trangthai_btn(false);
            trangthai_txt(false);
            _stus = "1";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            trangthai_btn(false);
            trangthai_txt(false);
            _stus = "0";
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            txtgiatri.Clear();
            trangthai_btn(true);
            trangthai_txt(true);
            _stus = "0";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            luu();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu? Dữ liệu sẽ bị mất và không thể khôi phục.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                xoa();
            }
            else if (dialogResult == DialogResult.No)
            {
                txtten.Focus();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            export_excel();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayDLHSL();
        }
    }
}

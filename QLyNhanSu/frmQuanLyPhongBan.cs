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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using System.Drawing;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;

using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

namespace QLyNhanSu
{
    public partial class frmQuanLyPhongBan : Form
    {
        public frmQuanLyPhongBan()
        {
            InitializeComponent();
        }
        public string _stus = "0";
        private static int mahientai;
        DataAccess ac = new DataAccess();

        phongbanbll xuly = new phongbanbll();
        phongbandto doituong = new phongbandto();

        public void load_data()
        {
            var dt = xuly.hien();
            dataGridViewPB.DataSource = dt;
            mahientai = dataGridViewPB.RowCount - 1;
            txtMa.Text = mahientai.ToString();
        }
        public void timkiem()
        {
            var dt = xuly.timkiem(txtSearch.Text);
            dataGridViewPB.DataSource = dt;
        }
        public void xoa_text()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtKiHieu.Text = "";
            txtTen.Focus();
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
                txtMa.Text = mahientai.ToString();
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
                txtTen.Focus();
            }
        }
        public void sua()
        {
            try
            {
                if (int.Parse(txtMa.Text) < 0)
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
                txtTen.Focus();
            }
        }
        public void xoa()
        {
            try
            {
                if (int.Parse(txtMa.Text) < 0)
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
                    txtMa.Text = mahientai.ToString();
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
                txtTen.Focus();
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
            txtMa.ReadOnly = _trangthai;
            txtTen.ReadOnly = _trangthai;
            txtKiHieu.ReadOnly = _trangthai;
        }
        public void trangthai_btn(bool _trangthai)
        {
            btnAdd.Enabled = _trangthai;
            btnEdit.Enabled = _trangthai;
            btnDelete.Enabled = _trangthai;
            btnSave.Enabled = !_trangthai;
            btnCancel.Enabled = !_trangthai;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu? Dữ liệu sẽ bị mất và không thể khôi phục.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                xoa();
            }
            else if (dialogResult == DialogResult.No)
            {
                txtTen.Focus();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            trangthai_btn(false);
            trangthai_txt(false);
            _stus = "1";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            trangthai_btn(false);
            trangthai_txt(false);
            _stus = "0";
        }
        private void btnCanel_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtKiHieu.Clear();
            trangthai_btn(true);
            trangthai_txt(true);
            _stus = "0";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                luu();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_data();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void btnExcelIX_Click(object sender, EventArgs e)
        {
            export_excel();
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
            dataGridViewPB.DataSource = exec.Import(path);
        }
        public void load_doituong()
        {
            doituong.id = int.Parse(txtMa.Text);
            doituong.ten = txtTen.Text;
            doituong.kihieu = txtKiHieu.Text;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewPB.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtKiHieu.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                txtMa.Text = "0";
                txtTen.Text = "";
                txtKiHieu.Text = "";
            }
        }
        public bool check_data(string _value)
        {
            return ac.check_tontai("NhanVien", "cmt", _value);
        }
        // load + format show
        private void frmQuanLyPhongBan_Load(object sender, EventArgs e)
        {
            load_data();
            trangthai_btn(true);
            trangthai_txt(true);

            dataGridViewPB.Columns["id"].DisplayIndex = 0;
            dataGridViewPB.Columns["ten"].DisplayIndex = 1;
            dataGridViewPB.Columns["kihieu"].DisplayIndex = 2;

            dataGridViewPB.Columns[0].HeaderText = "ID";
            dataGridViewPB.Columns[1].HeaderText = "Tên phòng ban";
            dataGridViewPB.Columns[2].HeaderText = "Kí hiệu phòng ban";

            dataGridViewPB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPB.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

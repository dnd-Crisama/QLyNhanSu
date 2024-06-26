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
using System.Data.SqlClient;
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLyNhanSu
{
    public partial class frmQuanLyHoSoNhanSu : Form
    {
        public frmQuanLyHoSoNhanSu()
        {
            InitializeComponent();

        }
        public string _stus = "0";
        private static int mahientai;
        DataAccess ac = new DataAccess();

        hosonhanvienbll xuly = new hosonhanvienbll();
        hosonhanviendto doituong = new hosonhanviendto();

        
        public void load_data()
        {
            var dt = xuly.hien();
            dataGridViewHSNS.DataSource = dt;
            mahientai = dataGridViewHSNS.RowCount - 1;
            txtma.Text = mahientai.ToString();
        }
        public void timkiem()
        {
            var dt = xuly.timkiem(txttimkiem.Text);
            dataGridViewHSNS.DataSource = dt;
        }
        public void xoa_text()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtkihieu.Text = "";
            txtngaytao.Text = "";
            txtngaycapnhap.Text = "";
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
                txtma.Focus();
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
            txtkihieu.ReadOnly = _trangthai;
            txtngaytao.ReadOnly = _trangthai;
            txtngaycapnhap.ReadOnly = _trangthai;
        }
        public void trangthai_btn(bool _trangthai)
        {
            toolStripButton2.Enabled = _trangthai;
            toolStripButton3.Enabled = _trangthai;
            toolStripButton7.Enabled = _trangthai;
            toolStripButton5.Enabled = !_trangthai;
            toolStripButton8.Enabled = !_trangthai;
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
            dataGridViewHSNS.DataSource = exec.Import(path);
        }
        public void load_doituong()
        {
            doituong.id = int.Parse(txtma.Text);
            doituong.kihieu = int.Parse(txtkihieu.Text);
            doituong.noidung = txtten.Text;
            doituong.ngaytao = txtngaytao.Text;
            doituong.ngaycapphat = txtngaycapnhap.Text;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewHSNS.Rows[e.RowIndex];
                txtma.Text = row.Cells[0].Value.ToString();
                txtten.Text = row.Cells[2].Value.ToString();
                txtkihieu.Text = row.Cells[1].Value.ToString();
                txtngaytao.Text = row.Cells[3].Value.ToString();
                txtngaycapnhap.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                txtma.Text = "0";
                txtten.Text = "";
                txtkihieu.Text = "";
                txtngaytao.Text = "";
                txtngaycapnhap.Text = "";
            }
        }
        public bool check_data(string _value)
        {
            return ac.check_tontai("NhanVien", "cmt", _value);
        }
        private void frmQuanLyHoSoNhanSu_Load(object sender, EventArgs e)
        {
            load_data();
            trangthai_btn(true);
            trangthai_txt(true);

            /*dataGridViewHSNS.Columns["id"].DisplayIndex = 0;
            dataGridViewHSNS.Columns["noidung"].DisplayIndex = 2;
            dataGridViewHSNS.Columns["kihieu"].DisplayIndex = 1;
            dataGridViewHSNS.Columns["ngaytao"].DisplayIndex = 3;
            dataGridViewHSNS.Columns["ngaycapnhap"].DisplayIndex = 4;*/


            dataGridViewHSNS.Columns[0].HeaderText = "ID";
            dataGridViewHSNS.Columns[1].HeaderText = "Kí Hiệu";
            dataGridViewHSNS.Columns[2].HeaderText = "Nội Dung";
            dataGridViewHSNS.Columns[3].HeaderText = "Ngày Tạo";
            dataGridViewHSNS.Columns[4].HeaderText = "Ngày Cập Nhập";


            dataGridViewHSNS.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHSNS.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewHSNS.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewHSNS.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewHSNS.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            load_data();
            txtma.Clear();
            txtten.Clear();
            txtkihieu.Clear();
            txtngaytao.Clear();
            txtngaycapnhap.Clear();
            txtma.Focus();
            trangthai_txt(false);
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
            trangthai_txt(false); ;
            _stus = "0";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            txtkihieu.Clear();
            txtngaytao.Clear();
            txtngaycapnhap.Clear();
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            load_data();
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

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            export_excel();
        }

        private void GetDateCreate_Click(object sender, EventArgs e)
        {
            txtngaytao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void GetDateUpdate_Click(object sender, EventArgs e)
        {
            txtngaycapnhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

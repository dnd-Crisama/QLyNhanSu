using QLyNhanSu.BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace QLyNhanSu
{
    public partial class frmQuanLyLuong : Form
    {
        bangluongbll bangluong = new bangluongbll();
        bangluongdto bl = new bangluongdto();
        public frmQuanLyLuong()
        {
            InitializeComponent();
        }
        private void getdata()
        {
            bl.id = txtmabangluong.Text.ToString();
            bl.idnhanvien = int.Parse(txtmanv.Text);
            bangluong.bl = bl;
        }
        private void exportexcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void frmQuanLyLuong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bangluong.gettinhluong();
            toolStripButton5.Enabled = false;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Mã"].Value.ToString().Trim() == "")
                {
                    txtmabangluong.Text = "";
                    txtmanv.Text = "";
                    txtmabangluong.Text = "";
                    txtngaychot.Text = "";
                    txtngayphat.Text = "";
                    txttienluong.Text = "";
                    txtnoidung.Text = "";
                    txtchucvu.Text = "";
                    checkBox1.Checked = false;
                    toolStripButton5.Enabled = false;
                }
                else
                {
                    toolStripButton5.Enabled = false;
                    txtmabangluong.Text = row.Cells["Mã"].Value.ToString();
                    txtmanv.Text = row.Cells["Mã nhân viên"].Value.ToString();
                    txttennv.Text = row.Cells["Tên nhân viên"].Value.ToString();
                    txtngaychot.Text = ((DateTime)row.Cells["Ngày chốt"].Value).ToString("MM/dd/yyyy");
                    if (row.Cells["Ngày trả lương"].Value.ToString() != "")
                    {
                        txtngayphat.Text = ((DateTime)row.Cells["Ngày trả lương"].Value).ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtngayphat.Text = "";
                    }
                    txttienluong.Text = row.Cells["Tổng"].Value.ToString();
                    txtnoidung.Text = row.Cells["Nội dung"].Value.ToString();
                    if (row.Cells["Trạng thái"].Value.ToString() == "1")
                    {
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                    }
                    getdata();
                    txtchucvu.Text = bangluong.getchucvu();
                }
            }
            catch { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton5.Enabled = true;
            txtnoidung.Enabled = true;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bangluong.luunoidung(txtnoidung.Text);
            dataGridView1.DataSource = bangluong.gettinhluong();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = int.Parse(txttimkiem.Text);
                dataGridView1.DataSource = bangluong.tim_idnhanvien2(idnv);
            }
            catch
            {
                DataTable tb = bangluong.tim_tennhanvien2(txttimkiem.Text);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tb;
                }
                else
                {
                    dataGridView1.DataSource = bangluong.tim_chucvu(txttimkiem.Text);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bangluong.Xoabangluong(txtmabangluong.Text);
            dataGridView1.DataSource = bangluong.gettinhluong();

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*xlsx)|*xlsx|Excel 2019 (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exportexcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công\n" + ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtmabangluong.Text = "";
            txtmanv.Text = "";
            txtmabangluong.Text = "";
            txtngaychot.Text = "";
            txtngayphat.Text = "";
            txttienluong.Text = "";
            txtnoidung.Text = "";
            txtchucvu.Text = "";
            checkBox1.Checked = false;
            toolStripButton5.Enabled = false;
            dataGridView1.DataSource = bangluong.gettinhluong();
        }
    }
}

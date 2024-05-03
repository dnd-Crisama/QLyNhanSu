using QLyNhanSu.BLL;
using QLyNhanSu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLyNhanSu
{
    public partial class frmtinhluong : Form
    {
        ketnoiCSDL data = new ketnoiCSDL();
        tinhluongbll tinhluong = new tinhluongbll();
        public frmtinhluong()
        {
            InitializeComponent();
        }
        private void dataGridView2_load()
        {
            dataGridView2.DataSource = data.gettinhluong();
        }
        private void frmtinhluong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.getdsnhanvien();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView2.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
            dataGridView2_load();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView1.SelectedCells;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["Mã"].Value.ToString().Trim() == "")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            else
            {
                textBox1.Text = row.Cells["Mã"].Value.ToString();
                textBox2.Text = row.Cells["Tên nhân viên"].Value.ToString();
                textBox3.Text = row.Cells["CMT"].Value.ToString();
                textBox4.Text = row.Cells["Ngày sinh"].Value.ToString();
                textBox5.Text = row.Cells["Điện thoại"].Value.ToString();
                textBox6.Text = row.Cells["Phòng ban"].Value.ToString();
                textBox7.Text = row.Cells["Chức vụ"].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView2.SelectedCells;
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            if (row.Cells["Mã"].Value.ToString().Trim() == "")
            {
                label16.Text = label14.Text;
                label18.Text = label13.Text;
                label19.Text = label12.Text;
                label27.Text = label15.Text;
                label28.Text = label11.Text;
                label29.Text = label10.Text;
                label30.Text = label9.Text;
            }
            else
            {
                label16.Text = row.Cells["Tên nhân viên"].Value.ToString();
                label18.Text = row.Cells["Ngày công"].Value.ToString();
                label19.Text = row.Cells["Tổng"].Value.ToString();
                label27.Text = row.Cells["Tháng"].Value.ToString();
                label28.Text = row.Cells["Năm"].Value.ToString();
                label29.Text = ((DateTime)row.Cells["Ngày chốt"].Value).ToString("MM/dd/yyyy");
                label30.Text = ((DateTime)row.Cells["Ngày trả lương"].Value).ToString("MM/dd/yyyy");
                label31.Text = row.Cells["Mã"].Value.ToString();
            }

        }
        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int manhanvien = int.Parse(textBox1.Text);
            textBox10.Text = tinhluong.thuongchuyencan(manhanvien).ToString("F0");
            textBox9.Text = tinhluong.trocap(manhanvien).ToString("F0");
            tinhluong.them_tinhluong_ngaycong(manhanvien);
            dataGridView2_load();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int manhanvien = int.Parse(textBox1.Text);
            textBox12.Text = tinhluong.tinhbhyt(manhanvien, textBox9.Text).ToString("F0");
            textBox13.Text = tinhluong.tinhbhtnld(manhanvien, textBox9.Text).ToString("F0");
            textBox14.Text = tinhluong.tinhbhxh(manhanvien, textBox9.Text).ToString("F0");
            string tongluong = tinhluong.tongluong(manhanvien, double.Parse(textBox12.Text), double.Parse(textBox13.Text), double.Parse(textBox14.Text), double.Parse(textBox15.Text), textBox9.Text, double.Parse(textBox11.Text)).ToString("F0");
            tinhluong.them_tinhluong_chotluong(manhanvien, tongluong);
            dataGridView2_load();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tinhluong.them_tinhluong_traluong(label31.Text, textBox8.Text);
            dataGridView2_load();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

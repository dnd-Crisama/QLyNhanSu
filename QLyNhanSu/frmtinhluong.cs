using QLyNhanSu.BLL;
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
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
        tinhluongbll tinhluong = new tinhluongbll();
        nhanviendto nv = new nhanviendto();
        tinhluongdto tl = new tinhluongdto();
        public frmtinhluong()
        {
            InitializeComponent();
        }
        private void dataGridView2_load()
        {
            dataGridView2.DataSource = tinhluong.gettinhluong();
        }
        private void getdatanv()
        {
            if (textBox1.Text.ToString().Length != 0)
            {
                nv.id = int.Parse(textBox1.Text);
            }
            nv.ten = textBox2.Text;
            tinhluong.nv = nv;
        }
        private void getdatatl()
        {
            tl.id = label31.Text;
            tinhluong.tl = tl;
        }
        private void frmtinhluong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tinhluong.getdsnhanvien();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dataGridView2.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
            dataGridView2_load();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
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
            catch { }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            try
            {
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
                    checkBox1.Checked = false;
                    button3.Visible = false;
                }
                else
                {
                    label16.Text = row.Cells["Tên nhân viên"].Value.ToString();
                    label18.Text = row.Cells["Ngày công"].Value.ToString();
                    label19.Text = row.Cells["Tổng"].Value.ToString();
                    label27.Text = row.Cells["Tháng"].Value.ToString();
                    label28.Text = row.Cells["Năm"].Value.ToString();
                    if (row.Cells["Ngày chốt"].Value.ToString().Trim() != "")
                    {
                        label29.Text = ((DateTime)row.Cells["Ngày chốt"].Value).ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        label29.Text = "";
                    }
                    if (row.Cells["Ngày trả lương"].Value.ToString().Trim() != "")
                    {
                        label30.Text = ((DateTime)row.Cells["Ngày trả lương"].Value).ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        label30.Text = "";
                    }
                    label31.Text = row.Cells["Mã"].Value.ToString();
                    if (row.Cells["Trạng thái"].Value.ToString() == "1")
                    {
                        checkBox1.Checked=true;
                        button3.Visible =true;
                    }
                }
            }
            catch { }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            getdatanv();
            textBox10.Text = tinhluong.thuongchuyencan().ToString("F0");
            textBox9.Text = tinhluong.trocap().ToString("F0");
            tinhluong.them_tinhluong_ngaycong();
            dataGridView2_load();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getdatanv();
            textBox12.Text = tinhluong.tinhbhyt().ToString("F0");
            textBox13.Text = tinhluong.tinhbhtnld().ToString("F0");
            textBox14.Text = tinhluong.tinhbhxh().ToString("F0");
            string tongluong = tinhluong.tongluong(double.Parse(textBox12.Text), double.Parse(textBox13.Text), double.Parse(textBox14.Text), double.Parse(textBox15.Text), double.Parse(textBox11.Text)).ToString();
            tinhluong.them_tinhluong_chotluong(tongluong);
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
            getdatatl();
            tinhluong.them_tinhluong_traluong(textBox8.Text);
            label30.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            dataGridView2_load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getdatanv();
            dataGridView1.DataSource = tinhluong.tim_idnhanvien1();
            dataGridView2.DataSource = tinhluong.tim_idnhanvien2();
            if (dataGridView1.Rows.Count > 1)
            {
                textBox1.Text = dataGridView1.Rows[0].Cells["Mã"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[0].Cells["Tên nhân viên"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells["CMT"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[0].Cells["Ngày sinh"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[0].Cells["Điện thoại"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells["Phòng ban"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[0].Cells["Chức vụ"].Value.ToString();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            if (dataGridView2.Rows.Count > 1)
            {
                label16.Text = dataGridView2.Rows[0].Cells["Tên nhân viên"].Value.ToString();
                label18.Text = dataGridView2.Rows[0].Cells["Ngày công"].Value.ToString();
                label19.Text = dataGridView2.Rows[0].Cells["Tổng"].Value.ToString();
                label27.Text = dataGridView2.Rows[0].Cells["Tháng"].Value.ToString();
                label28.Text = dataGridView2.Rows[0].Cells["Năm"].Value.ToString();
                if (dataGridView2.Rows[0].Cells["Ngày chốt"].Value.ToString().Trim() != "")
                {
                    label29.Text = ((DateTime)dataGridView2.Rows[0].Cells["Ngày chốt"].Value).ToString("MM/dd/yyyy");
                }
                else
                {
                    label29.Text = "";
                }
                if (dataGridView2.Rows[0].Cells["Ngày trả lương"].Value.ToString().Trim() != "")
                {
                    label30.Text = ((DateTime)dataGridView2.Rows[0].Cells["Ngày trả lương"].Value).ToString("MM/dd/yyyy");
                }
                else
                {
                    label30.Text = "";
                }
                label31.Text = dataGridView2.Rows[0].Cells["Mã"].Value.ToString();
            }
            else
            {
                label16.Text = label14.Text;
                label18.Text = label13.Text;
                label19.Text = label12.Text;
                label27.Text = label15.Text;
                label28.Text = label11.Text;
                label29.Text = label10.Text;
                label30.Text = label9.Text;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            getdatanv();
            dataGridView1.DataSource = tinhluong.tim_tennhanvien1();
            dataGridView2.DataSource = tinhluong.tim_tennhanvien2();
            if (dataGridView1.Rows.Count > 1)
            {
                textBox1.Text = dataGridView1.Rows[0].Cells["Mã"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[0].Cells["Tên nhân viên"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells["CMT"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[0].Cells["Ngày sinh"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[0].Cells["Điện thoại"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[0].Cells["Phòng ban"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[0].Cells["Chức vụ"].Value.ToString();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            if (dataGridView2.Rows.Count > 1)
            {
                label16.Text = dataGridView2.Rows[0].Cells["Tên nhân viên"].Value.ToString();
                label18.Text = dataGridView2.Rows[0].Cells["Ngày công"].Value.ToString();
                label19.Text = dataGridView2.Rows[0].Cells["Tổng"].Value.ToString();
                label27.Text = dataGridView2.Rows[0].Cells["Tháng"].Value.ToString();
                label28.Text = dataGridView2.Rows[0].Cells["Năm"].Value.ToString();
                if (dataGridView2.Rows[0].Cells["Ngày chốt"].Value.ToString().Trim() != "")
                {
                    label29.Text = ((DateTime)dataGridView2.Rows[0].Cells["Ngày chốt"].Value).ToString("MM/dd/yyyy");
                }
                else
                {
                    label29.Text = "";
                }
                if (dataGridView2.Rows[0].Cells["Ngày trả lương"].Value.ToString().Trim() != "")
                {
                    label30.Text = ((DateTime)dataGridView2.Rows[0].Cells["Ngày trả lương"].Value).ToString("MM/dd/yyyy");
                }
                else
                {
                    label30.Text = "";
                }
                label31.Text = dataGridView2.Rows[0].Cells["Mã"].Value.ToString();
            }
            else
            {
                label16.Text = label14.Text;
                label18.Text = label13.Text;
                label19.Text = label12.Text;
                label27.Text = label15.Text;
                label28.Text = label11.Text;
                label29.Text = label10.Text;
                label30.Text = label9.Text;
            }
        }
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

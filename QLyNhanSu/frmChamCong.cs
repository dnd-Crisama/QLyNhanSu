using QLyNhanSu.BLL;
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLyNhanSu
{
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTime();
        }
        public string _stus = "0";

        DataAccess ac = new DataAccess();

        nhanvienbll xuly_nhanvien = new nhanvienbll();

        chamcongbll xuly = new chamcongbll();
        chamcongdto doituong = new chamcongdto();

        public void load_dataNhanVien()
        {
            var dt = xuly_nhanvien.hien();
            dataGridView1.DataSource = dt;
        }
        public void load_dataChamCong()
        {
            var dt = xuly.hien();
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["ten"].DisplayIndex = 2;
            dataGridView2.Columns["tenchucvu"].DisplayIndex = 3;
            dataGridView2.Columns["tenphongban"].DisplayIndex = 4;
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
        public void load_excel(string path)
        {
            dataGridView2.DataSource = exec.Import(path);
        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            load_dataNhanVien();
            load_dataChamCong();

            #region Format Dataview
            // dataNhanvien
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Chứng minh thư";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
            dataGridView1.Columns[5].HeaderText = "Mã Hồ sơ";
            dataGridView1.Columns[7].HeaderText = "Mã Phòng Ban";
            dataGridView1.Columns[8].HeaderText = "Mã Chức vụ";
            dataGridView1.Columns[9].HeaderText = "Mã Hệ số lương";
            dataGridView1.Columns[10].HeaderText = "Mã Trợ cấp";
            dataGridView1.Columns[11].HeaderText = "Kí hiệu";
            dataGridView1.Columns[12].HeaderText = "Ngày cấp phát";
            dataGridView1.Columns[13].HeaderText = "Tên phòng ban";
            dataGridView1.Columns[14].HeaderText = "Tên chức vụ";
            dataGridView1.Columns[15].HeaderText = "Tên Hệ số lương";
            dataGridView1.Columns[16].HeaderText = "Hình ảnh";

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //dataChamCong

            dataGridView2.Columns["ten"].DisplayIndex = 2;
            dataGridView2.Columns["tenchucvu"].DisplayIndex = 3;
            dataGridView2.Columns["tenphongban"].DisplayIndex = 4;

            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "ID Nhân viên";
            dataGridView2.Columns[2].HeaderText = "Giờ";
            dataGridView2.Columns[3].HeaderText = "Ngày";
            dataGridView2.Columns[4].HeaderText = "Tháng";
            dataGridView2.Columns[5].HeaderText = "Năm";
            dataGridView2.Columns[6].HeaderText = "Trạng thái";
            dataGridView2.Columns[7].HeaderText = "Nội dung";
            dataGridView2.Columns[8].HeaderText = "Ghi chú";
            dataGridView2.Columns[9].HeaderText = "Điều kiện";
            dataGridView2.Columns[10].HeaderText = "Chứng minh thư";
            dataGridView2.Columns[11].HeaderText = "Ngày sinh";
            dataGridView2.Columns[12].HeaderText = "Email";
            dataGridView2.Columns[13].HeaderText = "Mã chức vụ";
            dataGridView2.Columns[14].HeaderText = "Tên chức vụ";
            dataGridView2.Columns[15].HeaderText = "Mã phòng ban";
            dataGridView2.Columns[16].HeaderText = "Tên phòng ban";
            dataGridView2.Columns[17].HeaderText = "Tên nhân viên";

            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime currentTime = DateTime.Now;
            txtNgayChamCong.ReadOnly = true;
            txtNgayChamCong.Text = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // catch error Image 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    txtMaNV.Text = row.Cells[0].Value.ToString();
                    txtMa.Text = row.Cells[0].Value.ToString();
                    txtTenNV.Text = row.Cells[1].Value.ToString();
                    txtCMT.Text = row.Cells[2].Value.ToString();
                    txtNgaySinh.Text = row.Cells[3].Value.ToString();
                    txtEmail.Text = row.Cells[4].Value.ToString();
                    txtPhongBan.Text = row.Cells[13].Value.ToString();
                    txtChucVu.Text = row.Cells[14].Value.ToString();
                    txtIDChamCong.Text = "0";
                }
                else
                {
                    txtMaNV.Text = "0";
                    txtTenNV.Text = "";
                    txtCMT.Text = "";
                    txtNgaySinh.Text = "";
                    txtEmail.Text = "";
                    txtPhongBan.Text = "";
                    txtChucVu.Text = "";
                }
            }
            catch { }
        }
        public void xoa_text()
        {
            txtMa.Text = "";
            txtNoiDung.Text = "Chấm công";
            txtGhiChu.Text = "";
            txtDieuKien.Text = "";
        }
        public void them()
        {

            try
            {
                load_doituong();
                xuly.them(doituong);
                load_dataChamCong();
                xoa_text();
                lblEx.Text = "Chấm công thành công."; ;
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
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
                    load_dataChamCong();
                    xoa_text();
                    lblEx.Text = "Cập nhật dữ liệu thành công!";
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = "Lỗi, thử lại " + ex.Message.ToString();
            }
        }
        public void load_doituong()
        {
            string ngayGioString = txtNgayChamCong.Text;

            string dateFormat = "dd/MM/yyyy HH:mm:ss";

            DateTime ngayGio;


            if (DateTime.TryParseExact(ngayGioString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayGio))
            {
                string gio = ngayGio.ToString("HH:mm:ss");
                string ngay = ngayGio.ToString("dd");
                string thang = ngayGio.ToString("MM");
                string nam = ngayGio.ToString("yyyy");

                doituong.id = int.Parse(txtIDChamCong.Text);
                doituong.idnhanvien = int.Parse(txtMaNV.Text);
                doituong.gio = gio;
                doituong.ngay = ngay;
                doituong.thang = thang;
                doituong.nam = nam;
                doituong.noidung = txtNoiDung.Text;
                doituong.ghichu = txtGhiChu.Text;
                doituong.dieukien = txtDieuKien.Text;
                if (ckbTrangThai.Checked)
                {
                    doituong.trangthai = 1;
                }
                else
                {
                    doituong.trangthai = 0;
                }
            }
            else
            {
                MessageBox.Show("Định dạng ngày giờ không hợp lệ!");
            }

        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                int idNhanVien = int.Parse(txtMaNV.Text);

                bool daChamCong = xuly.DaChamCongTrongNgay(idNhanVien);

                if (daChamCong)
                {
                    MessageBox.Show(txtTenNV.Text + " đã chấm công hôm nay rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                }
            }
            catch (Exception ex)
            {
                lblEx.Text = ex.Message;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtIDChamCong.Text != "0")
            {
                sua();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn id để cập nhật", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var dt = xuly_nhanvien.timkiem(txtMaNV.Text);
            var dt2 = xuly.timkiem(txtMaNV.Text);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var dt = xuly_nhanvien.timkiem(txtTenNV.Text);
            var dt2 = xuly.timkiem(txtTenNV.Text);
            dataGridView2.DataSource = dt2;
            dataGridView1.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var dt = xuly_nhanvien.timkiem(txtCMT.Text);
            var dt2 = xuly.timkiem(txtCMT.Text);
            dataGridView2.DataSource = dt2;
            dataGridView1.DataSource= dt;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            load_dataChamCong();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int nam, thang;

            if (!int.TryParse(txtLocNam.Text, out nam))
            {
                nam = 0;
            }

            if (!int.TryParse(txtLocThang.Text, out thang))
            {
                thang = 0;
            }
            var dt = xuly.LocTheoNamThang(nam, thang);
            dataGridView2.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            export_excel();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                    txtIDChamCong.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    txtIDChamCong.Text = "";
                }
            }
            catch { }
        }
    }
}

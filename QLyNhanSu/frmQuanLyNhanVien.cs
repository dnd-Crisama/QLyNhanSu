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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using System.Drawing.Imaging;
using MongoDB.Driver.Core.Configuration;

namespace QLyNhanSu
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

        }
        public string _stus = "0";
        private static int mahientai;

        DataAccess ac = new DataAccess();

        nhanvienbll xuly = new nhanvienbll();
        nhanviendto doituong = new nhanviendto();

        hosonhanvienbll xulyquyen = new hosonhanvienbll();
        hosonhanviendto doituongquyen = new hosonhanviendto();

        phongbanbll xulyPhongBan = new phongbanbll();
        phongbandto doituongPhongBan = new phongbandto();

        chucvubll xulyChucVu = new chucvubll();
        chucvudto doituongChucVu = new chucvudto();

        hesoluongbll xulyHeSoLuong = new hesoluongbll();
        hesoluong doituongHeSoLuong = new hesoluong();

        trocapbll xulyTroCap = new trocapbll();
        trocapdto doituongTroCap = new trocapdto();

        public void load_data()
        {
            var dt = xuly.hien();
            dataGridViewNV.DataSource = dt;
            mahientai = dataGridViewNV.RowCount - 1;
            txtMa.Text = mahientai.ToString();
        }

        public void timkiem()
        {
            var dt = xuly.timkiem(txtSearch.Text);
            dataGridViewNV.DataSource = dt;
        }
        public void xoa_text()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtCMT.Text = "";
            txtEmail.Text = "";
            txtNgaySinh.Text = "";

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
            txtCMT.ReadOnly = _trangthai;
            txtNgaySinh.ReadOnly = _trangthai;
            txtEmail.ReadOnly = _trangthai;

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
            txtTen.Clear();
            txtCMT.Clear();
            txtNgaySinh.Clear();
            txtEmail.Clear();
            cbbChucVu.ResetText();
            cbbHeSoLuong.ResetText();
            cbbHoSo.ResetText();
            cbbPhongBan.ResetText();
            cbbTroCap.ResetText();

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
            dataGridViewNV.DataSource = exec.Import(path);
        }
        public void load_doituong()
        {
            doituong.id = int.Parse(txtMa.Text);
            doituong.ten = txtTen.Text;
            doituong.cmt = txtCMT.Text;
            doituong.ngaysinh = txtNgaySinh.Text;
            doituong.email = txtEmail.Text;
            doituong.hosonhanvien = selectedHoSoID;
            doituong.maphongban = selectedPhongBanID;
            doituong.machucvu = selectedChucVuID;
            doituong.masoheluong = selectedHeSoLuongID;
            doituong.matrocap = selectedTroCapID;
            if (checkBox1.Checked)
            {
                doituong.trangthai = 1;
            }
            else
            {
                doituong.trangthai = 0;
            }
            doituong.hinhanh = ImageToByteArray(ptbHinhAnh);
            

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewNV.Rows[e.RowIndex];

                    txtMa.Text = row.Cells[0].Value.ToString();
                    txtTen.Text = row.Cells[1].Value.ToString();
                    txtCMT.Text = row.Cells[2].Value.ToString();
                    txtNgaySinh.Text = row.Cells[3].Value.ToString();
                    txtEmail.Text = row.Cells[4].Value.ToString();

                    // tron tron vn
                    Random random = new Random();
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Tạo một màu ngẫu nhiên
                    Color randomColor1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    lblTenNV.BackColor = randomColor;
                    lblTenNV.ForeColor = randomColor1;
                    lblTenNV.Text = row.Cells[1].Value.ToString();


                    var selectedValue = dataGridViewNV.Rows[e.RowIndex].Cells["trangthai"].Value;


                    if (selectedValue != null && selectedValue.ToString() == "1")
                    {
                        checkBox1.ForeColor = Color.Green;
                        checkBox1.Text = "Hoạt động";
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.ForeColor = Color.Red;
                        checkBox1.Text = "Không khả dụng";
                        checkBox1.Checked = false;
                    }


                    /* cbbHoSo.Text = row.Cells[5].Value.ToString();
                     cbbPhongBan.Text = row.Cells[8].Value.ToString();
                     cbbChucVu.Text = row.Cells[9].Value.ToString();
                     cbbHeSoLuong.Text = row.Cells[10].Value.ToString();
                     cbbTroCap.Text = row.Cells[11].Value.ToString();*/

                    int maPhongBan = Convert.ToInt32(row.Cells["maphongban"].Value);
                    cbbPhongBan.SelectedValue = maPhongBan;
                    int maHoSo = Convert.ToInt32(row.Cells["hosonhanvien"].Value);
                    cbbHoSo.SelectedValue = maHoSo;
                    int machucvu = Convert.ToInt32(row.Cells["machucvu"].Value);
                    cbbChucVu.SelectedValue = machucvu;
                    int mahesoluong = Convert.ToInt32(row.Cells["mahesoluong"].Value);
                    cbbHeSoLuong.SelectedValue = mahesoluong;
                    int matrocap = Convert.ToInt32(row.Cells["matrocap"].Value);
                    cbbTroCap.SelectedValue = matrocap;

                }
                else
                {
                    txtMa.Text = "0";
                    txtTen.Text = "";
                    txtCMT.Text = "";
                    ptbHinhAnh.Image = null;
                }
            }
            catch { }
            try
            {
                if (dataGridViewNV.Rows[e.RowIndex].Cells["hinhanh"].ToString() != "")
                {
                    MemoryStream stream = new MemoryStream((byte[])dataGridViewNV.Rows[e.RowIndex].Cells["hinhanh"].Value);
                    ptbHinhAnh.Image = Image.FromStream(stream);
                }
                else
                {
                    ptbHinhAnh.Image = null;
                }
            }
            catch
            {
                ptbHinhAnh.Image = null;
            }
        }
        public bool check_data(string _value)
        {
            return ac.check_tontai("NhanVien", "cmt", _value);
        }
        Modify modify = new Modify();
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            load_data();
            trangthai_btn(true);
            trangthai_txt(true);
            LoadComboBox();

            cbbHoSo.SelectedIndexChanged += cbbHoSo_SelectedIndexChanged;
            cbbPhongBan.SelectedIndexChanged += cbbPhongBan_SelectedIndexChanged;
            cbbChucVu.SelectedIndexChanged += cbChucVu_SelectedIndexChanged;
            cbbHeSoLuong.SelectedIndexChanged += cbbHeSoLuong_SelectedIndexChanged;
            cbbTroCap.SelectedIndexChanged += cbbTroCap_SelectedIndexChanged;

            dataGridViewNV.DataSource = xuly.hien();

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dataGridViewNV.Columns[16];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;


            /*dataGridViewNV.Columns["id"].DisplayIndex = 0;
            dataGridViewNV.Columns["username"].DisplayIndex = 1;
            dataGridViewNV.Columns["password"].DisplayIndex = 2;
            dataGridViewNV.Columns["maquyen"].DisplayIndex = 3;
            dataGridViewNV.Columns["ten"].DisplayIndex = 4;
            dataGridViewNV.Columns["giatri"].DisplayIndex = 5;
            dataGridViewNV.Columns["trangthai"].DisplayIndex = 5;
            */

            // format datagridview

            dataGridViewNV.Columns[0].HeaderText = "ID";
            dataGridViewNV.Columns[1].HeaderText = "Tên";
            dataGridViewNV.Columns[2].HeaderText = "Chứng minh thư";
            dataGridViewNV.Columns[3].HeaderText = "Ngày sinh";
            dataGridViewNV.Columns[4].HeaderText = "Email";
            dataGridViewNV.Columns[6].HeaderText = "Trạng thái";
            dataGridViewNV.Columns[5].HeaderText = "Mã Hồ sơ";
            dataGridViewNV.Columns[7].HeaderText = "Mã Phòng Ban";
            dataGridViewNV.Columns[8].HeaderText = "Mã Chức vụ";
            dataGridViewNV.Columns[9].HeaderText = "Mã Hệ số lương";
            dataGridViewNV.Columns[10].HeaderText = "Mã Trợ cấp";
            dataGridViewNV.Columns[11].HeaderText = "Kí hiệu";
            dataGridViewNV.Columns[12].HeaderText = "Ngày cấp phát";
            dataGridViewNV.Columns[13].HeaderText = "Tên phòng ban";
            dataGridViewNV.Columns[14].HeaderText = "Tên chức vụ";
            dataGridViewNV.Columns[15].HeaderText = "Tên Hệ số lương";
            dataGridViewNV.Columns[16].HeaderText = "Hình ảnh";

            dataGridViewNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
            dataGridViewNV.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }

        public void LoadComboBox()
        {
            var dsHoSo = ac.GetDataTable_Text("SELECT * FROM HoSoNhanVien");
            cbbHoSo.ValueMember = "id";
            cbbHoSo.DisplayMember = "kihieu";
            cbbHoSo.DataSource = dsHoSo;

            var dsPhongBan = ac.GetDataTable_Text("SELECT * FROM PhongBan");
            cbbPhongBan.ValueMember = "id";
            cbbPhongBan.DisplayMember = "ten";
            cbbPhongBan.DataSource = dsPhongBan;

            var dsChucVu = ac.GetDataTable_Text("SELECT * FROM ChucVu");
            cbbChucVu.ValueMember = "id";
            cbbChucVu.DisplayMember = "ten";
            cbbChucVu.DataSource = dsChucVu;

            var dsHeSoLuong = ac.GetDataTable_Text("SELECT * FROM HeSoLuong");
            cbbHeSoLuong.ValueMember = "id";
            cbbHeSoLuong.DisplayMember = "ten";
            cbbHeSoLuong.DataSource = dsHeSoLuong;

            var dsTroCap = ac.GetDataTable_Text("SELECT * FROM TroCap");
            cbbTroCap.ValueMember = "id";
            cbbTroCap.DisplayMember = "ten";
            cbbTroCap.DataSource = dsTroCap;
        }
        private int selectedHoSoID;
        private int selectedPhongBanID;
        private int selectedChucVuID;
        private int selectedHeSoLuongID;
        private int selectedTroCapID;

        
        private void cbbHoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbHoSo.SelectedIndex != -1)
            {
                selectedHoSoID = (int)cbbHoSo.SelectedValue;
            }
        }
        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbHoSo.SelectedIndex != -1)
            {
                selectedPhongBanID = (int)cbbPhongBan.SelectedValue;
            }
        }
        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbHoSo.SelectedIndex != -1)
            {
                selectedChucVuID = (int)cbbChucVu.SelectedValue;
            }
        }
        private void cbbHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbHoSo.SelectedIndex != -1)
            {
                selectedHeSoLuongID = (int)cbbHeSoLuong.SelectedValue;
            }
        }
        private void cbbTroCap_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbHoSo.SelectedIndex != -1)
            {
                selectedTroCapID = (int)cbbTroCap.SelectedValue;
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox1.Text = "Hoạt động";
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
                checkBox1.Text = "Không khả dụng";
            }
        }
        

        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg;";
            openFileDialog.Title = "Chọn hình ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {            
                    ptbHinhAnh.ImageLocation = openFileDialog.FileName;
            }
        }
        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
             MemoryStream memoryStream = new MemoryStream();
        
             pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
             return memoryStream.ToArray();
           
        }
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}

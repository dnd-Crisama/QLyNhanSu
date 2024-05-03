using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace QLyNhanSu.DAL
{
    internal class ketnoiCSDL
    {
        string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn;
        public void connect()
        {
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
            }catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối CSDL", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SqlConnection getConnectString()
        {
            return conn;
        }
        public DataTable getdsnhanvien()
        {
            connect();  
            string query = @"select nv.id as 'Mã',nv.ten as 'Tên nhân viên',cmt as 'CMT', ngaysinh as 'Ngày sinh', dienthoai as 'Điện thoại', pb.ten as 'Phòng ban', cv.ten as 'Chức vụ',email as 'Email', hosonhanvien as 'Hồ sơ nhân viên', trangthai as 'Trạng thái', maphongban as 'Mã phòng ban', machucvu as 'Mã chức vụ', mahesoluong as 'Mã hệ số lương', matrocap as 'Mã trợ cấp' 
                             from NhanVien nv,PhongBan pb,ChucVu cv 
                             where nv.maphongban=pb.id and nv.machucvu=cv.id and nv.trangthai=1
                             order by 'Mã' asc;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable gettinhluong()
        {
            connect();
            string query = @"select tl.id as 'Mã', idnhanvien as 'Mã nhân viên', ten as 'Tên nhân viên', cmt as 'CMT', ngaycong as 'Ngày công',tong as 'Tổng', 
                                    thang as 'Tháng', nam as 'Năm', ngaychot as 'Ngày chốt', ngaytraluong as 'Ngày trả lương', tl.trangthai as 'Trạng thái', tl.noidung as 'Nội dung'
                             from TinhLuong tl, NhanVien nv 
                             where nv.id=idnhanvien order by tl.id asc";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }      
    }
}

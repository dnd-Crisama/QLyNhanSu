using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            string query = @"select tl.id as 'Mã', tl.idnhanvien as 'Mã nhân viên', ten as 'Tên nhân viên', cmt as 'CMT', ngaycong as 'Ngày công',tong as 'Tổng', 
                                    tl.thang as 'Tháng', tl.nam as 'Năm', ngaychot as 'Ngày chốt', ngaytraluong as 'Ngày trả lương', bl.trangthai as 'Trạng thái', bl.noidung as 'Nội dung'
                             from TinhLuong tl, NhanVien nv, BangLuong bl
                             where nv.id=tl.idnhanvien and tl.id=bl.id
                             order by tl.id asc;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public int tinhngaycong(int manhanvien)
        {
            try
            {
                connect();
                SqlConnection strcon = getConnectString();
                string query = $"select count(*) from ChamCong where idnhanvien={manhanvien}";
                using (SqlCommand cmd = new SqlCommand(query, strcon))
                {
                    int songaycong = (int)cmd.ExecuteScalar();
                    return songaycong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public int kiemtratontai(string id)
        {

            string query = @"select count(*) from TinhLuong where id =@id";
            using (SqlCommand cmd = new SqlCommand(query,getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int tontai = (int)cmd.ExecuteScalar();
                return tontai;
            }
        }
        public int kiemtratontai2(string id)
        {
            string query = @"select count(*) from TinhLuong where id =@id and tong is not null";
            using (SqlCommand cmd = new SqlCommand(query,getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int tontai = (int)cmd.ExecuteScalar();
                return tontai;
            }
        }
        public int kiemtratontai3(string id)
        {
            connect();
            string query = @"select count(*) from BangLuong where id =@id and trangthai=0 ";
            using (SqlCommand cmd = new SqlCommand(query, getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int tontai = (int)cmd.ExecuteScalar();
                return tontai;
            }
        }
        public void them_tinhluong_ngaycong(int idnhanvien)
        {
            string month = DateTime.Now.AddMonths(-1).Month.ToString();
            string year = DateTime.Now.AddMonths(-1).Year.ToString();
            string id = idnhanvien.ToString() + month + year;
            int ngaycong = tinhngaycong(idnhanvien);
            if (kiemtratontai(id) == 0)
            {
                string query = @"insert into TinhLuong (id,idnhanvien,ngaycong,thang,nam)" +
                                 "values(@id,@idnhanvien,@ngaycong,@thang,@nam)";
                using (SqlCommand cmd = new SqlCommand(query, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idnhanvien", idnhanvien);
                    cmd.Parameters.AddWithValue("@ngaycong", ngaycong);
                    cmd.Parameters.AddWithValue("@thang", month);
                    cmd.Parameters.AddWithValue("@nam", year);
                    cmd.ExecuteNonQuery();
                }
                string query1 = @"insert into BangLuong(id,idnhanvien,trangthai)" +
                                "values(@id,@idnhanvien,@trangthai)";
                using(SqlCommand cmd = new SqlCommand(query1, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idnhanvien", idnhanvien);
                    cmd.Parameters.AddWithValue("@trangthai", 0);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Đã tính ngày công cho nhân viên này", "Thông báo", MessageBoxButtons.OK);
            }

        }
        public void them_tinhluong_chotluong(int idnhanvien, string tongluong)
        {
            string month = DateTime.Now.AddMonths(-1).Month.ToString();
            string year = DateTime.Now.AddMonths(-1).Year.ToString();
            string id = idnhanvien.ToString() + month + year;
            if (kiemtratontai2(id) == 0)
            {
                DateTime ngaychot = DateTime.Now;
                string query = @"update TinhLuong
                                 set tong=@tong, ngaychot=@ngaychot
                                 where id=@id;";
                using (SqlCommand cmd = new SqlCommand(query, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tong", double.Parse(tongluong));
                    cmd.Parameters.AddWithValue("@ngaychot", ngaychot);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Đã chốt lương cho nhân viên này", "Thông báo", MessageBoxButtons.OK);
            }


        }
        public void them_tinhluong_traluong(string id, string noidung)
        {

            if (kiemtratontai3(id) == 1)
            {
                DateTime ngaytra = DateTime.Now;
                string query = @"update TinhLuong
                                 set ngaytraluong=@ngaytra
                                 where id=@id;";
                using (SqlCommand cmd = new SqlCommand(query, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ngaytra", ngaytra);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã trả lương thành công", "Thông báo", MessageBoxButtons.OK);
                }
                string query1 = @"update BangLuong
                                 set ngay=@ngay, thang=@thang, nam=@nam, trangthai=@trangthai, noidung=@noidung
                                 where id=@id;";
                using (SqlCommand cmd = new SqlCommand(query1, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ngay", DateTime.Now.Day.ToString());
                    cmd.Parameters.AddWithValue("@thang", DateTime.Now.Month.ToString());
                    cmd.Parameters.AddWithValue("@nam",  DateTime.Now.Year.ToString());
                    cmd.Parameters.AddWithValue("@trangthai", 1);
                    cmd.Parameters.AddWithValue("@noidung", noidung);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Đã trả lương cho nhân viên này, bạn bị nghi ngờ có hành vi biển thủ quỹ lương của công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double thuongchuyencan(int manv)
        {
            int year = int.Parse(DateTime.Now.AddMonths(-1).Year.ToString());
            int month = int.Parse(DateTime.Now.AddMonths(-1).Month.ToString());
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int countSunday = 0;
            for (int i = 1; i < daysInMonth; i++)
            {
                DateTime day = new DateTime(year, month, i);
                if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    countSunday++;
                }
            }
            int ngaynghi = daysInMonth - tinhngaycong(manv) - countSunday;
            if (ngaynghi == 0)
            {
                return 200000;
            }
            else
            {
                if (ngaynghi == 1)
                {
                    return 100000;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double trocap(int manv)
        {
            string query = @"select trc.giatri from NhanVien nv, TroCap trc where nv.id = @manv and matrocap=trc.id";
            double tientrocap = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@manv", manv);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            tientrocap = double.Parse(read["giatri"].ToString());
                        }
                    }
                }
                return tientrocap;
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy giá trị trợ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public double luongthang(int manv)
        {
            double luongcb = 0;
            double chuyencan = thuongchuyencan(manv);
            double ngaycong = tinhngaycong(manv);
            double trc = trocap(manv);
            string query = @"select giatri from HeSoLuong hsl, NhanVien nv where nv.id = @manv and nv.mahesoluong=hsl.id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query,getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@manv", manv);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            luongcb = double.Parse(read["giatri"].ToString());
                        }
                    }
                }
                double luongth = luongcb / 26 * ngaycong + trc + chuyencan;
                return luongth;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lương cơ bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public double tinhbhxh(int manv)
        {
            double bhxh = luongthang(manv);
            return bhxh * 0.08;
        }
        public double tinhbhyt(int manv)
        {
            double bhyt = luongthang(manv);
            return bhyt * 0.015;
        }
        public double tinhbhtnld(int manv)
        {
            double bhtnld = luongthang(manv);
            return bhtnld * 0.01;
        }

        public double tongluong(int manv, double bhyt, double bhtnld, double bhxh, double congdoan, double thuong)
        {
            double luonglinh = luongthang(manv) - bhyt - bhtnld - bhxh - congdoan + thuong;
            return luonglinh;
        }
        public DataTable tim_idnhanvien1(int idnhanvien)
        {
            string query = $"select nv.id as 'Mã',nv.ten as 'Tên nhân viên',cmt as 'CMT', ngaysinh as 'Ngày sinh', dienthoai as 'Điện thoại', pb.ten as 'Phòng ban', cv.ten as 'Chức vụ',email as 'Email', hosonhanvien as 'Hồ sơ nhân viên', trangthai as 'Trạng thái', maphongban as 'Mã phòng ban', machucvu as 'Mã chức vụ', mahesoluong as 'Mã hệ số lương', matrocap as 'Mã trợ cấp' " +
                $"from NhanVien nv,PhongBan pb,ChucVu cv " +
                $"where nv.id = {idnhanvien} and nv.maphongban=pb.id and nv.machucvu=cv.id and nv.trangthai=1" +
                $"order by 'Mã' asc;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable tim_idnhanvien2(int idnhanvien)
        {
            string query = $"select tl.id as 'Mã', tl.idnhanvien as 'Mã nhân viên', ten as 'Tên nhân viên', cmt as 'CMT', ngaycong as 'Ngày công',tong as 'Tổng'," +
                $"tl.thang as 'Tháng', tl.nam as 'Năm', ngaychot as 'Ngày chốt', ngaytraluong as 'Ngày trả lương', bl.trangthai as 'Trạng thái', bl.noidung as 'Nội dung'" +
                $"from TinhLuong tl, NhanVien nv, BangLuong bl" +
                $"\twhere nv.id=tl.idnhanvien and tl.id=bl.id and tl.idnhanvien = {idnhanvien}" +
                $"order by tl.id asc";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable tim_tennhanvien1(string tennhanvien)
        {
            string query = $"select nv.id as 'Mã',nv.ten as 'Tên nhân viên',cmt as 'CMT', ngaysinh as 'Ngày sinh', dienthoai as 'Điện thoại', pb.ten as 'Phòng ban', cv.ten as 'Chức vụ',email as 'Email', hosonhanvien as 'Hồ sơ nhân viên', trangthai as 'Trạng thái', maphongban as 'Mã phòng ban', machucvu as 'Mã chức vụ', mahesoluong as 'Mã hệ số lương', matrocap as 'Mã trợ cấp' " +
                $"from NhanVien nv,PhongBan pb,ChucVu cv " +
                $"where nv.ten like N'%{tennhanvien}%' and nv.maphongban=pb.id and nv.machucvu=cv.id and nv.trangthai=1" +
                $"order by 'Mã' asc;";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable tim_tennhanvien2(string tennhanvien)
        {
            int idnhanvien = 0;
            string query1 = $"select id from NhanVien where ten like N'%{tennhanvien}%'";
            using(SqlCommand cmd = new SqlCommand(query1, conn)) {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idnhanvien = int.Parse(reader["id"].ToString());
                    }
                }
            }
            string query = $"select tl.id as 'Mã', tl.idnhanvien as 'Mã nhân viên', ten as 'Tên nhân viên', cmt as 'CMT', ngaycong as 'Ngày công',tong as 'Tổng'," +
                $"tl.thang as 'Tháng', tl.nam as 'Năm', ngaychot as 'Ngày chốt', ngaytraluong as 'Ngày trả lương', bl.trangthai as 'Trạng thái', bl.noidung as 'Nội dung'" +
                $"from TinhLuong tl, NhanVien nv, BangLuong bl" +
                $"\twhere nv.id=tl.idnhanvien and tl.id=bl.id and tl.idnhanvien={idnhanvien} " +
                $"order by tl.id asc";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable tim_chucvu(string chucvu)
        {
            int macv = 0;
            string query1 = $"select id from ChucVu where ten like N'{chucvu}'";
            using (SqlCommand cmd = new SqlCommand(query1, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        macv = int.Parse(reader["id"].ToString());
                    }
                }
            }
            string query = $"select tl.id as 'Mã', tl.idnhanvien as 'Mã nhân viên', ten as 'Tên nhân viên', cmt as 'CMT', ngaycong as 'Ngày công',tong as 'Tổng'," +
                $"tl.thang as 'Tháng', tl.nam as 'Năm', ngaychot as 'Ngày chốt', ngaytraluong as 'Ngày trả lương', bl.trangthai as 'Trạng thái', bl.noidung as 'Nội dung'" +
                $"from TinhLuong tl, NhanVien nv, BangLuong bl " +
                $"\twhere nv.id=tl.idnhanvien and tl.id=bl.id and nv.machucvu={macv} " +
                $"order by tl.id asc";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public void luunoidung(string id,string noidung)
        {
            string query1 = @"update BangLuong
                                 set noidung=@noidung
                                 where id=@id;";
            using (SqlCommand cmd = new SqlCommand(query1, getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@noidung", noidung);
                cmd.ExecuteNonQuery();
            }
        }
        public string getchucvu(int idnhanvien)
        {
            string query = $"select cv.ten " +
                $"from NhanVien nv, ChucVu cv " +
                $"where nv.id={idnhanvien} and nv.machucvu=cv.id;";
            using(SqlCommand cmd = new SqlCommand(query, conn))
            {
                using(SqlDataReader reader =cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["ten"].ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        } 
        public void Xoabangluong(string id)
        {
            int trangthai = 0;
            string query = $"select trangthai from BangLuong where id='{id}'";
            using(SqlCommand cmd = new SqlCommand(query, conn))
            {
               using(SqlDataReader reader = cmd.ExecuteReader())
               {
                    if (reader.Read())
                    {
                        trangthai = int.Parse(reader["trangthai"].ToString());
                    }
               }
            }
            if (trangthai == 0)
            {
                string query1 = $"delete from BangLuong where id = '{id}'";
                using(SqlCommand cmd = new SqlCommand(query1, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                string query2 = $"delete from TinhLuong where id = '{id}'";
                using (SqlCommand cmd = new SqlCommand(query2, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã xóa thành công","Thông báo");
            }
            else
            {
                MessageBox.Show("Đã trả lương, không thể xóa", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

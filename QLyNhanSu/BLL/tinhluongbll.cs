using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;

namespace QLyNhanSu.BLL
{
    internal class tinhluongbll
    {
        ketnoiCSDL data = new ketnoiCSDL();
        public int tinhngaycong(int manhanvien)
        {
            try
            {
                data.connect();
                SqlConnection strcon = data.getConnectString();
                string query = $"select count(*) from ChamCong where idnhanvien={manhanvien}";
                using (SqlCommand cmd = new SqlCommand(query, strcon))
                {
                    int songaycong = (int)cmd.ExecuteScalar();
                    return songaycong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -1;
            }
        }
        public int kiemtratontai(string id)
        {
            
            string query = @"select count(*) from TinhLuong where id =@id";
            using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int tontai = (int)cmd.ExecuteScalar();
                return tontai;
            }
        }
        public int kiemtratontai2(string id)
        {
            string query = @"select count(*) from TinhLuong where id =@id and tong is not null";
            using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int tontai = (int)cmd.ExecuteScalar();
                return tontai;
            }
        }
        public int kiemtratontai3(string id)
        {
            data.connect();
            string query = @"select count(*) from TinhLuong where id =@id and trangthai=0 ";
            using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
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
            string id = idnhanvien.ToString()+month+year;
            int ngaycong = tinhngaycong(idnhanvien);
            if(kiemtratontai(id) == 0)
            {
                string query = @"insert into TinhLuong (id,idnhanvien,ngaycong,thang,nam)" +
                                 "values(@id,@idnhanvien,@ngaycong,@thang,@nam)";
                using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@idnhanvien", idnhanvien);
                    cmd.Parameters.AddWithValue("@ngaycong", ngaycong);
                    cmd.Parameters.AddWithValue("@thang", month);
                    cmd.Parameters.AddWithValue("@nam", year);
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
            if (kiemtratontai2(id)==0)
            {
                DateTime ngaychot = DateTime.Now;
                string query = @"update TinhLuong
                                 set tong=@tong, ngaychot=@ngaychot, trangthai=@trangthai
                                 where id=@id;";
                using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tong",double.Parse(tongluong));
                    cmd.Parameters.AddWithValue("@ngaychot", ngaychot);
                    cmd.Parameters.AddWithValue("@trangthai", 0);
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
                                 set ngaytraluong=@ngaytra,trangthai=@trangthai, noidung=@noidung
                                 where id=@id;";
                data.connect();
                using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ngaytra", ngaytra);
                    cmd.Parameters.AddWithValue("@trangthai", 1);
                    cmd.Parameters.AddWithValue("@noidung", noidung);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã trả lương thành cong", "Thông báo",MessageBoxButtons.OK);
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
            int daysInMonth = DateTime.DaysInMonth(year,month);
            int countSunday = 0;
            for(int i = 1; i < daysInMonth; i++)
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
                if(ngaynghi == 1)
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
                using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
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
        public double luongthang(int manv, string trc)
        {
            double luongcb = 0;
            double chuyencan = thuongchuyencan(manv);
            double ngaycong = tinhngaycong(manv);
            string query = @"select luongcoban from NhanVien where id = @manv";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, data.getConnectString()))
                {
                    cmd.Parameters.AddWithValue("@manv", manv);
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            luongcb = double.Parse(read["luongcoban"].ToString());
                        }
                    }
                }
                double luongth = luongcb/26*ngaycong+double.Parse(trc)+chuyencan;
                return luongth;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lương cơ bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public double tinhbhxh( int manv,string trc)
        {
            double bhxh = luongthang(manv,trc);
            return bhxh * 0.08;
        }
        public double tinhbhyt(int manv, string trc)
        {
            double bhyt = luongthang(manv,trc);
            return bhyt*0.015;
        }
        public double tinhbhtnld( int manv, string trc)
        {
            double bhtnld = luongthang(manv, trc);
            return bhtnld * 0.01;
        }

        public double tongluong(int manv, double bhyt, double bhtnld, double bhxh, double congdoan, string trc,double thuong )
        {
            double luonglinh = luongthang(manv,trc)-bhyt-bhtnld-bhxh-congdoan+thuong;
            return luonglinh;
        } 
    }
}
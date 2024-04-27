using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.IO;
using MongoDB.Driver.Core.Configuration;
using System.Configuration;
namespace QLyNhanSu.BLL
{
    internal class nhanvienbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("nhanvien_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("nhanvien_timkiem", ma);
            return dt;
        }
        public void them(nhanviendto doituong)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string chuoi = "INSERT INTO NhanVien ";
            chuoi += "(id, ten, cmt, ngaysinh, email, hosonhanvien, trangthai, hinhanh, maphongban, machucvu, mahesoluong, matrocap) ";
            chuoi += "VALUES (@ID, @Ten, @CMT, @NgaySinh, @Email, @HoSoNhanVien, @TrangThai, @HinhAnh, @MaPhongBan, @MaChucVu, @MaHeSoLuong, @MaTroCap)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(chuoi, connection))
                    {
                        // Thiết lập các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@ID", doituong.id);
                        command.Parameters.AddWithValue("@Ten", doituong.ten);
                        command.Parameters.AddWithValue("@CMT", doituong.cmt);
                        command.Parameters.AddWithValue("@NgaySinh", doituong.ngaysinh);
                        command.Parameters.AddWithValue("@Email", doituong.email);
                        command.Parameters.AddWithValue("@HoSoNhanVien", doituong.hosonhanvien);
                        command.Parameters.AddWithValue("@TrangThai", doituong.trangthai);
                        command.Parameters.AddWithValue("@HinhAnh", doituong.hinhanh);
                        command.Parameters.AddWithValue("@MaPhongBan", doituong.maphongban);
                        command.Parameters.AddWithValue("@MaChucVu", doituong.machucvu);
                        command.Parameters.AddWithValue("@MaHeSoLuong", doituong.masoheluong);
                        command.Parameters.AddWithValue("@MaTroCap", doituong.matrocap);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void sua(nhanviendto doituong)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            string chuoi = "UPDATE NhanVien SET ";
            chuoi += "ten = @Ten, ";
            chuoi += "cmt = @CMT, ";
            chuoi += "ngaysinh = @NgaySinh, ";
            chuoi += "email = @Email, ";
            chuoi += "hosonhanvien = @HoSoNhanVien, ";
            chuoi += "trangthai = @TrangThai, ";
            chuoi += "hinhanh = @HinhAnh, ";
            chuoi += "maphongban = @MaPhongBan, ";
            chuoi += "machucvu = @MaChucVu, ";
            chuoi += "mahesoluong = @MaHeSoLuong, ";
            chuoi += "matrocap = @MaTroCap ";
            chuoi += "WHERE id = @ID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(chuoi, connection))
                    {
                        // Thiết lập các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@Ten", doituong.ten);
                        command.Parameters.AddWithValue("@CMT", doituong.cmt);
                        command.Parameters.AddWithValue("@NgaySinh", doituong.ngaysinh);
                        command.Parameters.AddWithValue("@Email", doituong.email);
                        command.Parameters.AddWithValue("@HoSoNhanVien", doituong.hosonhanvien);
                        command.Parameters.AddWithValue("@TrangThai", doituong.trangthai);
                        command.Parameters.AddWithValue("@HinhAnh", doituong.hinhanh);
                        command.Parameters.AddWithValue("@MaPhongBan", doituong.maphongban);
                        command.Parameters.AddWithValue("@MaChucVu", doituong.machucvu);
                        command.Parameters.AddWithValue("@MaHeSoLuong", doituong.masoheluong);
                        command.Parameters.AddWithValue("@MaTroCap", doituong.matrocap);
                        command.Parameters.AddWithValue("@ID", doituong.id);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void xoa(nhanviendto doituong)
        {
            string chuoi = "DELETE FROM NhanVien ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
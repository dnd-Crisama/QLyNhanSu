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
            string chuoi = " INSERT INTO NhanVien ";
            chuoi += " (ten,cmt,ngaysinh,phone,hosonhanvien,trangthai,hinhanh,maphongban,machucvu,mahesoluong,matrocap) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.ten + "', ";
            chuoi += " N'" + doituong.cmt + "', ";
            chuoi += " N'" + doituong.ngaysinh + "', ";
            chuoi += " N'" + doituong.phone + "', ";
            chuoi += " N'" + doituong.hosonhanvien + "', ";
            chuoi += " N'" + doituong.trangthai + "', ";
            chuoi += " N'" + doituong.hinhanh + "', ";
            chuoi += " N'" + doituong.maphongban + "', ";
            chuoi += " N'" + doituong.machucvu + "', ";
            chuoi += " N'" + doituong.masoheluong + "', ";
            chuoi += " N'" + doituong.matrocap + "') ";

            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(nhanviendto doituong)
        {
            string chuoi = " UPDATE NhanVien SET ";
            chuoi += " ten= N'" + doituong.ten + "', ";
            chuoi += " cmt= N'" + doituong.cmt + "', ";
            chuoi += " ngaysinh= N'" + doituong.ngaysinh + "', ";
            chuoi += " phone= N'" + doituong.phone + "', ";
            chuoi += " hosonhanvien= N'" + doituong.hosonhanvien + "', ";
            chuoi += " trangthai= N'" + doituong.trangthai + "', ";
            chuoi += " maphongban= N'" + doituong.maphongban + "' ";
            chuoi += " machucvu= N'" + doituong.machucvu + "' ";
            chuoi += " masoheluong= N'" + doituong.masoheluong + "', ";
            chuoi += " matrocap= N'" + doituong.matrocap + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
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
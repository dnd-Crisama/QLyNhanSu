using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.IO;

namespace QLyNhanSu.BLL
{
    internal class bangluongbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("bangluong_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("bangluong_timkiem", ma);
            return dt;
        }
        public void them(bangluongdto doituong)
        {
            string chuoi = " INSERT INTO BangLuong ";
            chuoi += " (idnhanvien,gio,ngay,thang,nam,trangthai,noidung,ghichu) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.idnhanvien + "', ";
            chuoi += " N'" + doituong.gio + "', ";
            chuoi += " N'" + doituong.ngay + "', ";
            chuoi += " N'" + doituong.thang + "', ";
            chuoi += " N'" + doituong.nam + "', ";
            chuoi += " N'" + doituong.trangthai + "', ";
            chuoi += " N'" + doituong.noidung + "', ";
            chuoi += " N'" + doituong.ghichu + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(bangluongdto doituong)
        {
            string chuoi = " UPDATE BangLuong SET ";
            chuoi += " idnhanvien= N'" + doituong.idnhanvien + "', ";
            chuoi += " gio= N'" + doituong.gio + "', ";
            chuoi += " ngay= N'" + doituong.ngay + "', ";
            chuoi += " thang= N'" + doituong.thang + "', ";
            chuoi += " nam= N'" + doituong.nam + "', ";
            chuoi += " trangthai= N'" + doituong.trangthai + "', ";
            chuoi += " noidung= N'" + doituong.noidung + "' ";
            chuoi += " ghichu= N'" + doituong.ghichu + "', ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(bangluongdto doituong)
        {
            string chuoi = "DELETE FROM BangLuong ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
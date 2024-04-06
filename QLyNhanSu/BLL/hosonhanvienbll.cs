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
    internal class hosonhanvienbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("hosonhanvien_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("hosonhanvien_timkiem", ma);
            return dt;
        }
        public void them(hosonhanviendto doituong)
        {
            string chuoi = " INSERT INTO HoSoNhanVien ";
            chuoi += " (kihieu,noidung,ngaytao,ngaycapphat) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.kihieu + "', ";
            chuoi += " N'" + doituong.noidung + "', ";
            chuoi += " N'" + doituong.ngaytao + "', ";
            chuoi += " N'" + doituong.ngaycapphat + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(hosonhanviendto doituong)
        {
            string chuoi = " UPDATE HoSoNhanVien SET ";
            chuoi += " kihieu= N'" + doituong.kihieu + "', ";
            chuoi += " noidung= N'" + doituong.noidung + "', ";
            chuoi += " ngaytao= N'" + doituong.ngaytao + "', ";
            chuoi += " ngaycapphat= N'" + doituong.ngaycapphat + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(hosonhanviendto doituong)
        {
            string chuoi = "DELETE FROM HoSoNhanVien    ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
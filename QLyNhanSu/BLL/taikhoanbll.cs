using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.IO;
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;
namespace QLyNhanSu.BLL
{
    internal class taikhoanbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("taikhoan_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("taikhoan_timkiem", ma);
            return dt;
        }
        public void them(taikhoandto doituong)
        {
            string chuoi = " INSERT INTO TaiKhoan ";
            chuoi += " (username,password,maquyen,trangthai) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.username + "', ";
            chuoi += " N'" + doituong.password + "', ";
            chuoi += " N'" + doituong.maquyen + "', ";
            chuoi += " N'" + doituong.trangthai + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(taikhoandto doituong)
        {
            string chuoi = " UPDATE TaiKhoan SET ";
            chuoi += " username= N'" + doituong.username + "', ";
            chuoi += " password= N'" + doituong.password + "' ";
            chuoi += " maquyen= N'" + doituong.trangthai + "' ";
            chuoi += " trangthai= N'" + doituong.trangthai + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(taikhoandto doituong)
        {
            string chuoi = "DELETE FROM TaiKhoan    ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}

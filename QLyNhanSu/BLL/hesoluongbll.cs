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
    internal class hesoluongbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("hesoluong_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("hesoluong_timkiem", ma);
            return dt;
        }
        public void them(hesoluong doituong)
        {
            string chuoi = " INSERT INTO HeSoLuong ";
            chuoi += " (id,ten,giatri) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.id + "', ";
            chuoi += " N'" + doituong.ten + "', ";
            chuoi += " N'" + doituong.giatri + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(hesoluong doituong)
        {
            string chuoi = " UPDATE HeSoLuong SET ";
            chuoi += " ten= N'" + doituong.ten + "', ";
            chuoi += " giatri= N'" + doituong.giatri + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(hesoluong doituong)
        {
            string chuoi = "DELETE FROM HeSoLuong    ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}

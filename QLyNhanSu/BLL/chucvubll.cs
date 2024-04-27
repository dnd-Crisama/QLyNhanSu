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
    internal class chucvubll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("chucvu_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("chucvu_timkiem", ma);
            return dt;
        }
        public void them(chucvudto doituong)
        {
            string chuoi = " INSERT INTO ChucVu ";
            chuoi += " (id,ten,kihieu) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.id + "', ";
            chuoi += " N'" + doituong.ten + "', ";
            chuoi += " N'" + doituong.kihieu + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(chucvudto doituong)
        {
            string chuoi = " UPDATE ChucVu SET ";
            chuoi += " ten= N'" + doituong.ten + "', ";
            chuoi += " kihieu= N'" + doituong.kihieu + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(chucvudto doituong)
        {
            string chuoi = "DELETE  FROM ChucVu    ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}

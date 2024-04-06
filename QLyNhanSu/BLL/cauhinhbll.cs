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
using QLyNhanSu.DAL;
using QLyNhanSu.DTO;

namespace QLyNhanSu.BLL
{
    internal class cauhinhbll
    {
        DataAccess ac = new DataAccess();
        public DataTable hien()
        {
            var dt = ac.GetDataTable_Store("cauhinh_hien");
            return dt;
        }
        public DataTable timkiem(string ma)
        {
            var dt = ac.Load_Theo_ma("cauhinh_timkiem", ma);
            return dt;
        }
        public void them(cauhinhdto doituong)
        {
            string chuoi = " INSERT INTO CauHinh ";
            chuoi += " (ten,tacgia,noidung,huongdan) ";
            chuoi += " VALUES ( ";
            chuoi += " N'" + doituong.ten + "', ";
            chuoi += " N'" + doituong.tacgia + "', ";
            chuoi += " N'" + doituong.noidung + "', ";
            chuoi += " N'" + doituong.huongdan + "') ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void sua(cauhinhdto doituong)
        {
            string chuoi = " UPDATE CauHinh SET ";
            chuoi += " ten= N'" + doituong.ten + "', ";
            chuoi += " tacgia= N'" + doituong.tacgia + "', ";
            chuoi += " noidung= N'" + doituong.noidung + "', ";
            chuoi += " huongdan= N'" + doituong.huongdan + "' ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public void xoa(cauhinhdto doituong)
        {
            string chuoi = "DELETE FROM CauHinh    ";
            chuoi += " WHERE id = N'" + doituong.id + "' ";
            try
            {
                ac.ExecuteCommandtext(chuoi);
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
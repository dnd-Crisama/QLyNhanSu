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
        ketnoiCSDL data = new ketnoiCSDL();
        public bangluongdto bl { get; set; }
        public DataTable gettinhluong()
        {
            return data.gettinhluong();
        }
        public void luunoidung(string noidung)
        {
            data.luunoidung(bl.id, noidung);
        }
        public string getchucvu()
        {
            return data.getchucvu(bl.idnhanvien);
        }
        public DataTable tim_idnhanvien2(int idnv)
        {
            return data.tim_idnhanvien2(idnv);
        }
        public DataTable tim_tennhanvien2(string tennv)
        {
            return data.tim_tennhanvien2(tennv);
        }
        public DataTable tim_chucvu(string  chucvu)
        {
            return data.tim_chucvu(chucvu);
        }
        public void Xoabangluong(string id)
        {
            data.Xoabangluong(id);
        }
    }
}
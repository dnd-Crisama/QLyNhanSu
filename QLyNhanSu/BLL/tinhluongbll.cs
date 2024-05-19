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
        public nhanviendto nv { get; set; }
        public tinhluongdto tl {  get; set; }
        public DataTable getdsnhanvien()
        {
            return data.getdsnhanvien();
        }
        public DataTable gettinhluong()
        {
            return data.gettinhluong();
        }
        public int tinhngaycong()
        {
           return data.tinhngaycong(nv.id);
        }
        public void them_tinhluong_ngaycong()
        {
            data.them_tinhluong_ngaycong(nv.id);
              
        }
        public void them_tinhluong_chotluong(string tongluong)
        {
            data.them_tinhluong_chotluong(nv.id, tongluong);
        }
        public void them_tinhluong_traluong(string noidung)
        {

            data.them_tinhluong_traluong(tl.id, noidung);
        }
        public double thuongchuyencan()
        {
            return data.thuongchuyencan(nv.id);
        }
        public double trocap()
        {
            return data.trocap(nv.id);
        }
        
        public double tinhbhxh()
        {
            return data.tinhbhxh(nv.id);
        }
        public double tinhbhyt()
        {
            return data.tinhbhyt(nv.id);
        }
        public double tinhbhtnld()
        {
            return data.tinhbhtnld(nv.id);
        }

        public double tongluong(double bhyt, double bhtnld, double bhxh, double congdoan,double thuong )
        {
            return data.luongthang(nv.id)-bhyt-bhtnld-bhxh-congdoan+thuong;
        } 
        public DataTable tim_idnhanvien1()
        {
            return data.tim_idnhanvien1(nv.id);
        }
        public DataTable tim_idnhanvien2()
        {
            return data.tim_idnhanvien2(nv.id);
        }
        public DataTable tim_tennhanvien1()
        {
            return data.tim_tennhanvien1(nv.ten);
        }
        public DataTable tim_tennhanvien2()
        {
            return data.tim_tennhanvien2(nv.ten);
        }
    }
}
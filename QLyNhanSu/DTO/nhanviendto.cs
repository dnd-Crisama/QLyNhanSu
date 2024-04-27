using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLyNhanSu.DTO
{
    internal class nhanviendto
    {
        public int id {  get; set; }
        public string ten { get; set; }
        public string cmt { get; set; }
        public string ngaysinh { get; set; }
        public string email { get; set; }
        public int hosonhanvien { get; set; }
        public int trangthai { get; set; }
        public byte[] hinhanh { get; set; }
        public int maphongban { get; set; }
        public int machucvu {  get; set; }
        public int masoheluong {  get; set; }
        public int matrocap {  get; set; }


    }
}

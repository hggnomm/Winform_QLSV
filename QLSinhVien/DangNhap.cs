using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    public class DangNhap
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Hoten { get; set; }
        public string Quyen { get; set; }

        public DangNhap() { }
        public DangNhap(string taiKhoan, string matKhau, string hoten, string quyen)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            Hoten = hoten;
            Quyen = quyen;
        }
    }
}

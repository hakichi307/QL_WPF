using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string PhongBan { get; set; }
        public double HeSoLuong { get; set; }
        public int Tuoi { get; set; }

        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string phongBan, double heSoLuong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            PhongBan = phongBan;
            HeSoLuong = heSoLuong;
            Tuoi = DateTime.Now.Year - ngaySinh.Year;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Nhanvien_2
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LuongNgay { get; set; }
        public int SoNgayLamViec { get; set; }
        public int TienLuong { get; set; }
        public int TinhLuong(int LuongNgay, int SoNgayLamViec)
        {
            if (SoNgayLamViec <= 24)
                return SoNgayLamViec * LuongNgay;
            else
                return (24 + (SoNgayLamViec - 24) * 2) * LuongNgay;
        }
        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, int luongNgay, int soNgayLamViec)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.LuongNgay = luongNgay;
            this.SoNgayLamViec = soNgayLamViec;
            this.TienLuong = TinhLuong(luongNgay, soNgayLamViec);
        }
    }
}

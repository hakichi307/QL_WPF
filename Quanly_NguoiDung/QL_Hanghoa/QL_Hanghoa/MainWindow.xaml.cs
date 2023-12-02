using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QL_Hanghoa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Hang> danhsachHang = new List<Hang>();
        List<string> Danhmuchangs = new List<string>() {
        "Quần áo",
        "Máy tính",
        "Điện thoại",
        };
        public MainWindow()
        {
            InitializeComponent();
            cbo_danhmuchang.ItemsSource = Danhmuchangs;
            txt_mahang.Focus();
        }


        private void btn_nhap_Click(object sender, RoutedEventArgs e)
        {

            //string message = "";
            if (string.IsNullOrWhiteSpace(txt_mahang.Text) || string.IsNullOrWhiteSpace(txt_tenhang.Text))
            {
                MessageBox.Show("Lỗi: Vui lòng nhập mã hàng và tên hàng.", "Thông báo");
                return; // Exit the method early since required fields are missing.
            }
            if (float.TryParse(txt_dongiaban.Text, out float donGiaBan))
            {
                donGiaBan = float.Parse(txt_dongiaban.Text);
            }
            else
            {
                MessageBox.Show("Lỗi: Nhập đơn giá không hợp lệ", "Thông báo");
            }
            if (int.TryParse(txt_soluongcon.Text, out int soLuongCon))
            {
                soLuongCon = int.Parse(txt_soluongcon.Text);

            }
            else
            {
                MessageBox.Show("Lỗi: Nhập số lượng không hợp lệ", "Thông báo");
            }

            string maHang = txt_mahang.Text.Trim();
            string danhMucHang = cbo_danhmuchang.SelectedItem != null ? cbo_danhmuchang.SelectedItem.ToString() : "";
            string tenHang = txt_tenhang.Text;



            if (maHang == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng", "Thông báo");
                return;
            }
            if (tenHang == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo");
                return;
            }
            if (danhMucHang == "")
            {
                MessageBox.Show("Vui lòng chọn loại danh mục hàng", "Thông báo");

                return;
            }

            if (donGiaBan <= 0)
            {
                MessageBox.Show("Lỗi: Đơn giá bán phải lớn hơn 0 ", "Thông báo");

                return;
            }
           

            if (soLuongCon <= 0)
            {
                MessageBox.Show("Lỗi: Số tiền bán hàng phải > 0", "Thông báo");
                return;
            }

            // string text = $"{hoTen} - {ngaySinh} - {loaiNV} - Tiền bán hàng: {x} - Hoa hồng: {tienHoaHong(x)}";
            // listBoxData.Items.Add(text);
            Hang hang = new Hang(maHang, tenHang, danhMucHang, donGiaBan, soLuongCon, donGiaBan * soLuongCon);
            dgv_hang.Items.Add(hang);
            danhsachHang.Add(hang);
        }
        public class Hang
        {
            public string MaHang { get; set; }
            public string TenHang { get; set; }
            public string DanhMucHang { get; set; }
            public float DonGiaBan { get; set; }
            public int SoLuongCon { get; set; }
            public float ThanhTien { get; set; }

            public Hang(string maHang, string tenHang, string danhMucHang, float donGiaBan, int soLuongCon, float thanhTien)
            {
                MaHang = maHang;
                TenHang = tenHang;
                DanhMucHang = danhMucHang;
                DonGiaBan = donGiaBan;
                SoLuongCon = soLuongCon;
                ThanhTien = thanhTien;
            }
           
        }
        private void btn_window2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2(danhsachHang);
            window.Show();
        }

    }
}

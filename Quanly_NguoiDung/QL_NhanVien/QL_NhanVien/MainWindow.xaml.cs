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

namespace QL_NhanVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            dgv_danhsach.ItemsSource = danhSachNhanVien;
            txt_manv.Focus();
        }
        private void btn_nhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_manv.Text) || string.IsNullOrWhiteSpace(txt_hoten.Text) ||
               string.IsNullOrWhiteSpace(txt_hesoluong.Text) || date_ngaysinh.SelectedDate == null)
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                    return;
                }
                //-Kiểm tra tuổi >=18
                DateTime ngaySinh = date_ngaysinh.SelectedDate.Value;
                int tuoi = DateTime.Now.Year - ngaySinh.Year;
                if (DateTime.Now < ngaySinh.AddYears(tuoi)) { tuoi--; }
                if (tuoi < 18)
                {
                    MessageBox.Show("Tuổi nhân viên phải lớn hơn hoặc bằng 18.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (double.TryParse(txt_hesoluong.Text, out double heSoLuong) || heSoLuong <= 0)
                {
                    heSoLuong = double.Parse(txt_hesoluong.Text);
                }
                else
                {
                    MessageBox.Show("Lỗi nhập hệ số lương không hợp lệ", "Thông báo");
                    return;
                }
                // Kiểm tra trùng mã nhân viên
                if (danhSachNhanVien.Any(nv => nv.MaNV == txt_manv.Text))
                {
                    MessageBox.Show("Lỗi: Mã nhân viên đã tồn tại.", "Thông báo");
                    return;
                }
                //Thêm nhân viên vào list
                NhanVien nhanVien = new NhanVien(
                    txt_manv.Text,
                    txt_hoten.Text,
                    date_ngaysinh.SelectedDate.Value,
                    rad_nam.IsChecked == true ? "Nam" : "Nữ",
                    (cbo_phongban.SelectedItem as ComboBoxItem)?.Content.ToString(),
                    heSoLuong
                    );
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                danhSachNhanVien.Add(nhanVien);
                dgv_danhsach.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btn_window2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(danhSachNhanVien);
            window2.Show();
        }
    }
}

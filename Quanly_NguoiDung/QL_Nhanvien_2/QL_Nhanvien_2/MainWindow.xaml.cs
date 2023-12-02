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

namespace QL_Nhanvien_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static private List<NhanVien> items = new List<NhanVien>();
        private void btnHienThi_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien(ThongTin.MaNV, ThongTin.HoTen, ThongTin.GioiTinh, ThongTin.NgaySinh, ThongTin.LuongNgay, ThongTin.SoNgayLamViec);
            items.Add(nv);
            hienthi();
        }
        private void hienthi()
        {
            lvNhanVien.ItemsSource = items;
            lvNhanVien.Items.Refresh();
            clearboxs();
        }
        private void clearboxs()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtSoNgayLamViec.Clear();
            txtTienLuongNgay.Clear();
            dpkNgaySinh.SelectedDate = DateTime.Now;
            txtMaNhanVien.Focus();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ThemMoi f = new ThemMoi();
            f.Show();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in items.ToList())
                {
                    if (item != null && item.MaNV != null && item.MaNV.Equals(txtMaNhanVien.Text))
                    {
                        items.Remove(item);
                        hienthi();
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy nhân viên có mã " + txtMaNhanVien.Text, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá nhân viên: " + ex.Message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            clearboxs();
        }
        private void lvNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                NhanVien item = (NhanVien)lvNhanVien.SelectedItem;

                if (item != null)
                {
                    txtMaNhanVien.Text = item.MaNV;
                    txtHoTen.Text = item.HoTen;
                    dpkNgaySinh.SelectedDate = item.NgaySinh;

                    if (item.GioiTinh == "Nam")
                        radNam.IsChecked = true;
                    else
                        radNu.IsChecked = true;

                    txtSoNgayLamViec.Text = item.SoNgayLamViec.ToString();
                    txtTienLuongNgay.Text = item.LuongNgay.ToString();
                    lvNhanVien.Items.Refresh();
                }
                else
                {
                    MessageBox.Show($"Nhân viên có mã {item.MaNV} đã đượcxoá khỏi danh sách.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

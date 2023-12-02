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
using System.Windows.Shapes;

namespace QL_Nhanvien_2
{
    /// <summary>
    /// Interaction logic for ThemMoi.xaml
    /// </summary>
    public partial class ThemMoi : Window
    {
        public ThemMoi()
        {
            InitializeComponent();
        }
        private void btnDongForm_Click(object sender, RoutedEventArgs e)
        {
            ThongTin.MaNV = txtMaNhanVien.Text;
            ThongTin.HoTen = txtHoTen.Text;
            string gt;
            if (radNam.IsChecked == true)
            {
                gt = "Nam";
            }
            else gt = "Nu";
            ThongTin.GioiTinh = gt;
            ThongTin.NgaySinh = dpkNgaySinh.SelectedDate.Value;
            ThongTin.LuongNgay = int.Parse(txtTienLuongNgay.Text);
            ThongTin.SoNgayLamViec = int.Parse(txtSoNgayLamViec.Text);
            this.Close();
            MainWindow f = new MainWindow();
            f.Show();
        }
    }
}

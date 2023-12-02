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
using static QL_Hanghoa.MainWindow;

namespace QL_Hanghoa
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public List<Hang> HangList { get; set; }
        public Window2(List<Hang> hangList)
        {

            InitializeComponent();
            HangList = hangList;
            var TienLonNhat = HangList.Where(nv => nv.ThanhTien == HangList.Max(x => x.ThanhTien)).ToList();
            dgv2.ItemsSource = TienLonNhat;
        }
    }
}

   M S B A M L   `   `   `  ����F  BQL_NhanVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QL_NhanVienQL_NhanVien  5   	       QL_NhanVien.Window2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QL_NhanVien     5   	     � Title$  Window2��5   	   $	��350��6   $	��800��6&   .��5	      � .+�5
   
   �� $'��!Quản lý thông tin nhân viên��6   $
��Left=�66   $��
245,16,0,0q�6Q   $	��Top=�6e   $
��Bold"�6}   ���	#FF1354F3$��22(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgv_danhsach_cao_nhat��5         AutoGenerateColumns .     CanUserAddRows .     AlternatingRowBackground
 �����$��52,104,52,104q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaNV+6W     5      $ 	Họ tên��6%    65   �� *HoTen+  5      $ Giới tính��6%    68   �� *
GioiTinh+  5      $ 
Phòng ban��6%    68   �� *
PhongBan+  5      $ 
Ngày sinh��6%    68   �� *
NgaySinh+  5      $ Tuổi��6%    63   �� *Tuoi+5      5      5      
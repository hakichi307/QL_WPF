   M S B A M L   `   `   `  ����E  AQL_Hanghoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QL_Hanghoa
QL_Hanghoa  5   	       QL_Hanghoa.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QL_Hanghoa     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��800��6)   .��5	   
   � .+�5
      �� $!��Quản lý danh mục hàng��6   $
��Bold"�64   
����  �$
��Left=�6Y   $��
305,27,0,0q�6t   $	��Top=�6�   �� 5      $��	Mã hàng��6   $
��Left=�6&   $��	76,71,0,0q�6A   $	��Top=�6T   �� 5      $��
Tên hàng��6   $
��Left=�6'   $��
68,117,0,0q�6B   $	��Top=�6V   �� 5      $��Danh mục hàng��6   $
��Left=�6,   $��
45,248,0,0q�6G   $	��Top=�6[   �� 5      $��Đơn giá bán��6   $
��Left=�6*   $��
58,163,0,0q�6E   $	��Top=�6Y   �� 5      $��Số lượng còn��6   $
��Left=�6+   $��
54,205,0,0q�6F   $	��Top=�6Z   �� 5      -   5        $��
txt_mahang��5      $
��Left=�6(   $��
173,75,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6l   $	��150��6�   �� 5      -   5        $��txt_tenhang��5      $
��Left=�6)   $��174,125,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6n   $	��150��6�   �� 5      -   5        $��txt_dongiaban��5      $
��Left=�6+   $��175,171,0,0q�6F   $
 Wrap=�6[   $	��Top=�6p   $	��150��6�   �� 5      -   5        $��txt_soluongcon��5      $
��Left=�6,   $��175,209,0,0q�6G   $
 Wrap=�6\   $	��Top=�6q   $	��150��6�   �� 5      -   5        $��cbo_danhmuchang��5      $
��Left=�6.   $��174,244,0,0q�6I   $	��Top=�6^   $	��150��6v    �� SelectedIndex$ 0��6�    J� RenderTransformOrigin$ 0.505,0.566&�6�   &   System.Windows.Controls.DataGrid  5      -   5        $��dgv_hang��5         AutoGenerateColumns .     AlternatingRowBackground
 �����   CanUserAddRows .  $��45,293,28,93q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã hàng��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *MaHang+  5      $ 
Tên hàng��6)   	 6;   �� *	TenHang+  5      $ Danh mục hàng��6)   	 6@   �� *DanhMucHang+  5      $ Đơn giá bán��6)   	 6>   �� *	DonGiaBan+  5      $ Số lượng còn��6)   	 6?   �� *
SoLuongCon+  5      $ Thành tiền��6)   	 6=   �� *	ThanhTien+5      �� 5!      -   5        $��btn_nhap��5!      $��Nhập��6%   $
��Left=�64   $��240,557,0,0q�6O   $	��Top=�6d   $��65��6|   6�   �� 5#      -   5        $��btn_window2��5#      $��Window2��6(   $
��Left=�6:   $��463,557,0,0q�6U   $	��Top=�6j   $��74��6�   6�   5%      5&      
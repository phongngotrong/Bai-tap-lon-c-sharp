   M S B A M L   `   `   `  ����D  @Nhom6_BTL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Nhom6_BTL	Nhom6_BTL  5   	       Nhom6_BTL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Nhom6_BTL     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$# ỨNG DỤNG TRA CỨU LUẬT��5   	   $	��500��6'   $	��800��64   .��5      �  � RowDefinitions 5   
   �� 5      $
��766* �6   �� 5      $	��19* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�5      $��16q�5      ���#f083da.��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�5      +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5!      d�  ' #MaterialDesignHamburgerToggleButton#��[ 5"   	   �� 5#      -   5         ��Name$ cbbox��5#      	 �� SelectedIndex$	 0��5$   	   $��8 0 0 0q�5%   	   $��0q�5&   	   .  (MaterialDesignThemes.Wpf.ColorZoneAssist
   Mode$
 Standard=�5'   	     MaterialDesignPaper.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush# �  5(   	   #���  5)   	   .@�5*      �� $
��DIEU��5+      �� 5,      $��NOIDUNGDIEU��5-      �� 5.      $��KHOAN��5/      �� 50      $��NOIDUNGKHOAN��51      �� 52      $��MUCPHATTREN��53      �� 54      $��MUCPHATDUOI��55      56        57      $ Standard=�58   	   $��8 4 8 4q�59   	      CornerRadius$ 2��5:   	    K� ZIndex$ 1��5;   	   $��16 0 0 0q�5<   	   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5=   	   .��5>      �  � ColumnDefinitions 5?      �� 5@   "   $
��Auto �5A      �� 5B   "   $��* �5C      �� 5D   "   $
��Auto �5E      .+�5G      ��   MaterialDesignToolButton#��[ 5H      .��5I   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�5J       J� Opacity$	 .56Q�5K      5L      �� 5M      -   5         ��Name$ 
search_txt��5M   &   $��1��5N      $��8 0 0 0q�5O      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5P         DecorationVisibility$ Hidden=�5Q      $��0q�5R      $	��200��5S      $��Center=�5T      6(   �� 5U      #��[ 5V      $��2��5W      5Y      5Z      5[      �� 5\       & "MaterialDesignToolForegroundButton#��[ 5]   	   $��8 0 0 0q�5^   	   $ 0��5_   	   5a      5b      5c      5d      &	   System.Windows.Controls.DataGrid	  5e   
   -   5         	 Name$ dataGird��5e       	  AutoGenerateColumns .  $��
0,77,0,-77q�6A   $��2��6U   ��5f      �� 5g       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5h      �  � Color$ Black��6#   � 5i      $ White��6#    � Offset$ 1Q�61   � 5j      $ 	#FF4DB6AC��6#   5k       	  Columns 5m      0
  *System.Windows.Controls.DataGridTextColumn
  5n      ,  &System.Windows.Controls.DataGridColumn   Header$ Điều��6%    
  
FontFamily$ serif)�63      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   ��   �� Path$
  DIEU�
  5o      $ Nội dung điều��6%   $ serif)�6<   $	 100 6O    6[   �� $  NOIDUNGDIEU�
  5p      $ Khoản��6%   $	 100 64   $ serif)�6@    6S   �� $  KHOAN�
  5q      $ Nội dung khoản��6%   $ serif)�6=   $	 100 6P    6\   �� $  NOIDUNGKHOAN�
  5r      $ Mức phạt trên��6%   $ serif)�6<   $	 100 6O    6[   �� $  MUCPHATTREN�
  5s      $ Mức phạt dưới��6%   $ serif)�6<   $	 100 6O    6[   �� $  MUCPHATDUOI�5v      �� 5w   
   -   5        ! ��Name$! add_btn��5w      $��Thêm��6"   $
��Left=�61   $��33��6L   $��
456,19,0,0q�6X   $	��Top=�6l   $��93��6�   ���	#FF00BCD4 " MaterialDesignRaisedDarkButton#��[ 5x      +  %MaterialDesignThemes.Wpf.ButtonAssist"   CornerRadius$" 20��5y      # � ToolTip$7# 1MaterialDesignRaisedDarkButton with Round Corners��5z      �� 5{   
   -   5        $! 
delete_btn��5{      $
��Xóa��6%   $
��Left=�63   $��32��6N   $��
572,20,0,0q�6Z   $	��Top=�6n   $��93��6�   ���	#FF00BCD4#��[ 5|      $" 20��5}      $7# 1MaterialDesignRaisedDarkButton with Round Corners��5~      �� 5   
   -   5        $! 
update_btn��5      $��Sửa��6%   $
��Left=�63   $��32��6N   $��
686,20,0,0q�6Z   $	��Top=�6n   $��93��6�   ���	#FF00BCD4#��[ 5�      $" 20��5�      $7# 1MaterialDesignRaisedDarkButton with Round Corners��5�      5�      5�      
   M S B A M L   `   `   `  ����D  @StockShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:StockShop	StockShop  5   	       StockShop.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:StockShop     5   	   -   5          � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ 
MainWindow��5   	   $	��600��6   $
��1200��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#0272BA$��0q�67   $
��Auto��6B   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��BtnDashWndw��5   N   $��20��6   $��0,0,2,0q�6$   
������ $��0q�6{   $��20��6�   $��Right=�6�   $��Center=�6�   .��5      �� $��/Resource/IconDash.png��6   5      �� 5      -   5        $��
BtnMaxWndw��5   N   $��20��6   $��0,0,2,0q�6$   
������ $��20��6y   $��0q�6�   $��Center=�6�   $��Right=�6�   .��5      �� $��/Resource/IconMaxWndw.png��6   5      �� 5      -   5        $��
BtnExtWndw��5   N   $��20��6   $��0,0,2,0q�6$   
������ $��0q�6y   $��20��6�   $��Right=�6�   $��Center=�6�   .��5      �� $��/Resource/IconExit.png��6   5      5      5       � 5   
   -   5        $��FrmMain��5!      $��1��5        � NavigationUIVisibility$ Hidden=�5       5!      5"      5#      
   M S B A M L   `   `   `  ����>  :STP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:STPSTP  5   	       STP.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:STP     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��900��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $
��6.6* �6   .+�5   
   � $��0��6   ���#6889FF � ColumnDefinitions 5      �� 5      $
��1.5* �6#   �� 5      �� 5      $
��0.8* �6#   �� 5      $
��0.8* �6#   �� 5      $
��0.8* �6#   �� 5      $
��0.2* �6#   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 
�������$��50��5       $��50��5        �� RadiusX$	 100��5        �� RadiusY$	 100��5       $��	20,0,10,0q�5       5!      �� 5"      $��Company name��6    $��20(�5#       
�������$��DemiBold"�5%       $��Center=�5&       $��Center=�5'       5)      5*      5+      � 5,      $��2��6   .+�5-      �� -   5         ��Name$ btn_Manager��5/      
������ 
������ .��51      �� $��Менеджеры��6    $��16(�52       
�������55      56      57      � 58      $��3��6   .+�59      �� -   5        $ 
btn_Client��5;      
������ 
������ .��5=      �� $��Клиенты��6    $��16(�5>       
�������5A      5B      5C      � 5D      $��4��6   .+�5E      �� -   5        $ btn_Product��5G      
������ 
������ .��5I      �� $��Товары��6    $��16(�5J       
�������5M      5N      5O      5P      � 5Q   
   $��1��6   .+�5R       � -   5          �Name$ FRMain��5R      	  � NavigationUIVisibility$	 Hidden=�5S      5U      5V      5W      5X      
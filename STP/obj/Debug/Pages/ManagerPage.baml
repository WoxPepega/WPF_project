   M S B A M L   `   `   `  ����>  :STP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:STP.Pages	STP.Pages  5          STP.Pages.ManagerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:STP.Pages     5        N� Title$  ManagerPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ lv_ManagerList��5      $��Disabled=�5      $��Hidden=�5      $��	85,0,85,0q�5      
������ ��5      �� 5      .R�5      � 5      ��5      �� 5      .R�5      �� $	��225��6"   $	��100��6.   ���#3535$��2q�6O    �� CornerRadius$ 3��6c   ._�5      �  � ColumnDefinitions 5    "   �� 5!   &   �� 5"   &   $��2* �67   .+�5$   "   �� $��0��6,   $��60��5%   ,   $��60��5&   ,    �� RadiusX$	 100��5'   ,    �� RadiusY$	 100��5(   ,   ���#6889FF5+   #   �� 5,   "   $��Center=�6-   $��Center=�5-   -   $��1��5.   -   .+�5/   &   �� ���#353535$��DemiBold"�51   0   $��18(�52   0   $��Center=�53   0   ��5/   0   �� *nameManager+53   0   �� 54   &   $��Менеджер��60   $��Center=�55   0   56   #   57      58      5:      5=      5>      � 5?   
   $��1��6   ���#6889FF 5A      �� 5B      $
��1.3* �6#   �� 5C      .+�5E      � $��0��6   5G      � 5H      $��1��6    5I      �� 5J      $
��0.1* �6'   �� 5K      �� 5L      �� 5M      �� 5N      $
��0.1* �6'   .+�5P      � $��1��6   .+�5Q      �� -   5         ��Name$ btn_addManager��5T      
������ 
�������$��	5,10,5,10q�5S      .��5V      �� $��Добавить��6$   
�������$��16(�5X   $   5Z      5[      5\      � 5]      $��2��6   .+�5^      �� -   5        $ btn_editManager��5a      
������ 
�������$��	5,10,5,10q�5`      .��5c      �� $��Изменить��6$   
�������$��16(�5e   $   5g      5h      5i      � 5j      $��3��6   .+�5k      �� -   5        $ btn_deleteManager��5n      
������ 
�������$��	5,10,5,10q�5m      .��5p      �� $��Удалить��6$   
�������$��16(�5r   $   5t      5u      5v      5w      5x      5y      5z      
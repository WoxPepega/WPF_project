   M S B A M L   `   `   `  ����>  :STP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:STP.WindowsSTP.Windows  5   	   "    STP.Windows.AddManagerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:STP.Windows     5   	     � Title$-  'Добавление менеджера��5   	   $	��450��6&   $	��600��63    � WindowStartupLocation$ CenterScreen=�6?   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��4* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   ���#6889FF.+�5      �� $:��4Добавление нового менеджера��6   
�������$��24(�5      $��Center=�5      $��Center=�5      5      � 5   
   $��1��6    5      �� 5      $
��1.5* �6    �� 5      �� 5      �� 5      $
��1.5* �6    .+�5      �� $��1��6   .+�5      �� $��Введите имя:��6   $
��Left=�5       $��	170,0,0,2q�5!      ���#353535$��14(�5#      5%      �� 5&      -   5         ��Name$ tb_nameManager��50      
�������$��1��5'      $��40��5(      $	��260��5)      
������ $��Center=�5+      $
��Left=�5,      $��10,0,0,0q�5-      ���#353535$��16(�5/      .��50   2    J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52         
BlurRadius$ 20Q�6+      ShadowDepth$ 0Q�53   '      Opacity$	 0.1Q�54   '   .��55   &   56      57      �� 58      -   5         ��Name$ btn_addManager��5<      $��2��58      $��40��59      $	��260��5:      ���#353535.��5>      �� $��Добавить��6   
�������$��16(�5@      5A      5B      � 5C   
   $��2��6   ���#6889FF5F      5G      5H      
   M S B A M L   `   `   `  ����L  HCommandPatternLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CommandPatternLabCommandPatternLab  5   	   "    CommandPatternLab.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CommandPatternLab     5   	     � Title$  CommandPattern��5   	   $	��600��6    $	��450��6-   .��5	      � 
����d� � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ commandCanvas��5      $��0��6(   
�������$	��400��6H   $	��380��6U   .+�5      �� -   5         ��Name$
 rect��5      $	��100��5      $	��100��5      
���   �
���  ��z�5      T� 5      5      5      � 5   
   $��1��6   
����d� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��5q�6#    5      �� 5       �� 5!      �� 5"      .+�5$      �� -   5        $��0��5$      
���  ��
�������.��5'   *   Red6/   �� 5(      -   5        $��1��5(      
��� � �
�������.��5+   ,   Green63   �� 5,      -   5        $��2��5,      
����  �
�������.��5/   +   Blue61   50      � 51      $��1��6    52      �� 53      �� 54      �� 55       57      �� 58      �� 59      �� 5:      .+�5=      �� -   5        $��2��5=      .��5>   3   Run Commands6A   �� 5?      -   5        $��2��5?      .��5@   4   Undo6:   �� 5A      -   5         ��Name$ leftBtn��5A      $��2��5B      .��5C   /   Left65   �� 5D      -	   5        $ rightBtn��5D      $��2��5E      $��2��5F      .��5G   0   Right67   �� 5H      -
   5        $ downBtn��5H      $��3��5I      $��1��5J      .��5K   /   Down65   �� 5L      -   5        $ upBtn��5L      $��1��5M      $��1��5N      .��5O   -   Up61   5P      5Q      5R      5S      
   M S B A M L   `   `   `  ����N  JFINAL_PROJECT_14_06, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FINAL_PROJECT_14_06FINAL_PROJECT_14_06  5      &     FINAL_PROJECT_14_06.PharmacyPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FINAL_PROJECT_14_06     5        N� Title$  PharmacyPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��15 �6   �� 5      $
��188* �6   �� 5      $��9* �6   �� 5      $
��179* �6   �� 5      $��20 �6   �� 5      $
��187* �6   �� 5      $
��188* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��50 �6   �� 5%      $��* �6   .+�5(   
   �� $��Paient Name           :��6   $��1��63   $��3��6C   $��16(�6P   $��Center=�6^   $	��0,9q�6y   �� 5)   
   -   5        $��paientblock��5)      $��2��6'   $��3��67   $��16(�6F   $	��Top=�6T   $��3��6l   $��
0,0,19.5,0q�6�   �� 5+   
   $!��Pharmacist Name           :��6   $��4��67   $��3��6G   $��16(�6T   $��Center=�6b   $��3��6}   $��19.5,9,187.5,9q�6�   �� 5,   
   -   5        $��PharmacistcomboBox��5,      $��6��6.   $��3��6>   $
��Left=�6K   $	��Top=�6f   $	��218��6~   $��36��6�   $��2��6�   $��0.5,0,-15.5,0q�6�   �� 5.   
   $'��!           Visiting  Pharmacy    ��6   $��2��6=   $��1��6M   $��5��6Z   $��25(�6o   $��Center=�6}   $
��Bold"�6�   $��0,8,187.5,8q�6�   �� 5/   
   $��Medicine Details :��6   $��1��6.   $��4��6>   $��16(�6M   $	��Top=�6[   &   System.Windows.Controls.DataGrid  51   
   -   5        $��MedicineDataGrid��51         AutoGenerateColumns .  $��5��52      $��1��6   $��4��6*   $��7��6>   $��
0,0,19.5,0q�6O      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Patient Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *medicineName+ �� Mode$ OneWay=�  55      $ Healthcare #��6%   $ * 6;    6E   �� *	unitPrice+$ OneWay=�4  .System.Windows.Controls.DataGridCheckBoxColumn  56      $ Healthcare #��6)   $ * 6?    6I   �� *needPrescription+$ OneWay=�58      �� 5:   
   -   5        $��PurchaseBtn��5:      $��1��6$   $	��13 ��64   $��Purchase��6C   $��20(�6V   $	��Top=�6d   $	��150��6|   $��30��6�   $
��19,0q�6�   �� 5;   
   -   5        $��DrugInfoBtn��5;      $��3��6$   $	��13 ��64   $��DrugInfo��6C   $��20(�6V   $	��Top=�6d   $	��150��6|   $��30��6�   $��10,0,18.5,0q�6�   �� 5=   
   -   5        $��ExitPharmacyBtn��5=      $��5��6(   $	��13 ��68   $��2��6G   $��Exit Pharmacy��6[   $��30(�6s   $	��Top=�6�   $	��250��6�   $��50��6�   
��� � �$��61.5,0,63.5,0q�6�   6�   5@      5A      
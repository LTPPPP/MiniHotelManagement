   M S B A M L   `   `   `  ����  Assignment02/    )Assignment02.Views.Admin.ManageReportPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Manage Report Page��5       N� 
Background
 �����.��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��2* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   .+�5   
   �� $��36(�6   $
��Bold"�6"   $��Center=�64   $��Center=�6Q   $��0��6l   $��2��6y   REPORT6�   �� 5   
   $	��250��6   $��1��6!   $��0��6.   $	��Top=�6>   $��20q�6V   .+�5      �� $��16(�6   .��6"   
Start Date6.   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ startDatePicker��5         SelectedDate 62   �� *	startDate+ �� Mode$ TwoWay=�5      �� 5   
   $	��250��6   $��1��6!   $��0��6.   $��Center=�6>   $��20q�6Y   .+�5      �� $��16(�6   .��6"   
End Date6,     5      -   5        $ endDatePicker��5       60   �� *	endDate+$ TwoWay=�5      �� 5!   
   -   5         ��Name$ 	createBtn��5"      $��1��5!      $��1��6   $��Center=�6.   $��Center=�6K   $	��200��5"   <   $��50��6H   $��18(�6T   $��20q�6b   .��6n   CREATE REPORT5$      5%      5&      
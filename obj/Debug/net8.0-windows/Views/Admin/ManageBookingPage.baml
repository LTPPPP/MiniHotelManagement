   M S B A M L   `   `   `  ����G  CAssignment02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assignment02.UtilitiesAssignment02.Utilities  5   D   0    *Assignment02.Views.Admin.ManageBookingPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Assignment02.Utilities     6D     N� Title$  Manage Booking Page��5       N� 
Background
 ����� � 	Resources 5	      ,   &Assignment02.Utilities.StatusConverter   StatusConverter��%   &	          5
   
   6    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��7* �6   6,   �� 5      $��3* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6l   ��6   �� *Books+ �� SelectedItem 61   �� *SelectedItem+ �� Mode$ OneWayToSource=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ BookingReservationId��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6C   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6P   �� *BookingReservationId+6{     5      $ BookingDate��6%   $
	 auto 6:   
 6G   �� *BookingDate+6i     5      $ 
TotalPrice��6%   $
	 auto 69   
 6F   �� *
TotalPrice+6g     5      $ CustomerFullName��6%   $
	 auto 6?   
 6L   �� *Customer.CustomerFullName+6|     5      $ BookingStatus��6%   $
	 auto 6<   
 6I   �� *BookingStatus+ �� 	Converter# [  6�   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $��7* �6    6.   �� 5      $��3* �6    6.   .+�5      �  5       �� 5!      $��* �6$   61   �� 5"      $��* �6$   61   �� 5#      $��* �6$   61   �� 5$      $��* �6$   61   �� 5%      $��* �6$   61   �� 5&      $��* �6$   61   .+�5(      �� $��0��6   .+�5)      �� .��6   ID6    �� 5*      ${�False��6Y   ��6   �� *NewItem.BookingReservationId+$ TwoWay=�6m   5+      �� 5,      $��1��6   .+�5-      �� .��6   Room Number6)   �� 5.       �� DisplayMemberPath$ 
RoomNumber��6=    �� SelectedValuePath$ RoomId��6\   ��6   �� *Rooms+ �� SelectedValue 6w   �� *Details.RoomId+$ TwoWay=�6�   5/      �� 50      $��2��6   .+�51      �� .��6   
Start Date6(   (  "System.Windows.Controls.DatePicker  52         Text 6!   �� *Details.StartDate+$ TwoWay=�6S   53      �� 54      $��3��6   .+�55      �� .��6   
End Date6&     56       6!   �� *Details.EndDate+$ TwoWay=�6Q   57      �� 58      $��4��6   .+�59      �� .��6   Total Price6)   �� 5:      ��6   �� *NewItem.TotalPrice+$ TwoWay=�6Q   5;      �� 5<      $��5��6   .+�5=      �� .��6   
Customer6&   �� 5>      $ CustomerFullName��6A   $ 
CustomerId��6�   ��6   �� *	Customers+ 6f   �� *NewItem.CustomerId+6�   5?      5@      � 5A      $��1��6   .+�5B      A�  A� Columns$ 1��6   .+�5C      �� $	��ADD��6<   ��6   �� *
AddCommand+6<   �� 5D      $��UPDATE��6?   ��6   �� *UpdateCommand+6?   �� 5E      -   5         ��Name$ 	detailBtn��5E   ?   $��DETAIL��6R   ��6   �� *DetailCommand+6c   �� 5F      $��DELETE��6?   ��6   �� *DeleteCommand+6?   5G      5H      5J      5K      5L      
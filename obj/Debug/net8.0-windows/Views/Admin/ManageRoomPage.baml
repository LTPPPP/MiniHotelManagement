   M S B A M L   `   `   `  ����G  CAssignment02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assignment02.UtilitiesAssignment02.Utilities  5   D   -    'Assignment02.Views.Admin.ManageRoomPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Assignment02.Utilities     6D     N� Title$  Manage Room Page��5       N� 
Background
 ����� � 	Resources 5	      ,   &Assignment02.Utilities.StatusConverter   StatusConverter��%   &	          5
   
   6    5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��6* �6   6*   �� 5      $��9* �6   6*   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6d   $��10q�6�   ��6   �� *Rooms+ �� SelectedItem 61   �� *SelectedItem+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ RoomId��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *RoomId+6_     5      $ Room Number��6%   $
	 auto 6Y   
 6:   �� *
RoomNumber+6h     5      $ Description��6%   $
	 auto 6d   
 6:   �� *RoomDetailDescription+6s     5      $ Capacity��6%   $
	 auto 6[   
 67   �� *RoomMaxCapacity+6j     5      $ 
RoomTypeID��6%   $
	 auto 6X   
 69   �� *
RoomTypeId+6g     5      $ RoomTypeName��6%   $
	 auto 6e   
 6;   �� *RoomType.RoomTypeName+6t     5      $ 	Price/Day��6%   $
	 auto 6\   
 68   �� *RoomPricePerDay+6k     5      $ Status��6%   $
	 auto 6�   
 65   �� *
RoomStatus+ �� 	Converter# [  6�   5      � 5!   
   $��1��6   $��10q�6    � ColumnDefinitions 5"      �� 5#      $
��1.5* �6#   62   �� 5$      $
��1.5* �6#   62   �� 5%      $��2* �6#   60   �� 5&      $��2* �6#   60    5)      �� 5*      $��* �6    6-   �� 5+      $��* �6    6-   �� 5,      $��* �6    6-   .+�50      �� $	��150��6   $��0��6%   $��0��62   .+�51      �� .��6   ID6   �� 52      -   5         ��Name$ idTxt��52      ${�False��6I   ��6)   �� *NewItem.RoomId+6I   53      �� 56      $	��150��6   $��0��6%   $��1��62   .+�57      �� .��6   Room Number6%   �� 58      -   5        $ roomNumberTxt��58      ��61   �� *NewItem.RoomNumber+59      �� 5<      $��0��6   $��2��6&   $	��300��66   $��2��6B   .+�5=      �� .��6   Description6%   �� 5>      -   5        $ descriptionTxt��5>       �� TextWrapping$
 Wrap=�6a    �� AcceptsReturn$
 True��6u   " �� VerticalScrollBarVisibility$
 Auto=�6�   $	��100��6�   ��62   �� *NewItem.RoomDetailDescription+6�   5?      �� 5B      $	��150��6   $��1��6%   $��0��62   .+�5C      �� .��6   Max Capacity6&   �� 5D      -   5        $ capacityTxt��5D      ��6/   �� *NewItem.RoomMaxCapacity+5E      �� 5H      $	��150��6   $��1��6%   $��1��62   .+�5I      �� .��6   Room Type Name6(   �� 5J       �� DisplayMemberPath$ RoomTypeName��6=    �� SelectedValuePath$ 
RoomTypeId��6^   ��6   �� *	RoomTypes+ �� SelectedValue 6}   �� *NewItem.RoomTypeId+$ TwoWay=�5K      �� 5N      $	��150��6   $��2��6%   $��0��62   .+�5O      �� .��6   Price per day6'   �� 5P      -   5        $ priceTxt��5P      ��6,   �� *NewItem.RoomPricePerDay+5Q      �� 5T      $	��150��6   $��2��6%   $��1��62   .+�5U      �� -   5         ��Name$ statusComboBox��5U       5V      �� *NewItem.RoomStatus+$ TwoWay=�# [  .@�5W      �� $��	Available��6#   �� 5X      $��Booked��6#   5Y      5[      �� 5_      $��1��6   $��2��6&   $��2��66   $��Center=�6J    �� Orientation$ 
Horizontal=�6g   .+�5`      �� -   5         ��Name$ addBtn��5`      $	��ADD��6)   $��80��67   $��30��6B   $��5q�6N   ��6Y   �� *
AddCommand+�� 5a      -   5        $ 	updateBtn��5a      $��UPDATE��6,   $��80��6=   $��30��6H   $��5q�6T   ��6_   �� *UpdateCommand+�� 5b      -	   5        $ 	deleteBtn��5b      $��DELETE��6,   $��80��6=   $��30��6H   $��5q�6T   ��6_   �� *DeleteCommand+5c      5e      5f      5g      
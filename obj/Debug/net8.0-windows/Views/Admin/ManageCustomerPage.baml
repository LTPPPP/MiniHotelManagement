   M S B A M L   `   `   `  ����G  CAssignment02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assignment02.UtilitiesAssignment02.Utilities  5   D   1    +Assignment02.Views.Admin.ManageCustomerPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Assignment02.Utilities     6D     N� Title$  Manage Customer Page��5       N� 
Background
 ����� � 	Resources 5
      ,   &Assignment02.Utilities.StatusConverter   StatusConverter��%   &	          5   
   6    5      .��5      �  � RowDefinitions 5   
   �� 5      $��6* �6   6*   �� 5      $��9* �6   6*   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6p   ��6   �� *	Customers+ �� SelectedItem 65   �� *SelectedItem+ �� Mode$ OneWayToSource=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
CustomerId��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 6X   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *
CustomerId+6X     5      $ 	Full Name��6%   $
	 auto 6]   
 68   �� *CustomerFullName+6]     5      $ 	Telephone��6%   $
	 auto 6V   
 68   �� *	Telephone+6V     5      $ Email��6%   $
	 auto 6U   
 64   �� *EmailAddress+6U     5      $ Birthday��6%   $
	 auto 6\   
 67   �� *CustomerBirthday+6\     5      $ CustomerStatus��6%   $
	 auto 6`   
 6=   �� *CustomerStatus+6`   5      � 5    
   $��1��6   $��10q�6    � ColumnDefinitions 5!      �� 5"      $��3* �6#   �� 5#      $��1* �6#   .+�5&      �� $��Customer Details��6   $��14(�61   $��10q�6?   $��0��6L   .��5'      �  5(      �� 5)      $��* �6+   �� 5*      $��* �6+    5,      �� 5-      $
��Auto �6(   �� 5.      $
��Auto �6(   �� 5/      $
��Auto �6(   .+�52      �� $��0��6!   $��0��61   $
��10,5q�6>   .+�53      �� .��6    
CustomerId6,   �� 54      -   5         ��Name$ idTxt��54   "   ${�False��6U   ��61   �� *NewItem.CustomerId+6U   55      �� 57      $��1��6!   $��0��61   $
��10,5q�6>   .+�58      �� .��6    	Full Name6+   �� 59      -   5        $ fullNameTxt��59   "   ��67   �� *NewItem.CustomerFullName+5:      �� 5<      $��0��6!   $��1��61   $
��10,5q�6>   .+�5=      �� .��6    	Telephone6+   �� 5>      -   5        $ telephoneTxt��5>   "   ��68   �� *NewItem.Telephone+5?      �� 5A      $��1��6!   $��1��61   $
��10,5q�6>   .+�5B      �� .��6    Email6'   �� 5C      -   5        $ emailTxt��5C   "   ${�False��6Z   ��64   �� *NewItem.EmailAddress+6Z   5D      �� 5G      $��0��6!   $��2��61   $
��10,5q�6>   .+�5H      �� .��6    	Birthdate6+   (  "System.Windows.Controls.DatePicker  5I         Text 6%   �� *NewItem.CustomerBirthday+ �� StringFormat$ {0:MM/dd/yyyy}��$ TwoWay=�5J      5M      5N      �� 5Q      $��1��6   $��Center=�6)   $��Center=�6D   $
��20,0q�6a   $	��150��6o   .+�5R      �� -   5         ��Name$ addBtn��5R      $��10q�6)   $��30��65   ��6A   �� *
AddCommand+.��6`   ADD6e   �� 5S      -   5        $ 	updateBtn��5S      $��10q�6,   $��30��68   ��6D   �� *UpdateCommand+.��6f   UPDATE6n   �� 5T      -   5        $ 	deleteBtn��5T      $��10q�6,   $��30��68   ��6D   �� *DeleteCommand+.��6f   DELETE6n   5U      5V      5W      5X      
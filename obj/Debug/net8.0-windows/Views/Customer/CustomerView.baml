   M S B A M L   `   `   `  ����  Assignment02.    (Assignment02.Views.Customer.CustomerView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Customer View��5   	   $	��500��6   $	��900��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   
�������.��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   ���#3B5998 �� Padding$ 10q�63    �� CornerRadius$ 5��6@   $��0,0,0,10q�6Q   ._�5      ]� .+�5      �� $��Customer View��6   $��24(�61   $
��Bold"�6?   
�������$��Center=�5      $��Center=�69   $��Right=�6T   $��20q�6k   �� 5       �� Orientation$ 
Horizontal=�6   $
��Left=�66   $
��Left=�6Q   $��10,0,0,0q�6g   .+�5      �� -   5         ��Name$ 
profileBtn��5      $��Profile��61   $��80��6\   $��5q�6g   ���#5B9BD5
�������$��SemiBold"�5   E   �� 5      -   5        $ 
bookingBtn��5      $��Booking History��61   $	��120��6d   $��5q�6p   ���#5B9BD5
�������$��SemiBold"�5   E   �� 5      -   5        $ 	logoutBtn��5      $��Logout��60   $��80��6Y   $��5q�6d   ���#D9534F
�������$��SemiBold"�5   E   5      5      5        � 5#   
   -   5          �Name$ customerFrame��5#      $��1��6'   	  � NavigationUIVisibility$	 Hidden=�64   
����������#DDDDDD$��1q�6}   5$      5%      
   M S B A M L   `   `   `  ����G  CAssignment02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Assignment02.Views.AdminAssignment02.Views.Admin  5   	   (    "Assignment02.Views.Admin.AdminView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Assignment02.Views.Admin     5   	     � Title$  
Admin View��5   	   $	��700��6   $	��900��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   
�������.��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   ���#3B5998 �� Padding$ 15q�63    �� CornerRadius$ 5��6@   $��0,0,0,10q�6Q   ._�5      ]� .+�5      �� $��
Admin View��6   $��16(�6.   $
��Bold"�6<   
�������$��Center=�5      $��Center=�69   $
��Left=�6T   $��10,0,5,0q�6j   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   $��Right=�6R   $��0,0,5,0q�6i   .+�5      �� -   5         ��Name$ customerBtn��5      $��Manage Customer��62   $	��150��5      $��40��6)   $��5q�65   ���#5B9BD5
�������$��SemiBold"�6h   �� 5      -   5        $ roomBtn��5      $��Manage Room��6.   $	��150��5      $��40��6)   $��5q�65   ���#5B9BD5
�������$��SemiBold"�6h   �� 5      -   5        $ 
bookingBtn��5      $��Manage Booking��61   $	��150��5      $��40��6)   $��5q�65   ���#5B9BD5
�������$��SemiBold"�6h   �� 5       -   5        $ 	reportBtn��5       $��Manage Report��60   $	��150��5!      $��40��6)   $��5q�65   ���#5B9BD5
�������$��SemiBold"�6h   �� 5"      -   5        $ 	logoutBtn��5"      $��Logout��60   $	��100��5#      $��40��6)   $��5q�65   ���#D9534F
�������$��SemiBold"�6h   5$      5%      5&       � 5)   
   -   5          �Name$ 
adminFrame��5)      $��1��6$   	  � NavigationUIVisibility$	 Hidden=�61   
����������#DDDDDD$��1q�6z   $��10q�6�   5*      5+      
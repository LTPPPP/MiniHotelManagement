   M S B A M L   `   `   `  ����G  CAssignment02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Assignment02.UtilitiesAssignment02.Utilities  5   	       Assignment02.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   BpasswordBoxHelper$clr-namespace:Assignment02.Utilities     5   	     � Title$  LOGIN��5   	   $	��600��6   $	��800��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F   ���#FAFAFA.��5
      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   �� $��LOGIN��6   $��0��6!   $��Center=�6.   $��Bottom=�6K   $��36(�5      $
��Bold"�6"   ���#333$��0,0,0,20q�6F   �� 5   
   $��1��6   $��Center=�6"   $	��300��6?   $��Center=�6K   .+�5      �� .+�5      �� $��Email��6   $
��Bold"�6(   ���#5556:   �� 5      -   5         ��Name$ emailTxt��5      $��8q�6P   
���**��$��1q�6p   
���������6,   �� *Email+ �� Mode$ TwoWay=�6�   5      �� 5      .+�5       �� $��Password��6   $
��Bold"�6+   ���#5556=   G� 5!      -   5         G�Name$ passTxt��5!      $��8q�5"      
���**��$��1q�6>   
�������.   (Assignment02.Utilities.PasswordBoxHelper   BoundPassword 5!   /   �� *
Password+$ TwoWay=�5"   R   5#      5$      �� 5'   
   $��2��6   $��Center=�6"   $	��Top=�6?   .+�5(      �� -   5         ��Name$ loginBtn��5(      $��LOGIN��6'   $	��150��67   $��40��6C   ���#3B5998
�������$
��Bold"�5)   =   $��16(�6O   $��0q�5*      $��0,20,0,0q�6)   	 � Cursor$
	 Hand��6;   5+      5,      5-      
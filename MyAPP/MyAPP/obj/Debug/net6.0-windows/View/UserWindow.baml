   M S B A M L   `   `   `  ����@  <MyAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyAPP.View
MyAPP.View  5   	       MyAPP.View.UserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyAPP.View     5   	   -   5        $��UserWnd��5	   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� -   5         ��Name$ ViewCurrentOrders��5   #   $��1��6   ��6>   �� *AllCurrentOrders+ �� SelectedItem 6g   �� *SelectedOrder+ � ContextMenu 5      �� 5      .@�5      m� $!��Отменить заказ��6    m� Command 67   �� *CancelOrder+5       �� View 5      �� 5      .P�5      �� $��ORDER��6%    �� DisplayMemberBinding 5   -   ��  �� Path$ Id��� 5      $
��NAME��6%    5   -   �� $ notebook.Name��� 5      $
��TYPE��6%    5   -   �� $ notebook.Type��� 5      $��PRICE��6%    5   -   �� $ notebook.Price��� 5      $��IMAGE��6%   	 �� CellTemplate	 5       �� 5!      .R�5"   "   �� $��60��6X   $��60��6c   ��6(   �� $ notebook.NoteImage.Data�6c   5#      5%      5&      5(      �� 5)   
   .+�5*      �� -   5        
 ��Name$

 User��5*   6      User#���   6   66   �� 5+      ��6   �� *Login+�� 5,      -   5        $
 RegistrationDate��5,   B     RegistrationDate#���  6   6B   �� 5-      ��6   �� *	Created+�� 5.      -   5         ��Name$ Support��5.   w     Support#���  6   $��UserWnd��6\   ��69   �� *OpenSupportWnd+6w   5/      50      51      
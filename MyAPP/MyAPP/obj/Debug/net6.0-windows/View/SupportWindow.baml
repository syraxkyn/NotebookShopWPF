   M S B A M L   `   `   `  ����@  <MyAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyAPP.View
MyAPP.View  5   	       MyAPP.View.SupportWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyAPP.View     5   	   -   5        $��
SupportWnd��5	   	     � Title$  SupportWindow��5   	   $	��300��6   $	��300��6,   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6"   $��Center=�5      $��Center=�5      $	��200��5      .+�5      �� $��Введите email��6   �� 5      -   5        $��	MailBlock��5   U    �� AcceptsReturn$
 True��6,    �� TextWrapping$
 Wrap=�6A   ��6   �� *Mail+6U   �� 5      $%��Опишите проблему��6   �� 5      -   5        $��MessageBlock��5   \   $
 True��63   $
 Wrap=�6H   ��6   �� *MailMessage+6\   5      �� 5   
   $��1��6   $��Отправить��6   ��62   �� *SendMessage+��5      ��  �� ElementName$ 
SupportWnd��5      5      
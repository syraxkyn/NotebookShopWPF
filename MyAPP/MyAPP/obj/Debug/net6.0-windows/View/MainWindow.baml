   M S B A M L   `   `   `  ����@  <MyAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyAPP.View
MyAPP.View  5   	   1clr-namespace:MyAPP.ViewModelMyAPP.ViewModel  60       MyAPP.View.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyAPP.View     5   	   3	viewmodelclr-namespace:MyAPP.ViewModel     60   -   5        $��MainWnd��5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � AllowsTransparency$
 True��65    � WindowStyle$
 None=�6O    � 	Resources 5
      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6    �� SelectedItem 6"   �� *SelectedTabItem+.@�5      �� -   5        $��UsersTab��5      ��5      �� 5      $��Users��6    .��5      �� -   5         ��Name$ ViewAllUsers��5      ��61   �� *
AllUsers+ �� View 5      �� 5      .P�5      �� $��ID��6-    �� DisplayMemberBinding 5   -   �� 	 �� Path$	 Id��� 5      $��LOGIN��6-    5   -   �� $	 Login��� 5      $��PASSWORD��6-    5   -   �� $	 Password��� 5       $��CREATED��6-    5!   -   �� $	 Created�5"      5$      5%      �� 5&      -   5        $��NotebooksTab��5&      ��5'      �� 5(      $��	Notebooks��6    
 � ContextMenu
 5*      �� 5+      .@�5,      m� $"��Редактирование��6#    m� Command 6;   �� *OpenEditItemWnd+m� 5-      $��Удалить��6#    64   �� *
DeleteItem+5.      .��50      �� -   5        $ ViewAllNotebooks��50      ��65   �� *AllNotebooks+ 51      �� *SelectedNotebook+ 52      �� 53      .P�54      �� $��ID��6-    55   -   �� $	 Id��� 56      $
��NAME��6-    57   -   �� $
	 Name��� 58      $
��TYPE��6-    59   -   �� $
	 Type��� 5:      $��PRICE��6-    5;   -   �� $	 Price��� 5<      $��IMAGEID��6-    5=   -   �� $	 NoteImage.Id��� 5>      $��IMAGE��6-    �� CellTemplate 5?   "   �� 5@   &   .R�5A   *   �� $��60��6W   $��60��6b   ��60   �� $	 NoteImage.Data�6b   5B   '   5D      5E      5G      5H      �� 5I      -   5        $��	OrdersTab��5I      ��5J      �� 5K      $��Orders��6    .��5M      �� -   5        $ ViewAllOrders��5M      ��62   �� *	AllOrders+ 5N      �� 5O      .P�5P      �� $��ID��6-    5Q   -   �� $	 Id��� 5R      $��NOTEBOOK ID��6-    5S   -   �� $	 
NotebookId��� 5T      $��USER ID��6-    5U   -   �� $	 UserId�5V      5X      5Y      �� 5Z      -   5        $��SupportsTab��5Z      ��5[      �� 5\      $��Support List��6    .��5^      �� -	   5        $ ViewAllSupports��5^      ��64   �� *AllSupports+ 5_      �� 5`      .P�5a      �� $��ID��6-    5b   -   �� $	 Id��� 5c      $
��MAIL��6-    5d   -   �� $
	 Mail��� 5e      $��CONTEXT��6-    5f   -   �� $	 Content��� 5g      $��CREATED��6-    5h   -   �� $	 Created�5i      5k      5l      5m      �� 5n   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�5o      .+�5p      �� $��Новый ноутбук��6   ��6-   �� *OpenAddNewNotebookWnd+�� 5q      -
   5        $
��Exit��5q      $��
Выход��6!   ��61   �� *ExitMainWnd+��5r      ��  �� ElementName$ MainWnd��5s      5t      5u      
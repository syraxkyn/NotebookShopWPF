   M S B A M L   `   `   `  ����@  <MyAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyAPP.View
MyAPP.View  5   	       MyAPP.View.MyView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MyAPP.View     5   	   -   5        $��	MyViewWnd��5	   	     � Title$  MyView��5   	   $	��450��6   $	��800��6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� ���	#FF0C2FEF$��1q�6)   $��0��6=   $��0q�6M   ._�5      �� $��0��6   .+�5      �� -   5         ��Name$ SortByPrice��5   b      SortByPrice#���   6   ��6A   �� *SortNotebook+6b   �� 5      -   5        $ Account��5   �     Account#���  6   ��6=   �� *OpenUserWnd+��6]   ��  �� ElementName$ 	MyViewWnd��6�   �� 5      -   5        $ Reviews��5   �     Reviews#���  6   ��6=   �� *OpenReviewsWnd+��6`   �� $ 	MyViewWnd��6�   �� 5      -   5        $ SearchByPrice��5   g     SearchNotebook#���  6   ��6D   �� *SearchNotebook+6g   �� 5      ��6   �� *
Notebook+�� 5      -   5        $ ResetFilters��5   ;     ResetFilters#���  6Q   ��6   �� *ResetFilters+6Q   �� 5      -   5        $
 Exit��5        Exit#���  6'   ��6H   �� *ExitMainWnd+��5      �� $ 	MyViewWnd���� 5      -   5        $��40��5      $��60��5      ���#272537$��1��5      $��	80 30 0 0q�5      $��0q�5       � Cursor$
 Hand��5    '   
 � Tag$ en-US��5!      .��5"      �� $K��EC:\\Users\андрей\source\repos\MyAPP\MyAPP\Resources\Russia1.png��6   5#      �� 5$      -	   5        $��40��5%      $��60��5&      ���#272537$��1��5(      $��-80,-40,0,0q�5)      $��0q�5+      $ ru-RU��5,      $
 Hand��6   .��5-      �� $K��EC:\\Users\андрей\source\repos\MyAPP\MyAPP\Resources\America.png��6   5.      5/      50      �� 51   
   -
   5         ��Name$ ViewAllNotebooks��51   "   $��1��6   ��6<   �� *AllNotebooks+ �� SelectedItem 52      �� *SelectedNotebook+ � ContextMenu 53      �� 54      .@�55      m� $��Купить��6   	 m� Command	 6/   �� *BuyNotebook+56      ��58      �� 59      .R�5:      � 
 � Orientation$
 
Horizontal=�6    $��Center=�69   6X   5;      ��5=      �� 5>      .R�5?      �� $��5q�6!   .+�5@      �� $��18(�6$   ��62   ��  �� Path$
 Name��� 5A      ��6$   �� $
 Type��� 5B      ��6$   �� $ Price��� 5C      $	��100��6G   $	��100��6S   ��6    �� $ NoteImage.Data�6S   5D      5E      5G      5H      5I      
   M S B A M L   `   `   `  ����I  EMulitipleViews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MulitipleViews.ViewsMulitipleViews.Views  5      &     MulitipleViews.Views.ClothesView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MulitipleViews.Views     5      $	��653��5      $
��1002��6,     � DataContext  5      �� 5	   
    �� RelativeSource 6   �� *Self+.��5      � 
�������$��	136,0,0,2q�6"    � ColumnDefinitions 5   
   �� 5      $
��209* �6   �� 5      $��5* �6   �� 5      �� 5      $
��218* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   $	��285��6*   �� 5      �� 5      $
��Auto �6   $	��157��6*   .+�5   
   �� -   5        $��LeftListBox��5   '   $��39,44,84,35q�6   $��1��6^   ��6:   �� *clothesList+6^   �� 5   
   $��
27,27,0,66q�6   $
��Left=�6)   $	��766��6D   $��4��6P   .+�5      �� -   5         ��Name$ articleTypeCb��5      $��1��6.   $��39,18,530,0q�6;   $��0��6P   $	��Top=�6`   $��34��6x    �� 
IsEditable$
 True��6�   .@�5      �� $��Trousers��6   �� 5       $��Shirts��6   �� 5!      $��Jackets��6   5"      �� 5$      -   5        $ articlesizeCb��5$      $��1��6.   $��39,18,530,0q�6;   $��0��6P   $	��Top=�6`   $��34��6x   $
 True��6�   .@�5%      �� $��Select Size��6   �� 5&      $��S��6   �� 5'      $��M��6   �� 5(      $��L��6   �� 5)      $��XL��6   5*      �� 5,      -   5        $ genderCb��5,      $��1��6)   $��39,18,530,0q�66   $��0��6K   $	��Top=�6[   $��34��6s   $
 True��6   .@�5-      �� $��Select Gender��6   �� 5.      $
��Male��6   �� 5/      $��Female��6   �� 50      $
��Kids��6   51      52      �� 55   
   -   5         ��Name$ txtbox1��55   �   $
��Left=�6   $��80,0,0,0q�6-    �� TextWrapping$
 Wrap=�6?   $��Center=�6S   $	��289��6n   $��48��6z   $��3��6�   6�   �� 56   
   -   5        $ txtbox2��56   �   $
��Left=�6   $��
83,209,0,0q�6-   $
 Wrap=�6A   $��TextBox��6U   $	��Top=�6d   $	��289��6|   $��47��6�   $��3��6�   6�   �� 57   
   -   5        $ txtbox3��57   �   $��
88,11,61,0q�6   $��1��6&   $
 Wrap=�63   $��TextBox��6G   $	��Top=�6V   $��41��6n   $��3��6z   6�   �� 59   
   -   5         ��Name$ savebtn��59   �   $	��Add��6   $
��Left=�6   $��
260,99,0,0q�6:   $��1��6N   $	��Top=�6[   	 J� RenderTransformOrigin$	 7.637,-4.188&�6t   $��69��6�   $��40��6�   $��3��6�   6�   �� 5:   
   -	   5        $��Donate��5:      $
��Left=�6"   $��110,102,0,0q�6=   $��1��6R   $	��Top=�6_   $��35��6w   $��69��6�   $��3��6�   6�   5<      5=      
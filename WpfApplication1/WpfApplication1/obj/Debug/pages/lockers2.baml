   M S B A M L   `   `   `  ����  WpfApplication1$    WpfApplication1.pages.lockers2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  lockers2��5      .��5
      (�  (� Stretch$
 Fill=�6   .��5   
   � $
��1366��6   $	��768��6   ��5      �� 5       �� ImageSource$ /images/locker.jpg��6    � 	Resources 5         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding	 �� CornerRadius
 �� Triggers P� Property P� Value �� 
TargetName��%  &	        �� 5      " ��6.   .�5      ��  �@�OverridesDefaultStyle . 6>   �� 5       � ��$ 5q�6/   �� 5       � �� 5      �� 5      " ��6.   .R�5   "   �� $��border��6)   $	��0.1q�5      $	 4,2q�5      
�������$	 3��5      #��z��5      ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   
 5    "   P� 5!   &    �@J�IsMouseOver . . �5"   *   �� $ border��61    � ��
 �����6\   5#   '   5%      5'      5(      5)      .+�5-      �� $
��Left=�6   $	��141��6/   $��	330,0,0,0q�6<   $	��Top=�6O   $	��239��6g   $��/images/heater.png��6s   $
��Fill=�6�   �� 5.      -   5         ��Name$ heaterstatus��5.      $	��OFF��6*   $
��Left=�68   $��
435,56,0,0q�6S   $	��Top=�6g   $��14(�6   $
��Bold"�6�   
���  ��$��37��6�   ���	#FF4197FF$��26��6�   �� 5/      -   5         ��Name$ 	heaterbtn��5/      #��[  6(   $
��Left=�6O   $��
322,33,0,0q�6j   $	��Top=�6~   $	��257��6�   $��75��6�    � ToolTip$ Θερμοσίφωνας��6�    � Cursor$
 Hand��6�   ��50      �� 51      53      �� 55      $
��Left=�6   $��89��6/   $��	10,19,0,0q�6;   $	��Top=�6N   $	��136��6f   $��/images/fan.jpg��6r   $
��Fill=�6�    J� RenderTransformOrigin$ 1.454,1.743&�6�   r� 56      -   5         r�Name$	 fan��56       r� UnloadedBehavior$ Manual=�6D    r� Source$ ../../images/fan.gif?�6^   $
��Left=�6|   $��89��6�   $��	10,19,0,0q�6�   $	��Top=�6�   $	��136��6�    r� Stretch$
 Fill=�6�    K� ZIndex$ 1��6�   $y�Hidden=�6�   �� 57      -   5        $ fanbtn��57      #��[  6%   $
��Left=�6L   $��0,10,0,0q�6g   $	��Top=�6y   $	��165��6�   $	��107��6�   $ Εξαερισμός��6�   $
 Hand��6�   $ 2��6�   ��58      �� 59      5;      �� 5=      $
��Left=�6   $	��438��6/   $��630,144,0,0q�6<   $	��Top=�6Q   $	��199��6i   $��/images/customer7.png��6u   �� 5>      -   5         ��Name$ 
groupboxc7��5>      $��GroupBox��6+   $
��Left=�6=   $��771,-12,0,0q�6X   $	��Top=�6m   $	��595��6�   $	��278��6�   $y�Hidden=�6�   $��0q�6�   ��6�   Z� ��6�   Z� .��5?      � .+�5@      �� $
��Left=�6   $	��Top=�67   $	��573��6O   $	��246��6[   $��/images/dialogcloud.png��6h   $
��Fill=�6�   �� 5A      -   5        $ lblc7��5A      $&�� Να σε ρωτήσω κάτι;��6+   $
��Left=�6H   $��	50,43,0,0q�6c   $	��Top=�6v   $	��436��6�   $��68��6�   $��22(�6�   $��Center=�6�   �� 5B      -   5        $ c7btn��5B      $��Βεβαίως!��6,   $
��Left=�6?   $��230,118,0,0q�6Z   $	��Top=�6o   $��75��6�   6�   5C      5D      �� 5F      $
��Left=�6   $	��482��6/   $��	0,286,0,0q�6<   $	��Top=�6O   $	��579��6g   $��/images/customer8.png��6s   �� 5G      -   5        $ 
groupboxc8��5G      $��GroupBox��6+   $
��Left=�6=   $��351,146,0,0q�6X   $	��Top=�6m   $	��595��6�   $	��278��6�   $y�Hidden=�6�   $��0q�6�   ��6�   Z� ��6�   Z� .��5H      � .+�5I      �� $
��Left=�6   $	��Top=�67   $	��573��6O   $	��246��6[   $��/images/dialogcloud.png��6h   $
��Fill=�6�   �� 5J      -	   5        $ lblc8��5J      $(��"Να ζητήσω μια χάρη;��6+   $
��Left=�6I   $��	50,43,0,0q�6d   $	��Top=�6w   $	��436��6�   $��68��6�   $��22(�6�   $��Center=�6�   �� 5K      -
   5        $ c8btn��5K      $��Βεβαίως!��6,   $
��Left=�6?   $��230,118,0,0q�6Z   $	��Top=�6o   $��75��6�   6�   5L      5M      �� 5O      -   5        $ toExercise2btn��5O      $,��&Προς Χώρο Εκγύμνασης��6-   $
��Left=�6L   $��
35,653,0,0q�6g   $	��Top=�6{   $	��144��6�   ���	#FF00DCDC$
 Hand��6�   6�   �� 5P      -   5        $ 
toPool2btn��5P      $��Προς Πισίνα��6)   $
��Left=�6?   $��
35,678,0,0q�6Z   $	��Top=�6n   $	��144��6�   ���	#FF00DCDC$
 Hand��6�   6�   �� 5Q      -   5        $ 	toBar2btn��5Q      $��Προς Μπαρ��6(   $
��Left=�6<   $��
35,703,0,0q�6W   $	��Top=�6k   $	��144��6�   ���	#FF00DCDC$
 Hand��6�   6�   5S      5T      5U      
   M S B A M L   `   `   `  ����  WpfApplication1%    WpfApplication1.help.pool2_help   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  
pool2_help��5      .��5
      (�  (� Stretch$
 Fill=�6   .��5   
   � -   5         �Name$ pool2_hgrid��5      $
��1366��6$   $	��768��61   ��5      �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ /images/pool1.jpg��6,    j� 
AlignmentY$	 Top=�6L    j� 
AlignmentX$ Center=�6]    � 	Resources 5         MyButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� Padding �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName��%  &	        �� 5      " ��6.   .�5      �� 	 �@�OverridesDefaultStyle
 . 6>   �� 5      	 � ��$
 5q�6/   �� 5      	 � ��
 5      �� 5      " ��6.   .R�5   "   �� $��border��6)   $��1q�5      $	 4,2q�5      
���  ��$ 3��5      #��z��5      ._�5   &   �� $��Center=�67   $��Center=�6T   5   #    5    "   P� 5!   &    �@J�IsMouseOver . . �5"   *   �� $ border��61   	 � ��

 �����6\   5#   '   5%      5'      5(      5)      .+�5-      �� $+��%Λειτουργία Βοήθειας��6   $
��Left=�62   $��	16,34,0,0q�6M   $	��Top=�6`   $
��Bold"�6x   $��20(�6�   
���  ��$��Italic$�6�   �� 5.      -   5         ��Name$ exithelpbtn��5.      $?��9Έξοδος από Λειτουργία Βοήθειας��6*   $
��Left=�6S   $��	16,71,0,0q�6n   $	��Top=�6�   $	��211��6�   $��26��6�    � Cursor$
 Hand��6�   $��Italic$�6�   
���������5/      �� 50      52      �� 55      $
��Left=�6   $	��120��6/   $��1069,132,0,0q�6<   $	��Top=�6R   $	��130��6j   $��/images/thermometer.png��6v    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�56      V� 57      .~�58      �� �� 59      �� 5:       �� Angle$ -3.166Q�6*   T� 5;      5<      5>      �� 5?      -   5         ��Name$ lbltemp2��5?      $��25 °C��6&   $
��Left=�66   $��1081,145,0,0q�6Q   $	��Top=�6g   ���	#FF336BFF$��65��6�   $��87��6�   
���  ��$��32(�6�   $
��Bold"�6�   �� 5@      -   5        $ pooltemp_hbtn��5@      #��[  6,   $
��Left=�6S   $��1063,130,0,0q�6n   $	��Top=�6�   $	��136��6�   $	��124��6�    � ToolTip$< 6Ρυθμιστής Θερμοκρασίας Νερού��6�   $
 Help��6�   ��5A      �� 5B      5D      �� 5F      -   5        $ poollights_hbtn��5F      #��[  6.   $
��Left=�6U   $��1081,279,0,0q�6p   $	��Top=�6�   $��75��6�   $
 Help��6�   $	��103��6�   $) #Διακόπτης Φωτισμού��6�    K� ZIndex$ 1��6�   ��5G      �� 5H      5J      �� 5K      -   5         ��Name$ 
poollights��5K      $
��Left=�6)   $��1071,321,0,0q�6D   $	��Top=�6Z   $��89��6r   $ 
0.522,0.56&�6}   $��20��6�    � Maximum$ 1Q�6�    �� IsSnapToTickEnabled . $) #Διακόπτης Φωτισμού��6�   ���	#FF719C97$
 Hand��6  {�.  z�5L      V� 5M      .~�5N      �� �� 5O      �� 5P      $ 89.252Q�6*   T� 5Q       T� X$ -0.492Q�6-    T� Y$ -2.669Q�68   5R      5T      �� 5U      $��Φ
Ω
Τ
Α��6   $
��Left=�65   $��1131,293,0,0q�6P   $	��Top=�6f   $��89��6~   $��23��6�   $
��Bold"�6�   �� 5W      $
��Left=�6   $��70��6/   $��116,595,0,0q�6;   $	��Top=�6P   $	��163��6h   $��/images/customer4.png��6t   $ 2.223,2.394&�6�   z�5X      V� 5Y      .~�5Z      �� �� 5[      �� 5\      $ 13.277Q�6*   T� 5]      5^      5`      �� 5b      $
��Left=�6   $	��435��6/   $��518,286,0,0q�6<   $	��Top=�6Q   $	��265��6i   $��/images/customer5.png��6u   $ 1.144,0.487&�6�   �� 5d      $
��Left=�6   $	��415��6/   $��897,353,0,0q�6<   $	��Top=�6Q   $	��284��6i   $��/images/customer6.png��6u   �� 5f      -   5        $ toExercise2_hbtn��5f      $,��&Προς Χώρο Εκγύμνασης��6/   $
��Left=�6N   $��1165,653,0,0q�6i   $	��Top=�6   $	��144��6�   ���	#FF00DCDC$
 Help��6�   
���  ��6�   �� 5g      -   5        $ toBar2_hbtn��5g      $��Προς Μπαρ��6*   $
��Left=�6>   $��1165,678,0,0q�6Y   $	��Top=�6o   $	��144��6�   ���	#FF00DCDC$
 Help��6�   
���  ��6�   �� 5h      -	   5        $ toLockers2_hbtn��5h      $#��Προς Αποδυτήρια��6.   $
��Left=�6H   $��1165,703,0,0q�6c   $	��Top=�6y   $	��144��6�   ���	#FF00DCDC$
 Help��6�   
���  ��6�   5i      5j      5k      
   M S B A M L   `   `   `  ����E  AMakeCarcas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MakeCarcas
MakeCarcas  5          MakeCarcas.TourPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MakeCarcas     5        N� Title$  TourPage��5	      .��5      � ���#FF9D40 � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 
�������$:��4Введите название для поиска:��6/   $	��175��6S    �� TextAlignment$ Right=�6_   �� 5      -   5        $��
TBoxSearch��5   &   $	��225��6   68   5      �� 5      .+�5      �� 
�������$��Выберите тип: ��6/   $	��175��6E   $ Right=�6Q   �� 5      -   5        $��	ComboType��5   '   $	��225��6    �� DisplayMemberPath$
 Name��6f   5      �� 5      -   5         ��Name$ CheckActual��5   *   
�������$E��?Показывать только актуальные туры��6}   $��Center=�5      5      �� 5   
   -   5        $��
LViewTours��5       $��1��6   $��Disabled=�62   $��Center=�6h   ���#FFB773��5      �� 5       .R�5!      � $ 
Horizontal=�6    $��Center=�69   5"      ��5$      �� 5%      .R�5&      �  5'      �� 5(      $��70 �6,   �� 5)      $	��310 �6,   �� 5*      $
��auto �6,   �� 5+      $
��auto �6,   .+�5-      �� $	��400��6    $��1��6,   $��UniformToFill=�69   $��Center=�6Q   $��5q�6n   ��5.      �� 5/   "    �� Path$ ImagePreview�6*    �� TargetNullValue 50   &   ��51   *   Resources/MissingPage.png��6Q   53   #   55      �� 56      $��Center=�6:   $ Center=�6U   $	��390��6l   $
��Wrap=�6x   $��Center=�6�   $	��5 5q�57   $   $��26(�61   $��0��6?   ��56   $   �� *Name+57   ?   �� 58      $��2��6V   $��5 5 5 15q�6c   $��Center=�6u   $��26(�6�   $
��Bold"�6�   ��6$   �� *Price+	 �� StringFormat$	 {0:N2} РУБ��6�   �� 59      $��3��6g   $��14(�6t   $��Right=�6�   ��6$   �� *TicketCount+$*	 $Билетов осталось: {0}��6�   �� 5:      $��3��6@   $��14(�6M   $
��Left=�6[   ��6$   �� *
ActualText+6[   5;      5<      5>      5?      5@      
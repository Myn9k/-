   M S B A M L   `   `   `  ����E  AMakeCarcas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MakeCarcas
MakeCarcas  5          MakeCarcas.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MakeCarcas     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Название��6   $��Center=�6$   $��Center=�6?   
���  ��6o   �� 5   
   $%��Количество звёзд��6   $��1��6,   $��Center=�69   $��Center=�6T   
���  ��6�   �� 5   
   $��Страна��6   $��2��6"   $��Center=�6/   $��Center=�6J   ���	#FFFF02026�   �� 5   
    �� 	MaxLength$	 100��6(   $��1��68   $��30��6H   ��6   �� *Name+6V   �� 5   
   $��1��60   $��1��6@   $	��175��6M   $
��Left=�6Y   $��30��6t   ��6   �� *CountOfStars+6�   �� 5   
   -   5         ��Name$ ComboCountries��5   Q   $��2��64   $��1��6A    �� DisplayMemberPath$
 Name��6i   $��30��6�    �� SelectedItem 6   �� *	Country+6�   �� 5   
   -   5        $��BtnSave��5   E   
�������$��Сохранить��6$   $��3��68   $��1��6j   $��160,10,319,37q�6z   $
��Auto��6�   5      5      
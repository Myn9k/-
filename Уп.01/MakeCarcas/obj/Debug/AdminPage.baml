   M S B A M L   `   `   `  ����E  AMakeCarcas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MakeCarcas
MakeCarcas  5          MakeCarcas.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MakeCarcas     5      -   5          N� Title$  	AdminPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $	��73* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGridUser��5         AutoGenerateColumns .     
IsReadOnly . ���#FFB773   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *User+6X     5      $ Пароль��6%   $	 150 6R    65   �� *
Password+6`     5      $8 2Имеет права администратора��6%   $	 250 6e    6I   �� *	IsAdmin+6s   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6=   -   5        $ ��Редактировать��5   %   6d   5      5      5      �� 5   
   -   5        $��BtnAdd��5   _   
�������$��Добавить��6$   $��1��67   $
��Left=�6D   $��	10,10,0,0q�6�   $	��102��6�   6�   �� 5    
   -   5        $��	BtnDelete��5    _   
�������$��Удалить��6$   $��1��66   $��Right=�6C   $��	0,10,10,0q�6�   $��98��6�   6�   5!      5"      
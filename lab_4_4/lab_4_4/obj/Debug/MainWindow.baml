   M S B A M L   `   `   `  ����B  >lab_4_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:lab_4_4lab_4_4  5   	       lab_4_4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:lab_4_4     5   	     � Title$  Опять Paint��5   	   $	��600��6   $
��1000��6*    � 	Resources 5	      �� 5
   
      KeyMyEditingModes   �� Type2  ,System.Windows.Controls.InkCanvasEditingMode"  6)   .s�5      ��  �� Member$ InkCanvasEditingMode.Ink��6   �� 5      $( "InkCanvasEditingMode.InkAndGesture��6   �� 5      $! InkCanvasEditingMode.Select��6   �� 5      $' !InkCanvasEditingMode.EraseByPoint��6   �� 5      $( "InkCanvasEditingMode.EraseByStroke��6   �� 5      $&  InkCanvasEditingMode.GestureOnly��6   �� 5      $ InkCanvasEditingMode.None��6   5      �� 5   
   MyDrawingAttributes  *  $System.Windows.Ink.DrawingAttributes"  6.   .s�5           Color$	 Red��6       Width$ 3Q�6,      Height$ 3Q�66     5      $ Green��6    $ 10Q�6.   $ 10Q�69     5      $
 Blue��6    $ 15Q�6-   $ 15Q�68     5      $ Black��6    $ 15Q�6.   $ 15Q�69   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   .+�5   
   �� $��0��6    �� 
Background
 �����	 �� EditingMode	 6"   �� 
 �� ElementName$
 lbEditingModes�� �� Path$ SelectedValue� �� DefaultDrawingAttributes 6i   �� $
 lbColors��$ SelectedValue�6�   �� 5    
   $��1��6   .+�5!      o� 
�������
����  �$��1q�6=   $��Bottom=�6Q   .@�5"      m� $��Команды��6   .@�5#      �� -   5         ��Name$ lbEditingModes��5#        MyEditingModes#��[ 66   5$      m� 5%      $��
Цвета��6   .@�5&      �� -   5        $ lbColors��5&        MyDrawingAttributes#��[ 60   ��5'      �� 5(      .R�5)   "   �� ��6,   �� $ Color�5*      5,      5-      5.      5/      50      51      
   M S B A M L   `   `   `  ����B  >5 labka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_5_labka_5_labka  5          _5_labka.ServisPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:_5_labka     5        N� Title$  
ServisPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.7* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	ServisDgr��5      $��2��6T   $��5��6h      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
ServisID+6B     5      $ ID заказа��6A    6%   �� *	OrderID+6A     5      $# Описание услуги��6B    6%   �� *
Opisanie+6B     5      $ Стоимость��6?    6%   �� *Price+6?   5!      �� 5"   
   $.��(Данные для заполнения��6   $��2��61   	 �� TextAlignment$	 Center=�6A   �� 5#   
   -   5        
 ��Name$
 dobav��5#      $��Добавить��6    $��6��63   $��0��6T   �� 5$   
   -   5        $	
 izm��5$      $��Изменить��6   $��6��61   $��1��6P   �� 5%   
   -   5        $

 udal��5%      $��Удалить��6   $��6��61   $��2��6R   �� 5&   
   -   5         ��Name$	 Tbx��5&      $��1��6   $��2��6,   �� 5'   
   -   5         ��Name$	 Cbx��5'      $��2��6    $��2��6-    �� DisplayMemberPath$ 	FirstName��6=   �� 5(   
   -   5        $
 Tbx3��5(      $��3��6    $��2��6-   �� 5)   
   -   5        $
 Tbx4��5)      $��4��6    $��2��6-   5*      5+      
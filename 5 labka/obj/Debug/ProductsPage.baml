   M S B A M L   `   `   `  ����B  >5 labka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_5_labka_5_labka  5          _5_labka.ProductsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:_5_labka     5        N� Title$  ProductsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.7* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ProductsDgr��5      $��2��6X   $��6��6l      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	ProductID+6C     5       $ ID категории��6D    6%   �� *
CategoryID+6D     5!      $ Название��6?    6%   �� *Namee+6?     5"      $ Описание��6B    6%   �� *
Opisanie+6B     5#      $ Стоимость��6?    6%   �� *Price+6?     5$      $, &Количество на складе��6I    6%   �� *QuantityInStock+6I   5&      �� 5'   
   $.��(Данные для заполнения��6   $��2��61   	 �� TextAlignment$	 Center=�6A   �� 5(   
   -   5        
 ��Name$
 dobav��5(      $��Добавить��6    $��8��63   $��0��6T   �� 5)   
   -   5        $	
 izm��5)      $��Изменить��6   $��8��61   $��1��6P   �� 5*   
   -   5        $

 udal��5*      $��Удалить��6   $��8��61   $��2��6R   �� 5+   
   -   5        $
 poisk��5+      $��
Поиск��6    $��2��60   $��5��6T   �� 5,   
   -   5        $
 ochistka��5,      $��Очистить��6#   $��2��66   $��6��6F   6S   �� 5.   
   -   5         ��Name$	 cbx��5.      $��6��6    $��2��6-    �� DisplayMemberPath$ CategoryName��6A   6b   �� 5/   
   -   5        $
 cbx2��5/      $��7��6!   $��2��6.    �� SelectedValuePath$ 
CategoryID��6>   $ CategoryName��6]   6~   �� 50   
   -	   5         ��Name$ poisktxt��50      $��5��6$   $��2��61   �� 51   
   -
   5        $	 Tbx��51      $��4��6   $��2��6,   �� 52   
   -   5        $
 tbx2��52      $��1��6    $��2��6-   �� 53   
   -   5        $
 tbx4��53      $��2��6    $��2��6-   �� 54   
   -   5        $
 tbx5��54      $��3��6    $��2��6-   55      56      
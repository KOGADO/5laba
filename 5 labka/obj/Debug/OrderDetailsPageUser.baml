   M S B A M L   `   `   `  ����B  >5 labka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_5_labka_5_labka  5      #    _5_labka.OrderDetailsPageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:_5_labka     5        N� Title$  OrderDetailsPageUser��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $
��0.7* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ OrderDetailsDgr��5      $��2��6`   $��7��6t      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *OrderDetailID+6G     5      $ ID заказа��6A    6%   �� *	OrderID+6A     5       $ 
Товар��6H    6%   �� *Products.Namee+6H     5!      $ Промокод��6Z    6%   �� *" PromotionalCodes.PromotionalCode+6Z     5"      $ Количество��6B    6%   �� *
Quantity+6B     5#      $ Цена за штуку��6C    6%   �� *	UnitPrice+6C   5%      �� 5&   
   $.��(Данные для заполнения��6   $��2��61   	 �� TextAlignment$	 Center=�6A   �� 5'   
   -   5        
 ��Name$
 dobav��5'      $��Добавить��6    $��7��63   $��0��6T   $��3��6d   �� 5(   
   -   5         ��Name$	 Tbx��5(      $��1��6   $��2��6,   �� 5)   
   -   5         ��Name$
 Cbx2��5)      $��2��6!   $��2��6/    �� DisplayMemberPath$ OrderID��6?   �� 5*   
   -   5        $
 Cbx3��5*      $��3��6!   $��2��6/   $ Namee��6?   �� 5+   
   -   5        $
 Cbx4��5+      $��4��6!   $��2��6/   $ PromotionalCode��6?   �� 5,   
   -   5        $
 Tbx2��5,      $��5��6    $��2��6.   �� 5-   
   -   5        $
 Tbx3��5-      $��6��6    $��2��6.   5.      5/      
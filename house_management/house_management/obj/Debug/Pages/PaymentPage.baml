   M S B A M L   `   `   `  ����K  Ghouse_management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:house_management.Pageshouse_management.Pages  5      (    "house_management.Pages.PaymentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:house_management.Pages     5      -   5          N� Title$  PaymentPage��5	      .��5      � ��5   
   �� 5       �� ImageSource$T NC:\Users\Admin\source\repos\house_management\house_management\Images\domd7.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ PaymentView��5         AutoGenerateColumns .     
IsReadOnly .  $��1��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *	IdPayment+  5      $ Тип оплаты��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.5* 5       5      �� *TypeOfPayment.Title+  5      $1 +Цена за еденицу площади��6%   $
	 0.8* 5       5       �� *SquarePrice+  5!      $- 'Цена на одного жильца��6%   $
	 0.8* 5"       5#      �� *LodgersPrice+  5$      $ Сумма оплаты��6%   $
	 0.5* 5%       5&      �� *PaymentAmount+  5'      $ Дата оплаты��6%   $
	 0.5* 5(       5)      �� *SupposedDatePayment+  5*      $, &Реальная дата оплаты��6%   $
	 0.5* 5+       5,      �� *DateOfPayment+5.      � 5/   
   
���   �
 J� Opacity$

 0.75Q�50      51      �� 52   
   -   5         ��Name$ InsertHouseOpen��52      $��Добавить��53      $	��200��54      $��30��55      $��0��56      $��Center=�57      $
��Left=�58      $��30 0 0 0q�59      6'   �� 5;   
   -   5        $
 Back��5;      $��
Назад��5<      $	��200��5=      $��30��5>      $��0��5?      $��Center=�5@      $��Right=�5A      $��0 0 30 0q�5B      6'   �� 5D   
   -   5        $ Update��5D      $ ��Редактировать��5E      $	��200��5F      $��30��5G      $��0��5H      $��Bottom=�5I      $��Center=�5J      $��350,0,350,30q�5K      6+   �� 5M   
   -   5        $ Delete��5M      $��Удалить��5N      $	��200��5O      $��25��5P      $��0��5Q      $��Center=�5R      60   5T      5U      
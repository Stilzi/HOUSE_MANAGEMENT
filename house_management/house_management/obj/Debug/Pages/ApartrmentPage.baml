   M S B A M L   `   `   `  ����K  Ghouse_management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:house_management.Pageshouse_management.Pages  5      +    %house_management.Pages.ApartrmentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:house_management.Pages     5      -   5          N� Title$  ApartrmentPage��5	      .��5      � ��5   
   �� 5       �� ImageSource$T NC:\Users\Admin\source\repos\house_management\house_management\Images\domd7.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ApartmentView��5         AutoGenerateColumns .     
IsReadOnly .  $��1��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *IdApartment+  5      $ Номер дома��6%   $
 0.5* 5      	 5      �� *House.Number+  5      $) #Количество жильцов��6%   $
 0.5* 5       	 5!      �� *QuantityLodgers+  5"      $ Площадь��6%   $
 0.5* 5#      	 5$      �� *Square+  5%      $ Сумма оплаты��6%   $
 0.5* 5&      	 5'      �� *Payment.PaymentAmount+5)      � 5*   
   
���   �
 J� Opacity$

 0.75Q�5+      5,      �� 5-   
   -   5         ��Name$ InsertHouseOpen��5-      $��Добавить��5.      $	��200��5/      $��30��50      $��0��51      $��Center=�52      $
��Left=�53      $��30 0 0 0q�54      55      �� 57   
   -   5        $
 Back��57      $��
Назад��58      $	��200��59      $��30��5:      $��0��5;      $��Center=�5<      $��Right=�5=      $��0 0 30 0q�5>      5?      �� 5A   
   -   5        $ Update��5A      $ ��Редактировать��5B      $	��200��5C      $��30��5D      $��0��5E      $��Bottom=�5F      $��Center=�5G      $��350,0,350,30q�5H      5I      �� 5K   
   -   5        $ Delete��5K      $��Удалить��5L      $	��200��5M      $��25��5N      $��0��5O      $��Center=�5P      5Q      5S      5T      
   M S B A M L   `   `   `  ����K  Ghouse_management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:house_management.Pageshouse_management.Pages  5      &     house_management.Pages.HousePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:house_management.Pages     5      -   5          N� Title$  	HousePage��5	      .��5      � ��5   
   �� 5       �� ImageSource$T NC:\Users\Admin\source\repos\house_management\house_management\Images\domd7.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	HouseView��5         AutoGenerateColumns .     
IsReadOnly .  $��1��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 5      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5      �� *	IdHouse+  5      $ 
Номер��6%   $
 0.5* 5      	 5      �� *Number+5       � 5!   
   
���   �
 J� Opacity$

 0.75Q�5"      5#      �� 5$   
   -   5         ��Name$ InsertHouseOpen��5$      $��Добавить��5%      $	��200��5&      $��30��5'      $��0��5(      $��Center=�5)      $
��Left=�5*      $��30 0 0 0q�5+      5,      �� 5-   
   -   5        $
 Back��5-      $��
Назад��5.      $	��200��5/      $��30��50      $��0��51      $��Center=�52      $��Right=�53      $��0 0 30 0q�54      55      �� 56   
   -   5        $ Update��56      $ ��Редактировать��57      $	��200��58      $��30��59      $��0��5:      $��Bottom=�5;      $��Center=�5<      $��350,0,350,30q�5=      5>      �� 5?   
   -   5        $ Delete��5?      $��Удалить��5@      $	��200��5A      $��25��5B      $��0��5C      $��Center=�5D      5E      5F      5G      
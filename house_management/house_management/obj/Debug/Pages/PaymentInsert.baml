   M S B A M L   `   `   `  ����K  Ghouse_management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:house_management.Pageshouse_management.Pages  5      *    $house_management.Pages.PaymentInsert   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:house_management.Pages     5        N� Title$  PaymentInsert��5	      .��5
      � .+�5   
   � ��5      �� 5       �� ImageSource$T NC:\Users\Admin\source\repos\house_management\house_management\Images\domd7.jpg��6   .+�5      � 
���   � J� Opacity$	 0.8Q�5      5      �� 5   
   -   5         ��Name$ Insert��5      $��30��5      $	��200��5      $��Ввод��5      $��300 600 0 0q�5      5   #   �� 5   
   -   5        $
 Back��5      $��30��5      $	��200��5      $��
Назад��5      $��0 600 300 0q�5      5   !   �� 5   
   $
��Left=�6   $��60 0 0 0q�5      .+�5      �� $��Тип оплаты��6   $��30(�5      
�������$��Center=�5!      �� 5"      -   5         ��Name$ TypeOfPaymentcmb��5"      $��40��5#      $	��300��5$      
�������$��20q�5&      �� 5'      $1��+Цена на единицу площади��6   $��30(�5(      
�������$��Center=�5*      �� 5+      -   5         ��Name$ txbSquarePrice��5+      $��40��5,      $	��300��5-      
�������$��20q�5/      �� 50      $-��'Цена на одного жильца��6   $��30(�51      
�������$��Center=�53      �� 54      -   5        $ txbLodgersPrice��54      $	��300��55      $��40��56      
�������$��20q�58      59      �� 5:   
   $��Right=�6   $��0 0 60 0q�5;      .+�5<      �� $��Сумма оплаты��6   $��30(�5=      
�������$��Center=�5?      �� 5@      -   5        $ txbPaymentAmount��5@      $	��300��5A      $��40��5B      $��20q�5C      
�������5D      �� 5E      $��Дата оплаты��6   $��30(�5F      
�������$��Center=�5H      (  "System.Windows.Controls.DatePicker  5I      -   5          Name$ dtSupposedDatePayment��5I      $	��300��5J      $��40��5K      $��20q�5L      
�������5M      �� 5N      $,��&Реальная дата оплаты��6   $��30(�5O      
�������$��Center=�5Q        5R      -   5        $ dtDateOfPayment��5R      $	��300��5S      $��40��5T      $��20q�5U      
�������5V      5W      5X      5Y      
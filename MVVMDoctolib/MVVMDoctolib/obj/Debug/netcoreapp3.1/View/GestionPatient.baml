   M S B A M L   `   `   `  ����G  CMVVMDoctolib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMDoctolib.ViewMVVMDoctolib.View  5   	   &     MVVMDoctolib.View.GestionPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MVVMDoctolib.View     5   	     � Title$  GestionPatient��5   	   $	��450��6    $
��1100��6-   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� $��Patient��6   $	��400��6$   .��5      �� .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Code: ��6   $��80��6-   6=   �� 5      $	��300��6;   ��6   �� *CodePatient+6L   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Nom : ��6   $��80��6-   6=   �� 5      $	��300��6:   ��6   �� *
NomPatient+6K   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��
Adresse : ��6   $��80��61   6A   �� 5      $	��300��6>   ��6   �� *AdressePatient+6O   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Date Naissance : ��6   $��80��68   6H   (  "System.Windows.Controls.DatePicker  5         IsTodayHighlighted$ False��6n      DisplayDate 6!   �� *DateTime.Now+   SelectedDate 6G   �� *DateNaissance+6n   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Sexe : ��6   $��80��6.   6>   	� 5      -   5         	�Name$ radMale��5   "   $��H��63    d� 	IsChecked 6?   �� *isMale+ �� Mode$ TwoWay=�6k   	� 5       -   5        $ 	radFemale��5    "   $��F��65    6A   �� *
isFemale+$ TwoWay=�6n   5!      �� 5"      $��Ajouter��6   ��6+   �� *
AddCommand+6L   �� 5#      $��Modifier��6   ��6,   �� *ModifyCommand+6P   �� 5$      $��	Supprimer��6   ��6-   �� *DeleteCommand+6Q   5%      5&      �� 5'   
   $��Liste Patients��6   $	��400��6+   .��5(      �� .+�5)      �� $ 
Horizontal=�6   .+�5*      �� $��Nom du Patient��6   $��80��65   6E   �� 5+      $	��200��66   ��6   �� *Search+6G   �� 5,      $	��100��6?   $��
Rechercher��6N   ��6   �� *SearchCommand+6e   5-      �� 5.      ��6   �� *
Patients+ �� SelectedItem 6<   �� *	Patient+	 �� View	 5/      �� 50      .P�51      �� $
��Code��6-   
 �� Width$	
 100��6;    �� DisplayMemberBinding 6G   �� *CodePatient+6v   �� 52      $	��Nom��6-   $	
 100��6:    6F   �� *
NomPatient+6t   �� 53      $��Adresse��6-   $	
 150��6>    6J   �� *AdressePatient+6|   �� 54      $��Date Naissance��6-   $	
 150��6E    6Q   �� *DateNaissance+6�   �� 55      $
��Sexe��6-   $	
 100��6;    6G   �� *SexePatient+6v   56      58      59      5:      5;      5<      
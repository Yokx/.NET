   M S B A M L   `   `   `  ����G  CMVVMDoctolib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMDoctolib.ViewMVVMDoctolib.View  5   	   &     MVVMDoctolib.View.GestionMedecin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MVVMDoctolib.View     5   	   -   5          � Title$  GestionMedecin��5   	   $	��450��6    $
��1100��6-   .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� $��Medecin��6   $	��400��6$   .��5      �� .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Code: ��6   $��80��6-   6=   �� 5      $	��300��6;   ��6   �� *CodeMedecin+6L   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Nom : ��6   $��80��6-   6=   �� 5      $	��300��6:   ��6   �� *
NomMedecin+6K   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Tel : ��6   $��80��6-   6=   �� 5      $	��300��6:   ��6   �� *
TelMedecin+6K   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Date d'embauche : ��6   $��80��69   6I   (  "System.Windows.Controls.DatePicker  5         IsTodayHighlighted$ False��6m      DisplayDate 6!   �� *DateTime.Now+   SelectedDate 6G   �� *DateEmbauche+6m   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Specialite: ��6   $��80��63   6C   �� 5      -   5         ��Name$ 	comboBox1��5      $	��100��6]    �� SelectedItem 62   �� *SpecialiteMedecin+6n   5       �� 5!      $��Ajouter��6   ��6+   �� *
AddCommand+6L   �� 5"      $��Modifier��6   ��6,   �� *ModifyCommand+6P   �� 5#      $��	Supprimer��6   ��6-   �� *DeleteCommand+6Q   �� 5$      $��\Assets/doc.png��6   $	��200��61   5%      5&      �� 5'   
   $��Liste Médecins��6   $	��400��6+   .��5(      �� .+�5)      �� $ 
Horizontal=�6   .+�5*      �� $��Nom du Médecin��6   $��80��65   6E   �� 5+      $	��200��66   ��6   �� *Search+6G   �� 5,      $	��100��6?   $��
Rechercher��6N   ��6   �� *SearchCommand+6e   5-      �� 5.      ��6   �� *
Medecins+ 6<   �� *	Medecin+ �� View 5/      �� 50      .P�51      �� $
��Code��6-    �� Width$	 100��6;   	 �� DisplayMemberBinding	 6G   �� *CodeMedecin+6v   �� 52      $	��Nom��6-   $	 100��6:   	 6F   �� *
NomMedecin+6t   �� 53      $��Téléphone��6-   $	 150��6@   	 6L   �� *
TelMedecin+6z   �� 54      $��Date Embauche��6-   $	 150��6D   	 6P   �� *DateEmbauche+6�   �� 55      $��Specialité��6-   $	 100��6A   	 6M   �� *SpecialiteMedecin+6�   56      58      59      5:      5;      5<      
   M S B A M L   `   `   `  ����G  CMVVMDoctolib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMDoctolib.ViewMVVMDoctolib.View  5   	   "    MVVMDoctolib.View.GestionRDV   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MVVMDoctolib.View     5   	     � Title$  
GestionRDV��5   	   $	��800��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Medecin��6   $	��330��6$   $	��200��60   $	��Top=�6=   $
��Left=�6U   ���	#FF0973F1.��5      �� .+�5      �� ��6   �� *
Medecins+ �� SelectedItem 6<   �� *	Medecin+ �� View 5      �� 5      .P�5      �� $
��Code��6-    �� Width$	 100��6;    �� DisplayMemberBinding 6G   �� *CodeMedecin+6v   �� 5      $	��Nom��6-   $	 100��6:    6F   �� *
NomMedecin+6t   �� 5      $��Specialité��6-   $	 100��6A    6M   �� *SpecialiteMedecin+6�   5      5      5      5      �� 5   
   .��5      �� $��\Assets/rdv.png��6   $	��100��6-   $	��140��6:   $	��Top=�6F   5      �� 5   
   $��Patient��6   $	��330��6$   $	��200��60   $	��Top=�6=   $��Right=�6U   ���	#FF007DF9.��5      �� .+�5      �� ��6   �� *
Patients+ 6<   �� *	Patient+ 5      �� 5       .P�5!      �� $
��Code��6-   $	 100��6;    6G   �� *CodePatient+6v   �� 5"      $	��Nom��6-   $	 100��6:    6F   �� *
NomPatient+6t   �� 5#      $
��Sexe��6-   $	 100��6;    6G   �� *SexePatient+6v   5$      5&      5(      5)      �� 5*   
   $��Infos Rendez-vous��6   $	��430��6.   $	��Top=�6:   $��185,200,185,0q�6R   ���	#FF0B6CF7.��5,      �� .+�5-      �� ���	#FFF91616.��6/   Infos Medecin6>   �� 5.       �� Orientation$ 
Horizontal=�6   .+�5/      �� $��Code Medecin: ��6   $��90��65   6B   �� 50      $	��100��6;   ��6   �� *CodeMedecin+6I   �� 51      $��Nom Medecin : ��6   $��80��65   6E   �� 52      $	��100��6:   ��6   �� *
NomMedecin+6K   53      �� 55      ���	#FFFD0909.��6/   Infos Patient6>   �� 56      $ 
Horizontal=�6   .+�57      �� $��Code Patient: ��6   $��90��65   6E   �� 58      $	��100��6;   ��6   �� *CodePatient+6L   �� 59      $��Nom Patient : ��6   $��95��65   6E   �� 5:      $	��100��6:   ��6   �� *
NomPatient+6K   5;      �� 5<      $ 
Horizontal=�6   5>      �� 5?      ���	#FFFDFDFD���	#FFFB1313.��6F   Rendez-vous :6U   �� 5@      $ 
Horizontal=�6   .+�5A      �� $��Date du Rendez-vous : ��6   $��80��6=   6M   (  "System.Windows.Controls.DatePicker  5B         IsTodayHighlighted$ False��6g      DisplayDate 6!   �� *DateTime.Now+   SelectedDate 6F   �� *	DateRDV+6g   5C      �� 5D      $ 
Horizontal=�6   .+�5E      �� $��Heure du Rendez-vous : ��6   $��80��6>   6N   �� 5F      $	��100��68   ��6   �� *
HeureRDV+6I   5G      �� 5H      .+�5I      �� $��Valider le Rendez-vous��6   $��30��6]   $	��200��6i   $��Center=�6u   ���	#FF51AAE8���	#FFF5F0F0��6>   �� *
AddCommand+6�   5J      5L      5M      �� 5N   
   $��Liste des RDV��6   $	��600��6*   $	��Top=�66   $��100,435,100,0q�6N   ���	#FF0476FF.��5O      �� .+�5Q      �� ��6   �� *Rdvs+ 68   �� *Rdv+ 5R      �� 5S      .P�5T      �� $��
Numero RDV��6-   $	 100��6A    6M   �� *	NumeroRDV+6z   �� 5U      $
��Date��6-   $	 100��6;    6G   �� *	DateRDV+	 �� StringFormat$	 
dd-MM-yyyy��6�   �� 5V      $��Heure��6-   $	 150��6<    6H   �� *
HeureRDV+6t   �� 5W      $��Medecin��6-   $	 150��6>    6J   �� *CodeMedecin+6y   �� 5X      $��Patient��6-   $	 100��6>    6J   �� *CodePatient+6y   5Y      5[      �� 5\      $ 
Horizontal=�6   .+�5]      �� $��Code du Patient��6   $��80��66   6F   �� 5^      $	��200��6=   ��6   �� *PatientSearch+6N   �� 5_      $	��100��6I   $��
Rechercher��6X   ��6   �� *SearchPerPatientCommand+6o   5`      �� 5a      $ 
Horizontal=�6   .+�5b      �� $
��Date��6   $��80��6+   6;     5c      $ False��6j    6!   �� *DateTime.Now+ 6F   �� *
DateSearch+6j   �� 5d      $	��100��6F   $��
Rechercher��6U   ��6   �� *SearchPerDateCommand+6l   5e      �� 5f      .+�5g      �� $��Modifier le Rendez-vous��6   $��30��6a   $	��200��6m   $��Center=�6y   ���	#FFF78F37��6?   �� *ModifyCommand+6�   �� 5h      $��Supprimer le Rendez-vous��6   $��30��6b   $	��200��6n   ���	#FFF58F28��6@   �� *DeleteCommand+6z   5i      5j      5k      5n      5q      
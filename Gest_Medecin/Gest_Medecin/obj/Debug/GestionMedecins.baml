   M S B A M L   `   `   `  ����G  CGest_Medecin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Gest_MedecinGest_Medecin  5   	   "    Gest_Medecin.GestionMedecins   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Gest_Medecin     5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  GestionMedecins��5
   	   $	��450��6!   $	��500��6.   .��5      � $��0,0,50,0q�6    � ColumnDefinitions 5   
   �� 5      $
��263* �6   �� 5      $��0* �6   �� 5      $
��179* �6   .+�5   
   �� $
��Code��6   $
��Left=�6   $��30��6:   $��	39,69,0,0q�6F   $	��Top=�6Y   $	��103��6q   �� 5   
   $	��Nom��6   $
��Left=�6   $��30��69   $��
39,104,0,0q�6E   $	��Top=�6Y   $	��103��6q   �� 5   
   $	��Tel��6   $
��Left=�6   $��30��69   $��
39,134,0,0q�6E   $	��Top=�6Y   $	��103��6q   �� 5   
   $��Date Embauche��6   $
��Left=�6(   $��30��6C   $��
39,169,0,0q�6O   $	��Top=�6c   $	��103��6{   �� 5   
   $��
Specialite��6   $
��Left=�6%   $��30��6@   $��
39,232,0,0q�6L   $	��Top=�6`   $	��103��6x   �� 5   
   -   5         ��Name$ textBox1��5      $
��Left=�6$   $��26��6?   $��	85,69,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $��98��6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��25��6?   $��
85,104,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $��98��6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ maskedTextBox1��5      $
��Left=�65   $��25��6P   $��
86,139,0,0q�6\   $
 Wrap=�6p   $��MaskedTextBox��6�   $	��Top=�6�   $��97��6�      Mask$ 00-00-00-00-00��6�      ClipboardMaskFormat$ IncludePromptAndLiterals=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateTimePicker1��5      $
��Left=�6.   $��30��6I   $��142,170,0,0q�6U   $	��Top=�6j   $	��128��6�   $��3��6�   �� 5   
   -   5         ��Name$ 	comboBox1��5      $
��Left=�6&   $��30��6A   $��119,232,0,0q�6M   $	��Top=�6b   $	��133��6z   �� 5   
   -   5        	 ��Name$	 buttonNouveau��5      $��Nouveau��6(   $
��Left=�6:   $��26��6U   $��	40,69,0,0q�6a   $	��Top=�6t   $	��123��6�   ���	#FF707070$��2��6�   ���	#FF0EA8F0���	#FFF9F5F56�   �� 5   
   -   5        $	 buttonRechercher��5      $��
Rechercher��6+   $
��Left=�6@   $��26��6[   $��
40,100,0,0q�6g   $	��Top=�6{   $	��123��6�   $��2��6�   ���	#FF0EA8F0���	#FFFDF6F66�   �� 5    
   -	   5        $	 buttonAjouter��5       $��Ajouter��6(   $
��Left=�6:   $��26��6U   $��
40,131,0,0q�6a   $	��Top=�6u   $	��123��6�   $��2��6�   ���	#FF0EA8F0���	#FFFFFDFD6�   �� 5!   
   -
   5        $	 buttonModifier��5!      $��Modifier��6)   $
��Left=�6<   $��26��6W   $��
40,162,0,0q�6c   $	��Top=�6w   $	��123��6�   $��2��6�   ���	#FF0EA8F0���	#FFFBFBFB6�   �� 5"   
   -   5        $	 buttonSupprimer��5"      $��	Supprimer��6*   $
��Left=�6>   $��26��6Y   $��
40,193,0,0q�6e   $	��Top=�6y   $	��123��6�   $��2��6�   ���	#FF0EA8F0���	#FFFBF9F96�   �� 5#   
   -   5        $	 ButtonQuitter��5#      $��Quitter��6(   $
��Left=�6:   $��26��6U   $��
40,224,0,0q�6a   $	��Top=�6u   $	��123��6�   $��2��6�   ���	#FFF394216�   �� 5$   
   $��3��6   $��Gestion Médecins��6$   $
��Left=�6?   $��28��6Z   $��
171,10,0,0q�6f   $	��Top=�6z   $	��150��6�   $��16(�6�   
������ ���	#FF2D98F1$��Impact)�6�   5'      5(      
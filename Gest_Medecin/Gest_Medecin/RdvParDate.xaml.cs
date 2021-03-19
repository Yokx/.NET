using Gest_Medecin.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gest_Medecin
{
    /// <summary>
    /// Logique d'interaction pour RdvParDate.xaml
    /// </summary>
    public partial class RdvParDate : Window
    {
        public RdvParDate()
        {
            InitializeComponent();
        }
        private void Grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //on vérifie si la ligne choisie contient bien un enregistrement
            if (dataGrid.SelectedItem!=null)
            {
                //on crée deux objets (medecin et patient)
                Medecin m = new Medecin();
                Patient p = new Patient();
                //on transforme la ligne du grid choisie en objet RDV
                RDV r = (RDV)dataGrid.SelectedItem;
                //ensuite on lance les methodes de recherche seek (pour patient et medecin) dans la bdd en passant
                //en paramètre le codePatient et codeMedecin contenus dans le l'objet rdv crée juste au dessus
                Medecin.Seek(r.CodeMedecin,ref m);
                Patient.Seek(r.CodePatient,ref p);
                textBox1.Text = m.NomMedecin;
                textBox2.Text = m.SpecialiteMedecin;
                textBox3.Text = p.NomPatient;
                textBox4.Text = p.DateNaissance.ToString();
                if (p.SexePatient == "H")
                    radiobutton1.IsChecked = true;
                else
                    radiobutton2.IsChecked = true;

            }

        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            //on nettoie la liste des rdv de classe
            RDV.Rdv.Clear();
            //on la remplit à nouveau avec cette fois la methode qui cherche que les rdv par date
            RDV.FillListWithSelectedDate(dateTimePicker1.SelectedDate.Value);
            //on remplit la datagrid avec le contenu de la liste
            dataGrid.ItemsSource = RDV.Rdv;


        }

        private void buttonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            //on reset la datagrid
            dataGrid.ItemsSource = null;
        }
    }
}

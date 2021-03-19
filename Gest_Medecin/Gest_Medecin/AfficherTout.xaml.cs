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
    /// Logique d'interaction pour AfficherTout.xaml
    /// </summary>
    public partial class AfficherTout : Window
    {
        public AfficherTout()
        {
            InitializeComponent();
        }

        private void radButMedecins_Checked(object sender, RoutedEventArgs e)
        {
            //On clear la liste des medecins pour ne pas l'afficher plusieurs fois àa la suite
            Medecin.Medecins.Clear();
            //et on la remplit à nouveau
            Medecin.FillList();
            //puis on affiche son contenu dans le datagrid
            dataGrid.ItemsSource = Medecin.Medecins;
            //dataGrid.Columns.Add(Medecin.Medecins)

        }

        private void radButPatients_Checked(object sender, RoutedEventArgs e)
        {
            //on clear la liste des patients pour ne pas l'afficher plusieurs fois à la suite
            Patient.Patients.Clear();
            //et on la remplit à nouveau
            Patient.FillList();
            //puis on affiche son contenu dans le datagrid
            dataGrid.ItemsSource = Patient.Patients;
        }

        private void radButRDV_Checked(object sender, RoutedEventArgs e)
        {
            //on clear la liste des rdv pour ne pas afficher la liste des rdv en doublons
            RDV.Rdv.Clear();
            //et on la remplit à nouveau
            RDV.FillList();
            //puis on affiche son contenu dans 
            dataGrid.ItemsSource = RDV.Rdv;
        }
    }
}

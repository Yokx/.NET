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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gest_Medecin
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ___GestionMedecins__Click(object sender, RoutedEventArgs e)
        {
            GestionMedecins gestMed = new GestionMedecins();
            gestMed.ShowDialog();
        }

        private void ___GestionPatients__Click(object sender, RoutedEventArgs e)
        {
            GestionPatients gestPat = new GestionPatients();
            gestPat.ShowDialog();

        }

        private void ___GestionRDV_Click(object sender, RoutedEventArgs e)
        {
            GestionRDV gestRdv = new GestionRDV();
            gestRdv.ShowDialog();
        }

        private void ___AfficherTout_Click(object sender, RoutedEventArgs e)
        {
            AfficherTout afftout = new AfficherTout();
            afftout.ShowDialog();
        }

        private void ___RDVParDate_Click(object sender, RoutedEventArgs e)
        {
            RdvParDate rdvdate = new RdvParDate();
            rdvdate.ShowDialog();
        }

        private void ___RDVParPatient_Click(object sender, RoutedEventArgs e)
        {
            RdvParPatient rdvPatient = new RdvParPatient();
            rdvPatient.ShowDialog();

        }
    }
}

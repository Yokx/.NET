using CompteBancaire.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompteBancaire
{
    /// <summary>
    /// Logique d'interaction pour AccueilAppl.xaml
    /// </summary>
    public partial class AccueilAppl : Window
    {
        //prop qui contiendra l'identifiant du form précédant
        public string identifiant;
        public AccueilAppl()
        {
            InitializeComponent();
            
        }
        private void onLoad(object sender, EventArgs e)
        {
            LabIdent.Content += identifiant;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            this.Width = 1100;
            DeposerArgent depot = new DeposerArgent();
            depot.identifiant = this.identifiant;
            FrameNavigation.NavigationService.Navigate(depot);
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            this.Width = 1100;
            RetirerArgent retrait = new RetirerArgent();
            retrait.identifiant = this.identifiant;
            FrameNavigation.NavigationService.Navigate(retrait);
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            this.Width = 1100;
            AfficherCompte affcompte = new AfficherCompte();
            affcompte.identifiant = this.identifiant;
            FrameNavigation.NavigationService.Navigate(affcompte);
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Client c = new Client();
            Client.Seek(identifiant, ref c);
            Compte compte = new Compte(c);
            if (Compte.Save(compte))
            {
                MessageBox.Show("Votre compte a été crée, il s'agit du compte numéro : "+compte.NumeroCompte);
            }
            else
                MessageBox.Show("Erreur, le compte n'a pas pu être crée");
        }
        private void FrameNavigation_OnNavigating(object sender, NavigatingCancelEventArgs e)
        {
            var ta = new ThicknessAnimation();
            ta.Duration = TimeSpan.FromSeconds(0.3);
            ta.DecelerationRatio = 0.7;
            ta.To = new Thickness(0, 0, 0, 0);
            if (e.NavigationMode == NavigationMode.New)
            {
                ta.From = new Thickness(500, 0, 0, 0);
            }
            else if (e.NavigationMode == NavigationMode.Back)
            {
                ta.From = new Thickness(0, 0, 500, 0);
            }
                 (e.Content as Page).BeginAnimation(MarginProperty, ta);
        }
    }
}

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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompteBancaire
{
    /// <summary>
    /// Logique d'interaction pour DeposerArgent.xaml
    /// </summary>
    public partial class DeposerArgent : Page
    {
        public string identifiant;
        public DeposerArgent()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            List<string> codesC = new List<string>();
            //on injecte dans notre liste la liste des comptes appartenants au client connecté
            Compte.InitBoxes(codesC, identifiant);
            //on remplit la combobox avec le contenu de la liste
            comboComptes.ItemsSource = codesC;

        }
    }
}

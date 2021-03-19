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
    /// Logique d'interaction pour Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        AccueilAppl acc;
        public Authentification()
        {
            InitializeComponent();
        }

       

        private void buttonValider_Click(object sender, RoutedEventArgs e)
        {
            //creation d'un nouveau objet client
            Client client = new Client();
            //on lance la methode de classe de recherche en passant en param le code choisi et l'objet crée afin que la méthode puisse le modifier
            if (Client.LoginCheck(textBoxIdentifiant.Text,textBoxMdp.Text, ref client))
            {
                acc = new AccueilAppl();
                //Ici on rempli client avec les données de celui-ci contenus dans la database
                Client.Seek(textBoxIdentifiant.Text, ref client);
                //enfin on injecte dans le label du form AccueilAppl l'identifiant du client
                acc.identifiant = client.Id;
                this.Close();
                acc.ShowDialog();
                

            }
            else//sinon ça veut dire que le patient n'existe pas dans la bdd
                MessageBox.Show("Client Introuvable");
        }
    }
}

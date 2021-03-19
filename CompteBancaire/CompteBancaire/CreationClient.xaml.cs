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
    /// Logique d'interaction pour CreationClient.xaml
    /// </summary>
    public partial class CreationClient : Window
    {
        public CreationClient()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, RoutedEventArgs e)
        {
            //le texterange permet de capter le contenu de la richtextbox
            TextRange tr = new TextRange(richtextBoxAdresse.Document.ContentStart, richtextBoxAdresse.Document.ContentEnd);
           
            //Creation de l'obet client et execution de la methode Save pour l'ajouter à la bdd
            
            Client client = new Client();
            client.Id = textBoxIdentifiant.Text;
            client.Nom = textBoxNom.Text;
            client.Prenom = textBoxPrenom.Text;
            client.Tel = Convert.ToInt32(textBoxTel.Text);
            //et ici on applique la propriété TEXT du textrange afin d'ajouter un string contenant l'adresse à la propriété adresseclient de l'objet patient
            client.Adresse = tr.Text;
            client.Pass = textBoxMdp.Text;
            
            if (Client.Save(client))
            {
                MessageBox.Show("Patient ajouté");
                Authentification auth = new Authentification();
                this.Close();
                auth.ShowDialog();
                

            }
               
            else
                MessageBox.Show("Erreur de création de compte");
        }
    }
}

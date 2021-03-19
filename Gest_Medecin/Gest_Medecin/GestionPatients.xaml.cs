using Gest_Medecin.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Logique d'interaction pour GestionPatients.xaml
    /// </summary>
    public partial class GestionPatients : Window
    {
        public GestionPatients()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            //on clear la richtextbox sur l'event onload du form histoire d'enlever le texte par defaut de celle-ci
            richTextBox1.Document.Blocks.Clear();
        }

        private void buttonNouveau_Click(object sender, RoutedEventArgs e)
        {
            //refresh du form
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Document.Blocks.Clear();
            dateTimePicker1.SelectedDate = DateTime.Now;
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
        }

        private void buttonRechercher_Click(object sender, RoutedEventArgs e)
        {
            //creation d'un nouveau patient'
            Patient p = new Patient() ;
            //on lance la methode de classe de recherche en passant en param le code choisi et l'objet crée afin que la méthode puisse le modifier
            if (Patient.Seek(textBox1.Text, ref p))
            {
                //on remplit les champs avec les infos de l'objet patient fraichement rempli via les infos pris de la bdd
                textBox2.Text = p.NomPatient;
                richTextBox1.AppendText(p.AdressePatient);
                dateTimePicker1.SelectedDate = p.DateNaissance;
                if (p.SexePatient == "H")
                    radioButton1.IsChecked = true;
                else
                    radioButton2.IsChecked = true;

            }
            else//sinon ça veut dire que le patient n'existe pas dans la bdd
                MessageBox.Show("Patient introuvable");
           
 
        }

        private void buttonAjouter_Click(object sender, RoutedEventArgs e)
        { 
            //le texterange permet de capter le contenu de la richtextbox
            TextRange tr = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd);
            string s = "";
            if (radioButton1.IsChecked == true)
                //on met H dans le champ s...
                s = "H";
            else if (radioButton2.IsChecked == true)  
                //on met F dans le champ s...
                s = "F";
            //Creation de l'obet patient et execution de la methode Save pour l'ajouter à la bdd
            Patient patient = new Patient();
            patient.CodePatient = textBox1.Text;
            patient.NomPatient = textBox2.Text;
            //et ici on applique la propriété TEXT du textrange afin d'ajouter un string contenant l'adresse à la propriété adresseclient de l'objet patient
            patient.AdressePatient = tr.Text;
            patient.DateNaissance = dateTimePicker1.SelectedDate.Value;
            patient.SexePatient = s;
            if (Patient.Save(patient))
                MessageBox.Show("Patient ajouté");
            else
                MessageBox.Show("Le patient n'a pu etre ajouté, verifier que le code patient n'existe pas déjà");
        }

        private void buttonModifier_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd);
            Patient pat = new Patient();
            pat.CodePatient = textBox1.Text;
            pat.NomPatient = textBox2.Text;
            pat.AdressePatient = tr.Text;
            pat.DateNaissance = dateTimePicker1.SelectedDate.Value;
            if (radioButton1.IsChecked == true)
            {
                pat.SexePatient = "H";
            }

            else if (radioButton2.IsChecked == true)
            {
                pat.SexePatient = "F";
            }
            //on execute la methode statique de classe pour modifier dans la bdd en lui passant l'objet en param
            if (Patient.Modify(pat))
                MessageBox.Show("Patient Modifié");
            else
                MessageBox.Show("Le patient n'a pu etre modifié, il n'existe pas");
           
        }

        private void buttonSupprimer_Click(object sender, RoutedEventArgs e)
        {
           
            //on crée un nouveau patient avec les données du form
            Patient pat = new Patient();
            // on a besoin que du code patient pour pouvoir lancer le delete de l'enregistreent dans la bdd
            pat.CodePatient = textBox1.Text;

            //on execute la methode statique de classe pour supprimer dans la bdd en lui passant l'objet en param
            if (Patient.Delete(pat))
                MessageBox.Show("Patient Supprimé");
            else
                MessageBox.Show("Le patient n'a pu etre supprimé, il n'existe pas");
        }

        private void ButtonQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

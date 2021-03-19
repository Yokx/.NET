using Gest_Medecin.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Logique d'interaction pour GestionMedecins.xaml
    /// </summary>
    public partial class GestionMedecins : Window
    {
        public GestionMedecins()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {



            IList<Specialite> spec = new List<Specialite>();
            spec.Add(new Specialite("Cardiologie"));
            spec.Add(new Specialite("Chirurgie"));
            spec.Add(new Specialite("Dermatologie"));
            spec.Add(new Specialite("Geriatrie"));
            spec.Add(new Specialite("Oncologie"));
            spec.Add(new Specialite("Pediatrie"));
            spec.Add(new Specialite("Psychiatrie"));
            spec.Add(new Specialite("Allergologie"));
            //foreach (Specialite s in spec)
            //{
            //    comboBox1.Items.Add(s.NomSpecialite);
            //}

            comboBox1.ItemsSource = spec;

        }


        private void buttonNouveau_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.SelectedDate = DateTime.Now;
            comboBox1.SelectedIndex = -1;
        }

        private void buttonRechercher_Click(object sender, RoutedEventArgs e)
        {
            //creation d'un nouveau médecin
            Medecin m = new Medecin();
            // 1-- on place dans un dictionnaire les specialite(Values) avec des index(Keys) pour recuperer l'index de la specialité choisie
            Dictionary<int, Specialite> spec2 = new Dictionary<int, Specialite>
            {
                { 0, new Specialite("Cardiologie") },
                { 1, new Specialite("Chirurgie") },
                { 2, new Specialite("Dermatologie") },
                { 3, new Specialite("Geriatrie") },
                { 4, new Specialite("Oncologie") },
                { 5, new Specialite("Pediatrie") },
                { 6, new Specialite("Psychiatrie") },
                { 7, new Specialite("Allergologie") }
            };
            //on lance la methode de classe pour chercher le medecin dans la bdd 
           ;
            //on teste d'abord si l'objet a été rempli, c'est à dire que la methode seek a bien trouvé le medecin recherché
            if (Medecin.Seek(textBox1.Text, ref m))
            {
                //et on remplit les propriétés de l'objet avec les infos du medecin tirés de la bdd
                textBox2.Text = m.NomMedecin;
                maskedTextBox1.Text = m.TelMedecin.ToString();
                dateTimePicker1.SelectedDate = m.DateEmbauche;
                //1--..et utiliser cet index pour selectionner la bonne specialité dans la combobox
                foreach (KeyValuePair<int, Specialite> ligne in spec2)
                {
                    if (ligne.Value.NomSpecialite == m.SpecialiteMedecin)
                    {
                        comboBox1.SelectedIndex = ligne.Key;
                        break;
                    }
                }
            }
            else //sinon ça veut dire que le médecin n'existe pas dans la bdd
                MessageBox.Show("Medecin introuvable");
            






        }

        private void buttonAjouter_Click(object sender, RoutedEventArgs e)
        {

            //Creation de l'objet medecin et execution de la methode Save pour l'ajouter à la bdd
            Medecin medecin = new Medecin();
            medecin.CodeMedecin = textBox1.Text;
            medecin.NomMedecin = textBox2.Text;
            medecin.TelMedecin = maskedTextBox1.Text;
            medecin.DateEmbauche = dateTimePicker1.SelectedDate.Value;
            medecin.SpecialiteMedecin = comboBox1.SelectedItem.ToString();
            if (Medecin.Save(medecin))
                MessageBox.Show("Medecin ajouté");
            else
                MessageBox.Show("le médecin n'a pas pu etre ajouté, le code médecin choisi existe deja");
        }

        private void buttonModifier_Click(object sender, RoutedEventArgs e)
        {
            //on crée un nouveau patient avec les données du form
            Medecin med = new Medecin();
            med.CodeMedecin = textBox1.Text;
            med.NomMedecin = textBox2.Text;
            med.TelMedecin = maskedTextBox1.Text;
            med.DateEmbauche = dateTimePicker1.SelectedDate.Value;
            med.SpecialiteMedecin = comboBox1.SelectedItem.ToString();
            //on execute la methode statique de classe pour modifier dans la bdd en lui passant l'objet en param
            if (Medecin.Modify(med))
                MessageBox.Show("Medecin modifié");
            else
                MessageBox.Show("Le médecin n'a pu etre modifié, il n'existe pas");
        }

        private void buttonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            //on crée un nouveau patient avec les données du form
            Medecin med = new Medecin();
            // on a besoin que du code patient pour pouvoir lancer le delete de l'enregistreent dans la bdd
            med.CodeMedecin = textBox1.Text;
            //on execute la methode statique de classe pour supprimer dans la bdd en lui passant l'objet en param
            if (Medecin.Delete(med))
                MessageBox.Show("Médecin supprimé");
            else
                MessageBox.Show("Le médecin n'a pu être supprimé, il n'existe pas");
        }

        private void ButtonQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

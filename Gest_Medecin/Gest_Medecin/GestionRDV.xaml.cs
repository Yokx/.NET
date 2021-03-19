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
    /// Logique d'interaction pour GestionRDV.xaml
    /// </summary>
    public partial class GestionRDV : Window
    {
        public GestionRDV()
        {
            InitializeComponent();
        }
        #region Evenement qui va remplir les combobox avec les codes patients et medecins au chargement dur form
        //evenement ajouté dans le xml  Title="GestionRDV" Height="377" Width="683" Loaded="OnLoad">
        private void OnLoad(object sender, EventArgs e)
        {

            List<string> codesMed = new List<string>();
            List<string> codesPat = new List<string>();
            //on injecte dans nos deux listes les codes patients et codes medecins
            RDV.InitBoxes(codesMed,codesPat);
            comboBox1.ItemsSource = codesPat;
            comboBox2.ItemsSource = codesMed;
        }
        #endregion

        #region Evenement qui va remplir les informations du patient quand le user aura choisi un code patient dans la combobox1
        private void ComboBox1_SelectionChanged(object sender, EventArgs e)
        {
            //on remplit les champs selon le code patient choisi dans la combobox
            if (comboBox1.SelectedIndex>-1) // o ndéclenche ceci que quand on change le contenu de la combobox pour un autre code afin que l'event ne fasse rien durant le refresh du formulaire via le bouton "Nouveau"
            {
                Patient p = new Patient();
                Patient.Seek(comboBox1.SelectedItem.ToString(), ref p);
                textBox1.Text = p.NomPatient;
                if (p.SexePatient == "H")
                    radioButton1.IsChecked = true;
                else
                    radioButton2.IsChecked = true;

            }
           

        }

        #endregion
        #region Evenement qui va remplir les informations du Medecin quand le user aura choisi un code medecin dans la combobox2
        private void ComboBox2_SelectionChanged(object sender, EventArgs e)
        {
            //on remplit les champs du médecin selon le code medecin chosi dans la combobox
            if (comboBox2.SelectedIndex>-1) // o ndéclenche ceci que quand on change le contenu de la combobox pour un autre code afin que l'event ne fasse rien durant le refresh du formulaire via le bouton "Nouveau"
            {
                Medecin m = new Medecin();
                Medecin.Seek(comboBox2.SelectedItem.ToString(),ref m);
                textBox2.Text = m.NomMedecin;
                textBox3.Text = m.SpecialiteMedecin;

            }
            
        }
        #endregion

        private void buttonNouveau_Click(object sender, RoutedEventArgs e)
        {
            //refresh du form
            comboBox1.SelectedIndex=-1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            dateTimePicker1.SelectedDate = DateTime.Now;
            maskedTextBox1.Clear();
        }

        private void buttonAjouter_Click(object sender, RoutedEventArgs e)
        {
            //Creation de l'objet medecin et execution de la methode Save pour l'ajouter à la bdd
            RDV rdv = new RDV();
            rdv.DateRDV = dateTimePicker1.SelectedDate.Value;
            rdv.HeureRDV = maskedTextBox1.Text;
            rdv.CodeMedecin = comboBox2.SelectedItem.ToString();
            rdv.CodePatient = comboBox1.SelectedItem.ToString();

            if (RDV.Save(rdv))
                MessageBox.Show("RDV Ajouté!");
            else
                MessageBox.Show("Le RDv  n'a pas pu etre crée");
        }

        private void buttonQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

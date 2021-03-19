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
    /// Logique d'interaction pour RdvParPatient.xaml
    /// </summary>
    public partial class RdvParPatient : Window
    {
        public RdvParPatient()
        {
            InitializeComponent();
        }
        public void OnLoad(object sender, EventArgs e)
        {
            richTextBox1.Document.Blocks.Clear();
           
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            // o ncrée un nouveau Patient
            Patient p = new Patient();
            p.CodePatient = textBox1.Text;
            //et on lance la méthode de classe pour le rechercher dans la bdd qui ensuite remplira les propriétés de l'objet crée avec
            //les infos de la bdd
            Patient.Seek(textBox1.Text, ref p);
            textBox2.Text = p.NomPatient;
            textBox3.Text = p.DateNaissance.ToString();
            richTextBox1.AppendText(p.AdressePatient);
            if (p.SexePatient == "H")
                radioButton1.IsChecked = true;
            else
                radioButton2.IsChecked = true;
            RDV.Rdv.Clear();
            //on la remplit à nouveau avec cette fois la methode qui cherche que les rdv par le patient choisi
            RDV.FillListWithChosenPatient(p.CodePatient);
            //on remplit la datagrid avec le contenu de la liste
            dataGrid.ItemsSource = RDV.Rdv;
            


        }

        private void buttonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtBoxNumRDV.Clear();
            richTextBox1.Document.Blocks.Clear();
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            dateTimePicker1.SelectedDate = DateTime.Now;
            txtBoxHeureRDV.Clear();
            comboBox2.SelectedIndex = -1;
        }
        private void Grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //on vérifie si la ligne choisie contient bien un enregistrement
            if (dataGrid.SelectedItem != null )
            {
                //remplissage de la combobox avec les code médecins
                List<string> codesMed = new List<string>();
                List<string> codesPat = new List<string>();
                //on injecte dans notre combobox code medecin le contenu de la liste des code medecins
                RDV.InitBoxes(codesMed, codesPat);

                comboBox2.ItemsSource = codesMed;
                //on crée deux objets (medecin et patient)
                Medecin m = new Medecin();
                Patient p = new Patient();
                
                //on transforme la ligne du grid choisie en objet RDV
                RDV r = (RDV)dataGrid.SelectedItem;
                //ensuite on lance les methodes de recherche seek (pour patient et medecin) dans la bdd en passant
                //en paramètre le codePatient et codeMedecin contenus dans le l'objet rdv crée juste au dessus
                Medecin.Seek(r.CodeMedecin,  ref m);
                Patient.Seek(r.CodePatient, ref p);
                txtBoxNumRDV.Text = r.NumeroRDV.ToString();
                txtBoxHeureRDV.Text = r.HeureRDV;
                dateTimePicker1.SelectedDate = r.DateRDV;
                comboBox2.SelectedItem = r.CodeMedecin;
               
            }
            //if (dataGrid.SelectedCells.Count==1)
            //{
            //    var cell = dataGrid.SelectedCells;

            //    var codemed = dataGrid.SelectedCells[0];
            //    GestionMedecins g = new GestionMedecins();
            //    g.ShowDialog()
            //}

        }
        //private void RecupCodeMedecin()
        //{
        //    string i = dataGrid.SelectedItem.ToString();
        //    GestionMedecins g = new GestionMedecins();
        //    g.ShowDialog();
        //}
        //private void SelectedCellsChanged()
        //{
        //    var cellInfo = dataGrid.SelectedCells[3];

        //    var content = cellInfo.Column.GetCellContent(cellInfo.Item);
        //    if (content != null)
        //    {
        //        GestionMedecins g = new GestionMedecins();
        //        g.ShowDialog();
        //    }
                


        //}
        

        private void buttonEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            //on crée un objet rdv avec les données du form, on lui affecte les données du form
            RDV r_modified = new RDV();
            r_modified.NumeroRDV = Convert.ToInt32(txtBoxNumRDV.Text);
            r_modified.DateRDV = dateTimePicker1.SelectedDate.Value;
            r_modified.HeureRDV = txtBoxHeureRDV.Text;
            r_modified.CodeMedecin = comboBox2.SelectedItem.ToString();
            r_modified.CodePatient = textBox1.Text;
            //et ensuite on appelle la methode de classe modify pour modifier dans la bdd le rdv correspondant à ce rdv
            if (RDV.Modify(r_modified))
                MessageBox.Show("Le rdv a été modifié et enregistré");
            else
                MessageBox.Show("Le rdv n'a pu être modifé");

        }

        private void buttonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            //on crée un objet rdv avec les données du form, on lui affecte le numero du rdv en question
            RDV r_toDelete= new RDV();
            r_toDelete.NumeroRDV = Convert.ToInt32(txtBoxNumRDV.Text);

            //et ensuite on appelle la methode de classe delete pour aller le supprimer dans la bdd
            if (RDV.Delete(r_toDelete))
                MessageBox.Show("le RDv a été supprimé");
            else
                MessageBox.Show("Le rdv n'a pas pu être supprimé");

        }
    }
}

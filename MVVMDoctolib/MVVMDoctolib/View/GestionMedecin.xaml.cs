using MVVMDoctolib.Model;
using MVVMDoctolib.ViewModel;
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

namespace MVVMDoctolib.View
{
    /// <summary>
    /// Logique d'interaction pour GestionMedecin.xaml
    /// </summary>
    public partial class GestionMedecin : Window
    {
        public GestionMedecin()
        {
            InitializeComponent();
            DataContext = new MedecinViewModel();
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
    }
    
}

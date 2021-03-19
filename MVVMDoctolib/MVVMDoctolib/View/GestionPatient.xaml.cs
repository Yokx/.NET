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
    /// Logique d'interaction pour GestionPatient.xaml
    /// </summary>
    public partial class GestionPatient : Window
    {
        public GestionPatient()
        {
            InitializeComponent();
            DataContext = new PatientViewModel();
        }
    }
}

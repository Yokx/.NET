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
    /// Logique d'interaction pour GestionRDV.xaml
    /// </summary>
    public partial class GestionRDV : Window
    {
        public GestionRDV()
        {
            InitializeComponent();
            DataContext = new RDVViewModel();
           
        }
    }
}

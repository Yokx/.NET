using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVMDoctolib.Model;
using MVVMDoctolib.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVMDoctolib.ViewModel
{
    class MedecinViewModel:ViewModelBase
    {
        private Medecin medecin;

        public string CodeMedecin
        {
            get => Medecin.CodeMedecin;
            set
            {
                Medecin.CodeMedecin = value;
                RaisePropertyChanged();
            }
        }

        public string NomMedecin
        {
            get => Medecin.NomMedecin;
            set
            {
                Medecin.NomMedecin = value;
                RaisePropertyChanged();
            }
        }
        public string TelMedecin
        {
            get => Medecin.TelMedecin;
            set
            {
                Medecin.TelMedecin = value;
                RaisePropertyChanged();
            }
        }
        public DateTime DateEmbauche
        {
            get => Medecin.DateEmbauche;
            set
            {
                Medecin.DateEmbauche = value;
                RaisePropertyChanged();
            }
        }
        public string SpecialiteMedecin
        {
            get => Medecin.SpecialiteMedecin;
            set
            {
                Medecin.SpecialiteMedecin = value;
                RaisePropertyChanged();
            }
        }
        public string Search { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand ModifyCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public Medecin Medecin { get => medecin; set { medecin = value; if (value != null) RaiseAllChanged(); }}
    
        public ObservableCollection<Medecin> Medecins { get; set; }

        public MedecinViewModel()
        {
            medecin = new Medecin();
            AddCommand = new RelayCommand(ActionAddCommand);
            ModifyCommand = new RelayCommand(ActionModifyCommand);
            DeleteCommand = new RelayCommand(ActionDeleteCommand);
            SearchCommand = new RelayCommand(ActionSearchCommand);
            Medecins = new ObservableCollection<Medecin>(Database.ListeMedecins());
            DateEmbauche = DateTime.Now;
        }

        private void ActionAddCommand()
        {
            if (Medecin.Save(medecin))
            {
                Medecins.Add(Medecin);
                MessageBox.Show("Médecin ajouté");
                Medecin = new Medecin();
                Medecin.DateEmbauche = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }
        private void ActionModifyCommand()
        {
            if (Medecin.Modify(Medecin))
            {
                
                MessageBox.Show("Mise à jour du médecin effectuée");
                Medecin = new Medecin();
                Medecin.DateEmbauche = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }

        }
        private void ActionSearchCommand()
        {
            Medecins = new ObservableCollection<Medecin>(Database.ListeMedecinParNomChoisi(Search));
            RaisePropertyChanged("Medecins");

        }
        public void ActionDeleteCommand()
        {
            if (Medecin.Delete(Medecin))
            {
                MessageBox.Show("Médecin supprimé");
                Medecins.Remove(Medecin);
                Medecin = new Medecin();
                Medecin.DateEmbauche = DateTime.Now;
                RaiseAllChanged();

            }
            else
                MessageBox.Show("Erreur");
        }

        private void RaiseAllChanged()
        {
           
            RaisePropertyChanged("CodeMedecin");
            RaisePropertyChanged("NomMedecin");
            RaisePropertyChanged("TelMedecin");
            RaisePropertyChanged("DateEmbauche");
            RaisePropertyChanged("SpecialiteMedecin");
        }
    }
}

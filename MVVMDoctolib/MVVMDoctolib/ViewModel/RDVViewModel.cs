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
    class RDVViewModel:ViewModelBase
    {
        private RDV rdv;
        private Medecin med;
        private Patient pat;

        #region Propriétés de base d'un RDV
        public int NumeroRDV
        {
            get => rdv.NumeroRDV;
            set
            {
                rdv.NumeroRDV = value;
                RaisePropertyChanged();
            }
        }

        public DateTime DateRDV
        {
            get => rdv.DateRDV;
            set
            {
                rdv.DateRDV = value;
                RaisePropertyChanged();
            }
        }
        public string HeureRDV
        {
            get => rdv.HeureRDV;
            set
            {
                rdv.HeureRDV = value;
                RaisePropertyChanged();
            }
        }

        public string CodeMedecin
        {
            get => rdv.CodeMedecin;
            set
            {
                med.CodeMedecin = value;
                RaisePropertyChanged();
            }
        }
        public string CodePatient
        {
            get => rdv.CodePatient;
            set
            {
                pat.CodePatient = value;
                RaisePropertyChanged();
            }
        }
        #endregion
       
        #region Section Infos Supplémentaires Medecin
        public string NomMedecin
        {
            get => med.NomMedecin;
            set
            {
                med.NomMedecin = value;
                RaisePropertyChanged();
            }
        }
        public string SpecialiteMedecin
        {
            get => med.SpecialiteMedecin;
            set
            {
                med.SpecialiteMedecin = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Section concernant le patient
       
        public string NomPatient
        {
            get => pat.NomPatient;
            set
            {
                pat.NomPatient = value;
                RaisePropertyChanged();
            }
        }
        public bool isMale
        {
            get
            {
                return pat != null ? pat.SexePatient == "H" : false;
            }
            set
            {
                pat.SexePatient = "H";
            }
        }
        public bool isFemale
        {
            get
            {
                return pat != null ? pat.SexePatient == "F" : false;
            }
            set
            {
                pat.SexePatient = "F";
            }
        }
        public string SexePatient
        {
            get => pat.SexePatient;
            set
            {
                pat.SexePatient = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public string PatientSearch { get; set; }
        public DateTime DateSearch { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand ModifyCommand { get; set; }
        public ICommand SearchPerDateCommand { get; set; }
        public ICommand SearchPerPatientCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public RDV Rdv { get => rdv; set { rdv = value; if (value != null) RaiseAllChanged(); } }
        public Patient Pat { get => pat; set { pat = value; if (value != null) RaiseAllChanged(); } }
        public Medecin Med { get => med; set { med = value; if (value != null) RaiseAllChanged(); } }

        public ObservableCollection<RDV> Rdvs { get; set; }
        public ObservableCollection<Patient> Patients { get; set; }
        public ObservableCollection<Medecin> Medecins { get; set; }

        public RDVViewModel()
        {
            pat = new Patient();
            med = new Medecin();
            rdv = new RDV();
            AddCommand = new RelayCommand(ActionAddCommand);
            ModifyCommand = new RelayCommand(ActionModifyCommand);
            DeleteCommand = new RelayCommand(ActionDeleteCommand);
            SearchPerDateCommand = new RelayCommand(ActionSearchPerDateCommand);
            SearchPerPatientCommand = new RelayCommand(ActionSearchPerPatientCommand);
            Rdvs = new ObservableCollection<RDV>(Database.ListeRDV());
            Medecins = new ObservableCollection<Medecin>(Database.ListeMedecins());
            Patients = new ObservableCollection<Patient>(Database.ListePatients());
            DateRDV = DateTime.Now;
            DateSearch = DateTime.Now;
        }

        

        private void ActionAddCommand()
        {
            if (RDV.Save(rdv))
            {

                Rdvs.Add(rdv);
                MessageBox.Show("Rendez-vous ajouté");
                Rdv = new RDV();
                Pat = new Patient();
                Med = new Medecin();
                Rdv.DateRDV = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }

        private void ActionModifyCommand()
        {
            if (RDV.Modify(rdv))
            {

                MessageBox.Show("Mise à jour du rdv effectuée");
                Rdv = new RDV();
                Pat = new Patient();
                Med = new Medecin();
                Rdv.DateRDV = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }

        }
        private void ActionSearchPerDateCommand()
        {
            Rdvs = new ObservableCollection<RDV>(Database.ListeRDVParDateChoisie(DateSearch));
            RaisePropertyChanged("Rdvs");

        }
        private void ActionSearchPerPatientCommand()
        {
            Rdvs = new ObservableCollection<RDV>(Database.ListeRDVParPatientChoisi(PatientSearch));
            RaisePropertyChanged("Rdvs");

        }
        public void ActionDeleteCommand()
        {
            if (RDV.Delete(rdv))
            {
                MessageBox.Show("Rendez-vous supprimé");
                Rdvs.Remove(rdv);
                Rdv = new RDV();
                Pat = new Patient();
                Med = new Medecin();
                Rdv.DateRDV = DateTime.Now;
                RaiseAllChanged();

            }
            else
                MessageBox.Show("Erreur");
        }

        private void RaiseAllChanged()
        {

            RaisePropertyChanged("NumeroRDV");
            RaisePropertyChanged("DateRDV");
            RaisePropertyChanged("HeureRDV");
            RaisePropertyChanged("CodeMedecin");
            RaisePropertyChanged("CodePatient");
            RaisePropertyChanged("isMale");
            RaisePropertyChanged("isFemale");
            RaisePropertyChanged("SexePatient");
            RaisePropertyChanged("NomMedecin");
            RaisePropertyChanged("NomPatient");
            RaisePropertyChanged("SpecialiteMedecin");
        }

    }
}

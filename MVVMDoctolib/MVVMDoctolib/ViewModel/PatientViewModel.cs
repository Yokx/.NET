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
    class PatientViewModel:ViewModelBase
    {
        private Patient patient;

        public string CodePatient
        {
            get => patient.CodePatient;
            set
            {
                patient.CodePatient = value;
                RaisePropertyChanged();
            }
        }

        public string NomPatient
        {
            get => patient.NomPatient;
            set
            {
                patient.NomPatient = value;
                RaisePropertyChanged();
            }
        }
        public string AdressePatient
        {
            get => patient.AdressePatient;
            set
            {
                patient.AdressePatient = value;
                RaisePropertyChanged();
            }
        }
        public DateTime DateNaissance
        {
            get => patient.DateNaissance;
            set
            {
                patient.DateNaissance = value;
                RaisePropertyChanged();
            }
        }
        public bool isMale
        {
            get
            {
                return patient != null ? patient.SexePatient == "H" : false;
            }
            set
            {
                patient.SexePatient = "H";
            }
        }
        public bool isFemale
        {
            get
            {
                return patient != null ? patient.SexePatient == "F" : false;
            }
            set
            {
                patient.SexePatient = "F";
            }
        }
        public string SexePatient
        {
            get => patient.SexePatient;
            set
            {
                patient.SexePatient = value;
                RaisePropertyChanged();
            }
        }
        public string Search { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand ModifyCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public Patient Patient { get => patient; set { patient = value; if (value != null) RaiseAllChanged(); } }

        public ObservableCollection<Patient> Patients { get; set; }

        public PatientViewModel()
        {
            patient = new Patient();
            AddCommand = new RelayCommand(ActionAddCommand);
            ModifyCommand = new RelayCommand(ActionModifyCommand);
            DeleteCommand = new RelayCommand(ActionDeleteCommand);
            SearchCommand = new RelayCommand(ActionSearchCommand);
            Patients = new ObservableCollection<Patient>(Database.ListePatients());
            DateNaissance = DateTime.Now;
        }

        private void UpdateList()
        {
            Patients = new ObservableCollection<Patient>(Database.ListePatients());
        }

        private void ActionAddCommand()
        {
            if (Patient.Save(Patient))
            {
                
                Patients.Add(patient);
                MessageBox.Show("Patient ajouté");
                Patient = new Patient();
                Patient.DateNaissance = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }
  
        private void ActionModifyCommand()
        {
            if (Patient.Modify(Patient))
            {

                MessageBox.Show("Mise à jour du patient effectuée");
                Patient = new Patient();
                Patient.DateNaissance = DateTime.Now;
                RaiseAllChanged();
            }
            else
            {
                MessageBox.Show("Erreur");
            }

        }
        private void ActionSearchCommand()
        {
            Patients = new ObservableCollection<Patient>(Database.ListePatientParNomChoisi(Search));
            RaisePropertyChanged("Patients");

        }
        public void ActionDeleteCommand()
        {
            if (Patient.Delete(Patient))
            {
                MessageBox.Show("Patient supprimé");
                Patients.Remove(Patient);
                Patient = new Patient();
                Patient.DateNaissance = DateTime.Now;
                RaiseAllChanged();

            }
            else
                MessageBox.Show("Erreur");
        }

        private void RaiseAllChanged()
        {
           
            RaisePropertyChanged("CodePatient");
            RaisePropertyChanged("NomPatient");
            RaisePropertyChanged("AdressePatient");
            RaisePropertyChanged("DateNaissance");
            RaisePropertyChanged("SexePatient");
            RaisePropertyChanged("isMale");
            RaisePropertyChanged("isFemale");
        }
    }
}

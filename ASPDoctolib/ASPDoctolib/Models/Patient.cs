using ASPDoctolib.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Models
{
    public class Patient
    {
        private string mail_Patient;
        private string nom_Patient;
        private string telPortable_Patient;
        private string adresse_Patient;
        private DateTime dateNaissance;
        private string sexePatient;
        private string mdp_Patient;
        private static List<Patient> patients = new List<Patient>();


        public string Mail_Patient { get => mail_Patient; set => mail_Patient = value; }
        public string Nom_Patient { get => nom_Patient; set => nom_Patient = value; }
        public string Adresse_Patient { get => adresse_Patient; set => adresse_Patient = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string SexePatient { get => sexePatient; set => sexePatient = value; }
        public static List<Patient> Patients { get => patients; set => patients = value; }
        public string Mdp_Patient { get => mdp_Patient; set => mdp_Patient = value; }
        public string TelPortable_Patient { get => telPortable_Patient; set => telPortable_Patient = value; }

        public static bool Save(Patient p)
        {
            //si le seek renvoit faux on execute AjoutPatient de la classe database
            if (!Seek(p.Mail_Patient, ref p))
            {
                Database.AjoutPatient(p);
                return true;
            }
            //on retourne false si le patient existe deja
            return false;
        }
        public static bool Seek(string code, ref Patient p)
        {
            if (Database.RechercherPatient(code, p))
                return true;
            else
                return false;
        }
        public static bool Modify(Patient p)
        {
            //on crée un patient temporaire
            Patient patTemp = new Patient();
            //et on lui affecte le même code que le patient passé en param afin que p garde les propriétés modifiés quand on fera appel à Seek
            patTemp.Mail_Patient = p.Mail_Patient;
            //on teste d'abord si le patient existe bel et bien dans la bdd
            //si oui on lance la methode de modification contenue dans la classe database
            if (Seek(patTemp.Mail_Patient, ref patTemp))
            {
                Database.ModifierPatient(p);
                return true;
            }
            //on retourne false si le patient n'existe pas
            else
                return false;
        }
        public static bool Delete(Patient p)
        {
            //on teste d'abord si le medecin existe bel et bien dans la bdd
            //si oui o nexecute la requete contenue dans la classe database
            if (Seek(p.Mail_Patient, ref p))
            {
                Database.SupprimerPatient(p);
                return true;
            }
            else//on retourne false si le medecin n'existe pas
                return false;
        }
        public static void FillList()
        {
            Database.ListePatients();
        }
        public static bool CheckLogin(string mail, string mdp, Patient p)
        {
            if (Database.CheckLoginPatient(mail, mdp, p))
                return true;
            else
                return false;
        }

        //public static Patient RechercherPatient(string code)
        //{
        //    //Recherche client par téléphone
        //    return Patients.Find(c => c.codePatient == code);
        //}
    }
}


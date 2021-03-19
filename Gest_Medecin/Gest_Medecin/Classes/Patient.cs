using Gest_Medecin.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Gest_Medecin.Classes
{
    class Patient
    {
        private string codePatient;
        private string nomPatient;
        private string adressePatient;
        private DateTime dateNaissance;
        private string sexePatient;
        private static List<Patient> patients=new List<Patient>();
      

        public string CodePatient { get => codePatient; set => codePatient = value; }
        public string NomPatient { get => nomPatient; set => nomPatient = value; }
        public string AdressePatient { get => adressePatient; set => adressePatient = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string SexePatient { get => sexePatient; set => sexePatient = value; }
        public static List<Patient> Patients { get => patients; set => patients = value; }

        public static bool Save(Patient p)
        {
            //si le seek renvoit faux on execute AjoutPatient de la classe database
            if (!Seek(p.CodePatient, ref p))
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
            patTemp.CodePatient = p.CodePatient;
            //on teste d'abord si le patient existe bel et bien dans la bdd
            //si oui on lance la methode de modification contenue dans la classe database
            if (Seek(patTemp.CodePatient, ref patTemp))
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
            if (Seek(p.CodePatient, ref p))
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
       
        //public static Patient RechercherPatient(string code)
        //{
        //    //Recherche client par téléphone
        //    return Patients.Find(c => c.codePatient == code);
        //}
    }
}

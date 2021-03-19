using Gest_Medecin.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gest_Medecin.Classes
{
    class Medecin
    {
        private string codeMedecin;
        private string nomMedecin;
        private string telMedecin;
        private DateTime dateEmbauche;
        private string specialiteMedecin;
        private static List<Medecin> medecins = new List<Medecin>();

        public string CodeMedecin { get => codeMedecin; set => codeMedecin = value; }
        public string NomMedecin { get => nomMedecin; set => nomMedecin = value; }
        public string TelMedecin { get => telMedecin; set => telMedecin = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        internal string SpecialiteMedecin { get => specialiteMedecin; set => specialiteMedecin = value; }
        public static List<Medecin> Medecins { get => medecins; set => medecins = value; }

        public static bool Save(Medecin m)
        { 
            
            //si le seek renvoit faux on execute AjoutMedecin de la classe database
            if (!Seek(m.CodeMedecin, ref m))
            {
                Database.AjoutMedecin(m);
                return true;            
            }
            //on retourne false si le medecin existe deja
            return false;
        }
        public static bool Seek(string code, ref Medecin m)
        {
            if (Database.RechercherMedecin(code, m))
                return true;
            else
                return false;
        }
        public static bool Modify(Medecin m)
        {
            //on crée un médecin temporaire
            Medecin medTemp = new Medecin();
            //et on lui affecte le même code que le médecin passé en param afin que m garde les propriétés modifiés quand on fera appel à Seek
            medTemp.CodeMedecin = m.CodeMedecin;
            //on teste d'abord si le medecin existe bel et bien dans la bdd
            
            //si oui on lance la methode de modification contenue dans la classe database
            if (Seek(medTemp.CodeMedecin, ref medTemp))
            {
                Database.ModifierMedecin(m);
                return true;       
            }
            //on retourne false si le medecin n'existe pas
            else
                return false;
           

        }
        public static bool Delete(Medecin m)
        {
            //on teste d'abord si le medecin existe bel et bien dans la bdd
            //si oui o nexecute la requete contenue dans la classe database
            if (Seek(m.codeMedecin, ref m))
            {
                Database.SupprimerMedecin(m);
                return true;
            }
            else//on retourne false si le medecin n'existe pas
            return false;
           

        }
        public static void FillList()
        {
            Database.ListeMedecins();
        }
    }
}

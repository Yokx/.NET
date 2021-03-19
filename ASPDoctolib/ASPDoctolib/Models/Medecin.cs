using ASPDoctolib.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Models
{
    public class Medecin
    {
        private string code_Medecin;
        private string nom_Medecin;
        private string tel_Medecin;
        private string specialiteMedecin;
        private string mdp_Medecin;
        private static List<Medecin> medecins = new List<Medecin>();

        public string Code_Medecin { get => code_Medecin; set => code_Medecin = value; }
        public string Nom_Medecin { get => nom_Medecin; set => nom_Medecin = value; }
        public string Tel_Medecin { get => tel_Medecin; set => tel_Medecin = value; }
        public string SpecialiteMedecin { get => specialiteMedecin; set => specialiteMedecin = value; }
        public static List<Medecin> Medecins { get => medecins; set => medecins = value; }
        public string Mdp_Medecin { get => mdp_Medecin; set => mdp_Medecin = value; }

        public static bool Save(Medecin m)
        {

            //si le seek renvoit faux on execute AjoutMedecin de la classe database
            if (!Seek(m.Code_Medecin, ref m))
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
            medTemp.Code_Medecin = m.Code_Medecin;
            //on teste d'abord si le medecin existe bel et bien dans la bdd

            //si oui on lance la methode de modification contenue dans la classe database
            if (Seek(medTemp.Code_Medecin, ref medTemp))
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
            if (Seek(m.code_Medecin, ref m))
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
        public static bool CheckLogin(string code,string mdp, Medecin m)
        {
            if (Database.CheckLoginMedecin(code,mdp, m))
                return true;
            else
                return false;
        }
    }
}

using CompteBancaire.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    class Compte
    {
        private string numeroCompte;
        private double solde;
        private string id_props;
        private static List<Operation> listeOperation;


        public Compte()
        {

        }
    
        public Compte(Client Props)
        {
            Id_props = Props.Id;
            solde = 0;
            ListeOperation = new List<Operation>();
            NumeroCompte = GenererNumero();
            
        }

        public string NumeroCompte { get => numeroCompte; set => numeroCompte = value; }
        public double Solde { get => solde; set => solde = value; }
        
        public static List<Operation> ListeOperation { get => listeOperation; set => listeOperation = value; }
        public string Id_props { get => id_props; set => id_props = value; }

        private static string GenererNumero()
        {
            Random r = new Random();
            string numTMP = "";
            for (int i = 0; i < 5; i++)
            {
                numTMP += r.Next(0, 10);
            }
            return numTMP;
        }
        
        public static bool Save(Compte cl)
        {
            //si le seek renvoit faux on execute AjoutCompte de la classe database
            if (!Seek(cl.NumeroCompte, ref cl))
            {
                Database.AjoutCompte(cl);
                return true;
            }
            //on retourne false si le patient existe deja
            return false;
        }
        public static bool Seek(string num, ref Compte cl)
        {
            if (Database.RechercherCompte(num, cl))
                return true;
            else
                return false;
        }
        
        public static void InitBoxes(List<string>p,string id)
        {
            Database.InitialiserBoxAvecComptesDuClient(p, id);
        }
    }
}

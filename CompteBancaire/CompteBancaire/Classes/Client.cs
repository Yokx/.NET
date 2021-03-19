using CompteBancaire.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    class Client
    {
        private string id;
        private string nom;
        private string prenom;
        private int tel;
        private string adresse;
        private string pass;

        public Client()
        {
          
        }

        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Pass { get => pass; set => pass = value; }


        public static bool Save(Client c)
        {
            //si le seek renvoit faux on execute AjoutPatient de la classe database
            if (!Seek(c.Id, ref c))
            {
                Database.AjoutClient(c);
                return true;
            }
            //on retourne false si le patient existe deja
            return false;
        }
        public static bool Seek(string id, ref Client c)
        {
            if (Database.RechercherClient(id, c))
                return true;
            else
                return false;
        }
        public static bool LoginCheck(string id,string pass, ref Client c)
        {
            if (Database.LoginClient(id,pass, c))
                return true;
            else
                return false;
        }


    }
    }

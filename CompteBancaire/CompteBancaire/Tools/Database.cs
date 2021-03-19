using CompteBancaire.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Tools
{
    class Database
    {
        private static string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\walid\Documents\Gest_CompteBancaire.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection = new SqlConnection(chaine);
        private static SqlCommand command;

        //Méthodes concernant un client

        public static bool RechercherClient(string id,Client c)
        {
            //methode de classe permettant de chercher un client via un id choisi
            //si on le trouve on modifie l'objet client passé en paramètre par référence
            string request = "SELECT * FROM Client WHERE Id_Client=@Id";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Id", id));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                c.Id = id;
                c.Nom = (string)dataReader["Nom_Client"];
                c.Prenom = (string)dataReader["Prenom_Client"];
                c.Tel = Convert.ToInt32(dataReader["Tel_Client"]);
                c.Adresse = (string)dataReader["Adresse_Client"];
                c.Pass = (string)dataReader["Mot_De_Passe"];
                dataReader.Close();
                Database.connection.Close();
                return true;
            }
            else
            {
                dataReader.Close();
                Database.connection.Close();
                return false;
            }
        }
        public static bool LoginClient(string id,string mdp ,Client c)
        {
            //methode de classe permettant de chercher un client via un id choisi et un mot de passe entré
            //si on le trouve on modifie l'objet client passé en paramètre par référence
            string request = "SELECT * FROM Client WHERE Id_Client=@Id AND Mot_De_Passe=@mdp";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Id", id));
            command.Parameters.Add(new SqlParameter("@mdp", mdp));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                c.Id = id;
                c.Nom = (string)dataReader["Nom_Client"];
                c.Prenom = (string)dataReader["Prenom_Client"];
                c.Tel = Convert.ToInt32(dataReader["Tel_Client"]);
                c.Adresse = (string)dataReader["Adresse_Client"];
                c.Pass = (string)dataReader["Mot_De_Passe"];
                dataReader.Close();
                Database.connection.Close();
                return true;
            }
            else
            {
                dataReader.Close();
                Database.connection.Close();
                return false;
            }
        }

        public static bool AjoutClient(Client c)
        {
            int i = 0;
            //ajout d'un client dans la bdd
            string request = "INSERT INTO Client (Id_Client,Nom_Client,Prenom_Client, Tel_Client,Adresse_Client,Mot_De_Passe) VALUES (@Id, @Nom,@Prenom,@Tel,@Adresse,@Mdp)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Id", c.Id));
            command.Parameters.Add(new SqlParameter("@Nom", c.Nom));
            command.Parameters.Add(new SqlParameter("@Prenom", c.Prenom));
            command.Parameters.Add(new SqlParameter("@Tel", c.Tel));
            command.Parameters.Add(new SqlParameter("@Adresse", c.Adresse));
            command.Parameters.Add(new SqlParameter("@Mdp", c.Pass));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }
        public static List<string> InitialiserBoxAvecComptesDuClient(List<string> p,string id)
        {
            //on injecte dans la liste les numér ode compte du client choisi
            Database.connection.Open();
            string request = "SELECT Numero_Compte FROM Compte WHERE Id_Client=@id";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@id", id));

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    p.Add(reader.GetString(0));
                }
                reader.NextResult();
            }

            Database.connection.Close();
            return p;

        }

        //Méthodes concernant un compte

        public static bool RechercherCompte(string num, Compte cl)
        {
            //methode de classe permettant de chercher un compte via le code du compte
            //si on le trouve on modifie l'objet client passé en paramètre par référence
            string request = "SELECT * FROM Compte WHERE Numero_Compte=@num";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", num));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                cl.NumeroCompte = num;
                cl.Solde = Convert.ToDouble(dataReader["Solde_Compte"]);
                cl.Id_props = (string)dataReader["Id_Client"];
                dataReader.Close();
                Database.connection.Close();
                return true;
            }
            else
            {
                dataReader.Close();
                Database.connection.Close();
                return false;
            }
        }
        public static bool AjoutCompte(Compte cl)
        {
            int i = 0;
            //ajout d'un client dans la bdd
            string request = "INSERT INTO Compte (Numero_Compte,Solde_Compte,Id_Client) VALUES (@num, @solde,@idcl)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", cl.NumeroCompte));
            command.Parameters.Add(new SqlParameter("@solde", cl.Solde));
            command.Parameters.Add(new SqlParameter("@idcl", cl.Id_props));
           
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }




    }
}

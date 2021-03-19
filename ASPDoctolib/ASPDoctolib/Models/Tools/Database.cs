using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Models.Tools
{
    public class Database
    {
        private static string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\walid\Documents\Doctolib.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection = new SqlConnection(chaine);
        private static SqlCommand command;

        //Methodes pour Medecin
        public static bool RechercherMedecin(string code, Medecin m)
        {
            //methode de classe permettant de chercher un medecin via un code choisi
            //si on le trouve on modifie l'objet medecin passé en paramètre par référence
            string request = "SELECT * FROM Medecin WHERE Code_Medecin=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", code));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                m.Code_Medecin = code;
                m.Nom_Medecin = (string)dataReader["NomMedecin"];
                m.Tel_Medecin = (string)(dataReader["TelMedecin"]);
                m.SpecialiteMedecin = (string)dataReader["SpecialiteMedecin"];
                m.Mdp_Medecin = (string)dataReader["Mdp_Medecin"];
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

        public static bool AjoutMedecin(Medecin m)
        {
            int i = 0;
            //ajout d'un medecin dans la bdd
            string request = "INSERT INTO Medecin (Code_Medecin,Nom_Medecin,Tel_Medecin,SpecialiteMedecin,Mdp_Medecin) VALUES (@Code,@Nom, @Tel,@Spec,@Mdp)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", m.Code_Medecin));
            command.Parameters.Add(new SqlParameter("@Nom", m.Nom_Medecin));
            command.Parameters.Add(new SqlParameter("@Tel", m.Tel_Medecin));
            command.Parameters.Add(new SqlParameter("@Spec", m.SpecialiteMedecin));
            command.Parameters.Add(new SqlParameter("@Mdp", m.Mdp_Medecin));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;

        }
        public static bool ModifierMedecin(Medecin m)
        {
            int i = 0;
            //modification d'un medecin de la bdd correspondant au médecin passé en paramètre
            string request = "update Medecin set Nom_Medecin=@nom,tel_Medecin=@tel,SpecialiteMedecin=@spec,Mdp_Medecin=@mdp where (CodeMedecin=@code)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", m.Code_Medecin));
            command.Parameters.Add(new SqlParameter("@nom", m.Nom_Medecin));
            command.Parameters.Add(new SqlParameter("@tel", m.Tel_Medecin));
            command.Parameters.Add(new SqlParameter("@spec", m.SpecialiteMedecin));
            command.Parameters.Add(new SqlParameter("@mdp", m.Mdp_Medecin));

            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }
        public static bool SupprimerMedecin(Medecin m)
        {
            int i = 0;
            //suppression d'un medecin de la bdd correspondant au médecin passé en paramètre
            string request = "DELETE FROM Medecin WHERE Code_Medecin=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", m.Code_Medecin));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }

        //Méthodes pour Patient

        public static bool RechercherPatient(string mail, Patient p)
        {
            //methode de classe permettant de chercher un medecin via un code choisi
            //si on le trouve on modifie l'objet medecin passé en paramètre par référence
            string request = "SELECT * FROM Patient WHERE Mail_Patient=@Mail";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Mail", mail));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                p.Mail_Patient = mail;
                p.Nom_Patient = (string)dataReader["Nom_Patient"];
                p.TelPortable_Patient = (string)dataReader["TelPortable_Patient"];
                p.Adresse_Patient = (string)dataReader["Adresse_Patient"];
                p.DateNaissance = (DateTime)dataReader["DateNaissance"];
                p.SexePatient = (string)dataReader["SexePatient"];
                p.Mdp_Patient = (string)dataReader["Mdp_Patient"];
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
        public static bool AjoutPatient(Patient p)
        {
            int i = 0;
            //ajout d'un patient dans la bdd
            string request = "INSERT INTO Patient (Mail_Patient,Nom_Patient,TelPortable_Patient,Adresse_Patient,DateNaissance,SexePatient,Mdp_Patient) VALUES (@Mail, @Nom,@Port,@Adresse,@Date,@Sexe,@Mdp)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Mail", p.Mail_Patient));
            command.Parameters.Add(new SqlParameter("@Nom", p.Nom_Patient));
            command.Parameters.Add(new SqlParameter("@Port", p.TelPortable_Patient));
            command.Parameters.Add(new SqlParameter("@Adresse", p.Adresse_Patient));
            command.Parameters.Add(new SqlParameter("@Date", p.DateNaissance));
            command.Parameters.Add(new SqlParameter("@Sexe", p.SexePatient));
            command.Parameters.Add(new SqlParameter("@Mdp", p.Mdp_Patient));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;

        }
        public static bool ModifierPatient(Patient p)
        {
            int i = 0;
            //on modifie dans la bdd le patient en question
            string request = "update patient set nom_patient=@nom,TelPortable_Patient=@port,adresse_patient=@adresse,datenaissance=@date,sexepatient=@sexe,Mdp_Patient=@mdp where (Mail_patient=@mail)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@mail", p.Mail_Patient));
            command.Parameters.Add(new SqlParameter("@nom", p.Nom_Patient));
            command.Parameters.Add(new SqlParameter("@port", p.TelPortable_Patient));
            command.Parameters.Add(new SqlParameter("@adresse", p.Adresse_Patient));
            command.Parameters.Add(new SqlParameter("@date", p.DateNaissance));
            command.Parameters.Add(new SqlParameter("@sexe", p.SexePatient));
            command.Parameters.Add(new SqlParameter("@mdp", p.Mdp_Patient));

            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }
        public static bool SupprimerPatient(Patient p)
        {
            int i = 0;
            //on supprime le patient
            string request = "DELETE FROM Patient WHERE Mail_Patient=@Mail";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Mail", p.Mail_Patient));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }

        //Méthodes pour RDV
        public static bool AjoutRdv(RDV r)
        {
            int i = 0;
            //ajout d'un nouveau rdv
            string request = "INSERT INTO RDV (DateRDV,HeureRDV,Code_Medecin,Mail_Patient) VALUES (@Date,@Heure, @CodeM,@MailP)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Date", r.DateRDV));
            command.Parameters.Add(new SqlParameter("@Heure", r.HeureRDV));
            command.Parameters.Add(new SqlParameter("@CodeM", r.Code_Medecin));
            command.Parameters.Add(new SqlParameter("@MailP", r.Mail_Patient));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;

        }
        public static bool RechercherRDV(int num, RDV r)
        {
            //methode de classe permettant de chercher un medecin via un code choisi
            //si on le trouve on modifie l'objet medecin passé en paramètre par référence
            string request = "SELECT * FROM RDV WHERE NumeroRDV=@num";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", num));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                r.NumeroRDV = num;
                r.DateRDV = (DateTime)dataReader["DateRDV"];
                r.HeureRDV = (string)dataReader["HeureRDV"];
                r.Code_Medecin = (string)dataReader["Code_Medecin"];
                r.Mail_Patient = (string)dataReader["Mail_Patient"];
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
        public static bool ModifierRdv(RDV r)
        {
            int i = 0;
            //on modifie dans la bdd le rdv en question
            string request = "update RDV set DateRDV=@date,HeureRDV=@heure where (NumeroRDV=@num)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", r.NumeroRDV));
            command.Parameters.Add(new SqlParameter("@date", r.DateRDV));
            command.Parameters.Add(new SqlParameter("@heure", r.HeureRDV));
           

            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }
        public static bool SupprimerRdv(RDV r)
        {
            int i = 0;
            //on supprime le patient
            string request = "DELETE FROM RDV WHERE NumeroRDV=@num";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", r.NumeroRDV));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;
        }

        //Les listes

        public static List<Medecin> ListeMedecins()
        {
            List<Medecin> liste = new List<Medecin>();
            //on remplit la liste avec tous les médecins de la bdd
            string request = "SELECT * FROM Medecin";
            command = new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //string pattern = "dd-MM-yyyy";
                //CultureInfo provider = CultureInfo.InvariantCulture;
                liste.Add(new Medecin() { Code_Medecin = (string)reader["Code_Medecin"], Nom_Medecin = (string)reader["Nom_Medecin"], Tel_Medecin = (string)reader["Tel_Medecin"], SpecialiteMedecin = (string)reader["SpecialiteMedecin"],Mdp_Medecin=(string)reader["Mdp_Medecin"] });
            }
            reader.Close();
            Database.connection.Close();
            return liste;
        }
        public static List<Patient> ListePatients()
        {
            List<Patient> liste = new List<Patient>();
            //on remplit la liste avec tous les patients
            string request = "SELECT * FROM Patient";
            command = new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                liste.Add(new Patient() { Mail_Patient = (string)reader["Mail_Patient"], Nom_Patient = (string)reader["Nom_Patient"],TelPortable_Patient=(string)reader["TelPortable_Patient"], Adresse_Patient = (string)reader["Adresse_Patient"], DateNaissance = (DateTime)reader["DateNaissance"], SexePatient = (string)reader["SexePatient"],Mdp_Patient=(string)reader["Mdp_Patient"] });
            }
            reader.Close();
            Database.connection.Close();
            return liste;
        }
        public static List<RDV> ListeRDV()
        {
            List<RDV> liste = new List<RDV>();
            //methode de classe permettant de remplit la liste avec tous les rdv
            string request = "SELECT * FROM RDV";
            command = new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], Code_Medecin = (string)reader["Code_Medecin"], Mail_Patient = (string)reader["Mail_Patient"] });
            }
            reader.Close();
            Database.connection.Close();
            return liste;
        }
        public static List<RDV> ListeRDVParDateChoisie(DateTime d)
        {
            //methode de classe permettant de chercher les rdv avec une date choisie et remplissant
            //la liste avec ceux-ci
            string request = "SELECT * FROM RDV WHERE DateRDV=@date";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@date", d));
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                RDV.Rdv.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], Code_Medecin = (string)reader["Code_Medecin"], Mail_Patient = (string)reader["Mail_Patient"] });
            }
            reader.Close();
            Database.connection.Close();
            return RDV.Rdv;
        }
        public static List<RDV> ListeRDVParPatientChoisi(string mail)
        {
            List<RDV> liste = new List<RDV>();
            //methode de classe permettant de chercher les rdv d'un patient choisi et remplissant
            //la liste avec ceux-ci
            string request = "SELECT * FROM RDV WHERE Mail_Patient=@mail";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@mail", mail));
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], Code_Medecin = (string)reader["Code_Medecin"], Mail_Patient = (string)reader["Mail_Patient"] });
            }
            reader.Close();
            Database.connection.Close();
            return liste;
        }

        //Initialisation des combobox de GestionRDV

        public static List<string> InitialiserBoxPatients(List<string> p)
        {
            //on injecte dans nos deux listes les codes patients contenus dans la bdd
            Database.connection.Open();
            string request = "SELECT Mail_Patient FROM Patient";
            command = new SqlCommand(request, Database.connection);

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
        public static List<string> InitialiserBoxMedecins(List<string> m)
        {
            //on injecte dans nos deux listes les codes medecins contenus dans la bdd
            Database.connection.Open();
            string request = "SELECT Code_Medecin FROM Medecin";
            command = new SqlCommand(request, Database.connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    m.Add(reader.GetString(0));
                }
                reader.NextResult();
            }

            Database.connection.Close();
            return m;

        }
        public static bool CheckLoginMedecin(string code, string mdp, Medecin m)
        {
            
            string request = "SELECT * FROM Medecin WHERE Code_Medecin=@code AND Mdp_Medecin=@mdp";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", code));
            command.Parameters.Add(new SqlParameter("@mdp", mdp));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                m.Code_Medecin = code;
                m.Nom_Medecin = (string)dataReader["Nom_Medecin"];
                m.Tel_Medecin = (string)dataReader["Tel_Medecin"];
                m.SpecialiteMedecin = (string)dataReader["SpecialiteMedecin"];
                m.Mdp_Medecin = mdp;
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
        public static bool CheckLoginPatient(string mail, string mdp, Patient p)
        {

            string request = "SELECT * FROM Patient WHERE Mail_Patient=@mail AND Mdp_Patient=@mdp";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@mail", mail));
            command.Parameters.Add(new SqlParameter("@mdp", mdp));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                p.Mail_Patient = mail;
                p.Nom_Patient = (string)dataReader["Nom_Patient"];
                p.TelPortable_Patient = (string)dataReader["TelPortable_Patient"];
                p.Adresse_Patient = (string)dataReader["Adresse_Patient"];
                p.DateNaissance = (DateTime)dataReader["DateNaissance"];
                p.SexePatient = (string)dataReader["SexePatient"];
                p.Mdp_Patient = mdp;
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
    }
}

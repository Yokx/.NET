using Gest_Medecin.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Medecin.Tools
{
    class Database
    {
        private static string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\walid\Documents\Gest_RDV_Docto.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection = new SqlConnection(chaine);
        private static SqlCommand command;

        //Methodes pour Medecin
        public static bool RechercherMedecin(string code, Medecin m)
        {
            //methode de classe permettant de chercher un medecin via un code choisi
            //si on le trouve on modifie l'objet medecin passé en paramètre par référence
            string request = "SELECT * FROM Medecin WHERE CodeMedecin=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", code));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                m.CodeMedecin = code;
                m.NomMedecin = (string)dataReader["NomMedecin"];
                m.TelMedecin = (string)(dataReader["TelMedecin"]);
                m.DateEmbauche = (DateTime)dataReader["DateEmbauche"];
                m.SpecialiteMedecin = (string)dataReader["SpecialiteMedecin"];
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
            string request = "INSERT INTO Medecin (CodeMedecin,NomMedecin,TelMedecin,DateEmbauche,SpecialiteMedecin) VALUES (@Code,@Nom, @Tel,@Date,@Spec)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", m.CodeMedecin));
            command.Parameters.Add(new SqlParameter("@Nom", m.NomMedecin));
            command.Parameters.Add(new SqlParameter("@Tel", m.TelMedecin));
            command.Parameters.Add(new SqlParameter("@Date", m.DateEmbauche));
            command.Parameters.Add(new SqlParameter("@Spec", m.SpecialiteMedecin));
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
            string request = "update Medecin set NomMedecin=@nom,telMedecin=@tel,DateEmbauche=@date,SpecialiteMedecin=@spec where (CodeMedecin=@code)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", m.CodeMedecin));
            command.Parameters.Add(new SqlParameter("@nom", m.NomMedecin));
            command.Parameters.Add(new SqlParameter("@tel", m.TelMedecin));
            command.Parameters.Add(new SqlParameter("@date", m.DateEmbauche));
            command.Parameters.Add(new SqlParameter("@spec", m.SpecialiteMedecin));

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
            string request = "DELETE FROM Medecin WHERE CodeMedecin=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", m.CodeMedecin));
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

        public static bool RechercherPatient(string code, Patient p)
        {
            //methode de classe permettant de chercher un medecin via un code choisi
            //si on le trouve on modifie l'objet medecin passé en paramètre par référence
            string request = "SELECT * FROM Patient WHERE CodePatient=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", code));

            Database.connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            //on teste d'abord s'il a trouvé un enregistrement
            if (dataReader.HasRows)
            {
                dataReader.Read();
                p.CodePatient = code;
                p.NomPatient = (string)dataReader["NomPatient"];
                p.AdressePatient = (string)dataReader["AdressePatient"];
                p.DateNaissance = (DateTime)dataReader["DateNaissance"];
                p.SexePatient = (string)dataReader["SexePatient"]; 
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
            string request = "INSERT INTO Patient (CodePatient,NomPatient,AdressePatient,DateNaissance,SexePatient) VALUES (@Code, @Nom,@Adresse,@Date,@Sexe)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Code", p.CodePatient));
            command.Parameters.Add(new SqlParameter("@Nom", p.NomPatient));
            command.Parameters.Add(new SqlParameter("@Adresse", p.AdressePatient));
            command.Parameters.Add(new SqlParameter("@Date", p.DateNaissance));
            command.Parameters.Add(new SqlParameter("@Sexe", p.SexePatient));
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
            string request = "update patient set nompatient=@nom,adressepatient=@adresse,datenaissance=@date,sexepatient=@sexe where (codepatient=@code)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", p.CodePatient));
            command.Parameters.Add(new SqlParameter("@nom", p.NomPatient));
            command.Parameters.Add(new SqlParameter("@adresse", p.AdressePatient));
            command.Parameters.Add(new SqlParameter("@date", p.DateNaissance));
            command.Parameters.Add(new SqlParameter("@sexe", p.SexePatient));

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
            string request = "DELETE FROM Patient WHERE CodePatient=@Code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", p.CodePatient));
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
            string request = "INSERT INTO RDV (DateRDV,HeureRDV,CodeMedecin,CodePatient) VALUES (@Date,@Heure, @CodeM,@CodeP)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@Date", r.DateRDV));
            command.Parameters.Add(new SqlParameter("@Heure", r.HeureRDV));
            command.Parameters.Add(new SqlParameter("@CodeM", r.CodeMedecin));
            command.Parameters.Add(new SqlParameter("@CodeP", r.CodePatient));
            Database.connection.Open();
            i = command.ExecuteNonQuery();
            command.Dispose();
            Database.connection.Close();
            if (i != 0)
                return true;
            else
                return false;

        }
        public static bool ModifierRdv(RDV r)
        {
            int i = 0;
            //on modifie dans la bdd le rdv en question
            string request = "update RDV set DateRDV=@date,HeureRDV=@heure,CodeMedecin=@code where (NumeroRDV=@num)";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@num", r.NumeroRDV));
            command.Parameters.Add(new SqlParameter("@date", r.DateRDV));
            command.Parameters.Add(new SqlParameter("@heure", r.HeureRDV));
            command.Parameters.Add(new SqlParameter("@code", r.CodeMedecin));

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
            if (i != 0)
                return true;
            else
                return false;
        }

        //Les listes

        public static List<Medecin> ListeMedecins()
        {
            //on remplit la liste avec tous les médecins de la bdd
            string request = "SELECT * FROM Medecin";
            command= new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //string pattern = "dd-MM-yyyy";
                //CultureInfo provider = CultureInfo.InvariantCulture;
                Medecin.Medecins.Add(new Medecin() { CodeMedecin = (string)reader["CodeMedecin"], NomMedecin = (string)reader["NomMedecin"], TelMedecin = (string)reader["TelMedecin"], DateEmbauche = (DateTime)reader["DateEmbauche"], SpecialiteMedecin = (string)reader["SpecialiteMedecin"] });
            }
            reader.Close();
            Database.connection.Close();
            return Medecin.Medecins;
        }
        public static List<Patient> ListePatients()
        {
            //on remplit la liste avec tous les patients
            string request = "SELECT * FROM Patient";
            command = new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Patient.Patients.Add(new Patient() { CodePatient = (string)reader["CodePatient"], NomPatient = (string)reader["NomPatient"], AdressePatient = (string)reader["AdressePatient"], DateNaissance = (DateTime)reader["DateNaissance"], SexePatient = (string)reader["SexePatient"] });
            }
            reader.Close();
            Database.connection.Close();
            return Patient.Patients;
        }
        public static List<RDV> ListeRDV()
        {
            //methode de classe permettant de remplit la liste avec tous les rdv
            string request = "SELECT * FROM RDV";
            command = new SqlCommand(request, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                RDV.Rdv.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], CodeMedecin = (string)reader["CodeMedecin"], CodePatient = (string)reader["CodePatient"] });
            }
            reader.Close();
            Database.connection.Close();
            return RDV.Rdv;
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
                RDV.Rdv.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], CodeMedecin = (string)reader["CodeMedecin"], CodePatient = (string)reader["CodePatient"] });
            }
            reader.Close();
            Database.connection.Close();
            return RDV.Rdv;
        }
        public static List<RDV> ListeRDVParPatientChoisi(string code)
        {
            //methode de classe permettant de chercher les rdv d'un patient choisi et remplissant
            //la liste avec ceux-ci
            string request = "SELECT * FROM RDV WHERE CodePatient=@code";
            command = new SqlCommand(request, Database.connection);
            command.Parameters.Add(new SqlParameter("@code", code));
            Database.connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                RDV.Rdv.Add(new RDV() { NumeroRDV = (int)reader["NumeroRDV"], DateRDV = (DateTime)reader["DateRDV"], HeureRDV = (string)reader["HeureRDV"], CodeMedecin = (string)reader["CodeMedecin"], CodePatient = (string)reader["CodePatient"] });
            }
            reader.Close();
            Database.connection.Close();
            return RDV.Rdv;
        }

        //Initialisation des combobox de GestionRDV

        public static List<string> InitialiserBoxPatients(List<string>p)
        {
            //on injecte dans nos deux listes les codes patients contenus dans la bdd
            Database.connection.Open();
            string request = "SELECT CodePatient FROM Patient";
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
        public static List<string> InitialiserBoxMedecins(List<string>m)
        {
            //on injecte dans nos deux listes les codes medecins contenus dans la bdd
            Database.connection.Open();
            string request = "SELECT CodeMedecin FROM Medecin";
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


    }
}

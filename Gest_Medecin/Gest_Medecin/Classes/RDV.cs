using Gest_Medecin.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Medecin.Classes
{
    class RDV
    {
        private int numeroRDV;
        private string codeMedecin;
        private string codePatient;
        private DateTime dateRDV;
        private string heureRDV;
        private static List<RDV> rdv = new List<RDV>();

        public DateTime DateRDV { get => dateRDV; set => dateRDV = value; }
        public string HeureRDV { get => heureRDV; set => heureRDV = value; }
        public string CodeMedecin { get => codeMedecin; set => codeMedecin = value; }
        public string CodePatient { get => codePatient; set => codePatient = value; }
        public static List<RDV> Rdv { get => rdv; set => rdv = value; }
        public int NumeroRDV { get => numeroRDV; set => numeroRDV = value; }

        public static void InitBoxes( List<string> m,  List<string> p)
        {
            Database.InitialiserBoxPatients(p);
            Database.InitialiserBoxMedecins(m);

        }

        public static bool Save(RDV r)
        {
            Database.AjoutRdv(r);
            return true;
        }
        public static void FillList()
        {
            Database.ListeRDV();
        }
        public static void FillListWithSelectedDate(DateTime d)
        {
            Database.ListeRDVParDateChoisie(d);
        }
        public static void FillListWithChosenPatient(string code)
        {
            Database.ListeRDVParPatientChoisi(code);
        }
        public static bool Modify(RDV r)
        {
            Database.ModifierRdv(r);
            return true;

        }
        public static bool Delete(RDV r)
        {
            Database.SupprimerRdv(r);
            return true;
        }


    }
}

using ASPDoctolib.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Models
{
    public class RDV
    {
        private int numeroRDV;
        private string code_Medecin;
        private string mail_Patient;
        private DateTime dateRDV;
        private string heureRDV;
        private static List<RDV> rdv = new List<RDV>();

        public DateTime DateRDV { get => dateRDV; set => dateRDV = value; }
        public string HeureRDV { get => heureRDV; set => heureRDV = value; }
        public string Code_Medecin { get => code_Medecin; set => code_Medecin = value; }
        public string Mail_Patient { get => mail_Patient; set => mail_Patient = value; }
        public static List<RDV> Rdv { get => rdv; set => rdv = value; }
        public int NumeroRDV { get => numeroRDV; set => numeroRDV = value; }

        public static void InitBoxes(List<string> m, List<string> p)
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

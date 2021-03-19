using ASPDoctolib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASPDoctolib.ViewModels
{
    public class RDVMedecinPatientViewModel
    {
        public List<RDV> Rdvs { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Medecin> Medecins { get; set; }
    }
}

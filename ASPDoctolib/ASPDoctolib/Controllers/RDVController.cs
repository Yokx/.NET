using ASPDoctolib.Models;
using ASPDoctolib.Models.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Controllers
{
    public class RDVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListeRDV()
        {
            List<RDV> Liste = Database.ListeRDV();
            return View(Liste);
        }
        public IActionResult AjouterRDV()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult SubmitFormAjoutRDVFromPatient(DateTime dateRDV,string inputHeure, string inputCodeMedecin,string inputMailPatient)
        {
            if (dateRDV != null && inputHeure != null && inputCodeMedecin != null && inputMailPatient != null)
            {
                RDV r = new RDV();
                r.DateRDV = dateRDV;
                r.HeureRDV = inputHeure;
                r.Code_Medecin = inputCodeMedecin;
                r.Mail_Patient = inputMailPatient;
                
                if (RDV.Save(r))
                {
                    Patient p = new Patient();
                    Patient.Seek(inputMailPatient, ref p);
                    return RedirectToAction("MesRDV", "Patient", p);
                }
                else
                {
                    return RedirectToAction("MesRDV", "Patient", new { message = "Erreur le rendez-vous n'a pas été ajouté dans la base de données" });
                }
            }
            else
            {
                return RedirectToAction("MesRDV", "Patient", new { message = "Merci de remplir tous les champs" });
            }
               
        }
        [HttpPost]
       public IActionResult SubmitFormDeleteRDVFromPatient(int NumRDV)
        {
            RDV r = new RDV();
            Database.RechercherRDV(NumRDV, r);
            Patient p = new Patient();
            p.Mail_Patient = HttpContext.Session.GetString("MailPatient");
            Patient.Seek(p.Mail_Patient, ref p);
            if (RDV.Delete(r))
                return RedirectToAction("MesRDV", "Patient", p);
            else
                return RedirectToAction ("MesRDV", "Patient", new { message = "Erreur le rendez-vous n'a pas été supprimé de la base de données" });

        }
        [HttpPost]
        public IActionResult SubmitFormModifyRDVFromPatient(int inputNum, DateTime inputDate, string inputHeure,string inputCode)
        {

            if (inputDate != null && inputHeure != null)
            {
                RDV r = new RDV();
                //Database.RechercherRDV(inputNum, r);
                r.NumeroRDV = inputNum;
                r.DateRDV = inputDate;
                r.HeureRDV = inputHeure;
                r.Code_Medecin = inputCode;
                r.Mail_Patient = HttpContext.Session.GetString("MailPatient");
               
              
                if (RDV.Modify(r))
                {
                    Patient p = new Patient();
                    p.Mail_Patient = HttpContext.Session.GetString("MailPatient");
                    Patient.Seek(p.Mail_Patient, ref p);
                    return RedirectToAction("MesRDV", "Patient", p);
                }
                else
                {
                    return RedirectToAction("MesRDV", "Patient", new { message = "Erreur le rendez-vous n'a pas été modifié dans la base de données" });
                }
            }
            else
            {
                return RedirectToAction("MesRDV", "Patient", new { message = "Merci de remplir tous les champs" });
            }
        }

    }
}

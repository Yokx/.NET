using ASPDoctolib.Models;
using ASPDoctolib.Models.Tools;
using ASPDoctolib.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ASPDoctolib.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListePatient()
        {
            List<Patient> Liste = Database.ListePatients();
            return View(Liste);
        }
        public IActionResult InscriptionPatient()
        {
            return View();
        }
        public IActionResult LoginPatient()
        {
            return View();
        }
        public IActionResult MesRDV(Patient p)
        {
            Patient.Seek(HttpContext.Session.GetString("MailPatient"), ref p);
            ViewBag.Patient = p;
            List<RDV> listeRdvPatient = Database.ListeRDVParPatientChoisi(p.Mail_Patient);
            List<Medecin> listeMedecins = Database.ListeMedecins();
            RDVMedecinPatientViewModel vModel = new RDVMedecinPatientViewModel();
            vModel.Rdvs = listeRdvPatient;
            vModel.Medecins = listeMedecins;

            return View(vModel);
        }
        [HttpPost]
        public IActionResult SubmitFormPatient(string inputEmail4, string inputName, string inputTel, string inputAddress, DateTime dateNaissance, string gridRadios1, string gridRadios2, string inputPassword4)
        {
            if (inputEmail4 != null && inputName != null && inputTel != null && inputAddress!=null && dateNaissance!=null && inputPassword4!=null)
            {
                Patient p = new Patient();
                p.Mail_Patient = inputEmail4;
                p.Nom_Patient = inputName;
                p.TelPortable_Patient = inputTel;
                p.Adresse_Patient = inputAddress;
                p.DateNaissance = dateNaissance;
                if (gridRadios1 == null)
                    p.SexePatient = "F";
                else
                    p.SexePatient = "H";
                p.Mdp_Patient = inputPassword4;
                if (Patient.Save(p))
                {
                    return RedirectToAction("LoginPatient", "Patient", new { message = "Patient Ajouté" });
                }
                else
                {
                    ViewBag.MessageError = "Erreur d'insertion dans la base de données";
                    return View("InscriptionPatient");
                }
            }
            else
            {
                ViewBag.MessageError = "Merci de remplir la totalité des champs";
                return View("InscriptionPatient");
            }
        }
        [HttpPost]
        public IActionResult SubmitLoginPatient(string inputEmail4, string inputPassword4)
        {
            if (inputEmail4 != null && inputPassword4 != null)
            {
                Patient p = new Patient();
                p.Mail_Patient = inputEmail4;
                p.Mdp_Patient = inputPassword4;
                if (Patient.CheckLogin(p.Mail_Patient, p.Mdp_Patient, p))
                {
                    HttpContext.Session.Clear();
                    HttpContext.Session.SetString("MailPatient", p.Mail_Patient);
                    return RedirectToAction("MesRDV", "Patient", p);
                }
                else
                {
                    ViewBag.MessageError = "Identifiants incorrects";
                    return View("LoginPatient");
                }
            }
            else
            {
                ViewBag.MessageError = "Merci de remplir la totalité des champs";
                return View("LoginPatient");
            }
        }
        [HttpPost]
        public IActionResult SubmitFormModifyPatient(string inputMail,string inputNom,string inputTel,string inputAdresse)
        {
            if (inputNom != null && inputTel != null && inputAdresse!=null)
            {
                Patient p = new Patient();
                p.Mail_Patient = inputMail;
                Patient.Seek(p.Mail_Patient,ref p);
                p.Nom_Patient = inputNom;
                p.TelPortable_Patient = inputTel;
                p.Adresse_Patient = inputAdresse;
               
                if (Patient.Modify(p))
                {
                    
                    return RedirectToAction("MesRDV", "Patient", p);
                }
                else
                {
                    ViewBag.MessageError = "Identifiants incorrects";
                    return RedirectToAction("MesRDV","Patient",p);
                }
            }
            else
            {
                ViewBag.MessageError = "Merci de remplir la totalité des champs";
                return View("MesRDV");
            }

        }
        public IActionResult DisconnectPatient()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }





    }

}


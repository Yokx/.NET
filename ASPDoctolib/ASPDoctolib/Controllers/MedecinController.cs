using ASPDoctolib.Models;
using ASPDoctolib.Models.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDoctolib.Controllers
{
    public class MedecinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListeMedecin()
        {
            List<Medecin> Liste = Database.ListeMedecins();//Medecin.FillList();
            return View(Liste);
        }
        public IActionResult InscriptionMedecin()
        {
            
            return View();
        }
        public IActionResult LoginMedecin()
        {

            return View();
        }
        public IActionResult MesInfos(Medecin m)
        {
            ViewBag.Medecin = m;
            return View();
        }
        [HttpPost]
        public IActionResult SubmitFormMedecin(string inputCode14,string inputName, string inputTel,string inputSpec,string inputPassword4)
        {
            if (inputCode14 != null && inputName != null && inputTel != null && inputSpec!=null && inputPassword4 != null)
            {
                Medecin m = new Medecin();
                m.Code_Medecin = inputCode14;
                m.Nom_Medecin = inputName;
                m.Tel_Medecin = inputTel;
                m.SpecialiteMedecin = inputSpec;
                m.Mdp_Medecin = inputPassword4;
                if (Medecin.Save(m))
                {
                    return RedirectToAction("LoginMedecin", "Medecin", new { message = "Medecin Ajouté" });
                }
                else
                {
                    ViewBag.MessageError = "Erreur d'insertion dans la base de données";
                    return View("InscriptionMedecin");
                }
            }
            else
            {
                ViewBag.MessageError = "Merci de remplir la totalité des champs";
                return View("InscriptionMedecin");
            }
        }
        [HttpPost]
        public IActionResult SubmitLoginMedecin(string inputCode14,string inputPassword4)
        {
            if (inputCode14 != null && inputPassword4 != null)
            {
                Medecin m = new Medecin();
                m.Code_Medecin = inputCode14;
                m.Mdp_Medecin = inputPassword4;
                if (Medecin.CheckLogin(m.Code_Medecin,m.Mdp_Medecin,m))
                {
                    HttpContext.Session.Clear();
                    HttpContext.Session.SetString("CodeMedecin", m.Code_Medecin);
                    return RedirectToAction("MesInfos", "Medecin", m);
                }
                else
                {
                    ViewBag.MessageError = "Identifiants incorrects";
                    return View("LoginMedecin");
                }
            }
            else
            {
                ViewBag.MessageError = "Merci de remplir la totalité des champs";
                return View("LoginMedecin");
            }
        }
        public IActionResult Search(string search)
        {
            
            return View();
        }
       

    }
}

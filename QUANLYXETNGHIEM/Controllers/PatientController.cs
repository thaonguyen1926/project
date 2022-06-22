using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            PatientInfo patientInfo = new PatientInfo();
            return View(patientInfo);
        }
        [HttpPost]
        public ActionResult Index(PatientInfo patientInfo, string SubmitName, FormCollection form)
        {
            PatientInfo patientInfo_return = new PatientInfo();
            try
            {
                PatientService patientService = new PatientService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    patientService.InsertPatient(patientInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    patientService.UpdatePatient(patientInfo);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    patientService.DeletePatient(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(patientInfo_return);

        }
    }
}
using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            return View(doctorInfo);
        }
        [HttpPost]
        public ActionResult Index(DoctorInfo doctorInfo, string SubmitName, FormCollection form)
        {
            DoctorInfo doctorInfo_return = new DoctorInfo();
            try
            {
                DoctorService doctorService = new DoctorService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    doctorService.InsertDoctor(doctorInfo_return);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    doctorService.UpdateDoctor(doctorInfo_return);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    doctorService.DeleteDoctor(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(doctorInfo_return);

        }
       
    }
}
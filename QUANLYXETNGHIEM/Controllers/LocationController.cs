using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
//using System.Activities.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            LocationInfo locationInfo = new LocationInfo();
            return View(locationInfo);
        }
        [HttpPost]
        public ActionResult Index(LocationInfo locationInfo, string SubmitName, FormCollection form)
        {
            LocationInfo LocationInfo_return = new LocationInfo();
            try
            {
                LocationService locationService = new LocationService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    locationService.InsertLocation(locationInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    locationService.UpdateLocation(locationInfo);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    locationService.DeleteLocation(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(LocationInfo_return);

        }
    }
}
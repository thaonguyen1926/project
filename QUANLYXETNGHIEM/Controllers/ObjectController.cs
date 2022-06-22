using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class ObjectController : Controller
    {
        // GET: Object
        public ActionResult Index()
        {
            ObjectInfo objectInfo = new ObjectInfo();
            return View(objectInfo);
        }
        [HttpPost]
        public ActionResult Index(ObjectInfo objectInfo, string SubmitName, FormCollection form)
        {
            ObjectInfo objectInfo_return = new ObjectInfo();
            try
            {
                ObjectService objectService = new ObjectService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    objectService.InsertObject(objectInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    objectService.UpdateObject(objectInfo);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    objectService.DeleteObject(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(objectInfo_return);

        }
    }
}
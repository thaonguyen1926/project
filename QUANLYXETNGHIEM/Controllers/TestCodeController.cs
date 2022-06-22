using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class TestCodeController : Controller
    {
        // GET: TestCode
        public ActionResult Index()
        {
            TestCodeInfo testcodeInfo = new TestCodeInfo();
            return View(testcodeInfo);
        }
        [HttpPost]
        public ActionResult Index(TestCodeInfo testcodeInfo, string SubmitName, FormCollection form)
        {
            TestCodeInfo testcodeInfo_return = new TestCodeInfo();
            try
            {
                TestCodeService testcodeService = new TestCodeService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    testcodeService.InsertTestCode(testcodeInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    testcodeService.UpdateTestCode(testcodeInfo);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    testcodeService.DeleteTestCode(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(testcodeInfo_return);

        }
    }
}
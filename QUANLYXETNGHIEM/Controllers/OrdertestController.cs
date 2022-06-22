using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class OrdertestController : Controller
    {
        // GET: OrderTest
        public ActionResult Index()
        {
            OrderTestInfo ordertestInfo = new OrderTestInfo();
            return View(ordertestInfo);
        }
        [HttpPost]
        public ActionResult Index(OrderTestInfo ordertestInfo, string SubmitName, FormCollection form)
        {
            OrderTestInfo ordertestInfo_return = new OrderTestInfo();
            try
            {
                OrderTestService ordertestService = new OrderTestService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    ordertestService.InsertOrderTest(ordertestInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    ordertestService.UpdateOrderTest(ordertestInfo);
                }
                if (SubmitName.IndexOf("Delete") > -1) //Thêm mới nhóm xn
                {
                    ordertestService.DeleteOrderTest(SubmitName.Replace("Delete", ""));
                }
            }
            catch
            {

            }
            return View(ordertestInfo_return);

        }
    }
}
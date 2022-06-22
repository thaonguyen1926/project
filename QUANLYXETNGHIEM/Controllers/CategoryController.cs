using QUANLYXETNGHIEM.DLL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QUANLYXETNGHIEM.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CategoryInfo categoryInfo = new CategoryInfo();
            return View(categoryInfo);
        }
        [HttpPost]
        public ActionResult Index(CategoryInfo categoryInfo, string SubmitName, FormCollection form)
        {
            CategoryInfo categoryInfo_return = new CategoryInfo();
            try
            {
                CategoryService categoryService = new CategoryService();
                if (SubmitName == "AddNew") //Thêm mới nhóm xn
                {
                    categoryService.InsertCategory(categoryInfo);
                }
                if (SubmitName == "Edit") //Thêm mới nhóm xn
                {
                    categoryService.UpdateCategory(categoryInfo);
                }
                if (SubmitName.IndexOf("Delete")>-1) //Thêm mới nhóm xn
                {
                    categoryService.DeleteCategory(SubmitName.Replace("Delete",""));
                }
            }
            catch 
            {

            }
            return View(categoryInfo_return);

        }
    }
}
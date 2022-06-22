using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{
    public class CategoryService
    {
        public List<CategoryInfo> GetListCategory()
        {
            List<CategoryInfo> _listcategory = new List<CategoryInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_Category");
                foreach (DataRow item in resuset.Rows)
                {
                    CategoryInfo _item = new CategoryInfo(item["CategoryID"].ToString(), item["CategoryName"].ToString());
                    _listcategory.Add(_item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return _listcategory;
        }
        public bool InsertCategory(CategoryInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_Category(CategoryID,CategoryName) VALUES ('" + _info.CategoryID + "',N'" + _info.CategoryName + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateCategory(CategoryInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("Update tbl_Category set CategoryName=N'" + _info.CategoryName + "' WHERE CategoryID='" + _info.CategoryID + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean DeleteCategory(String _categoryid)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_Category WHERE CategoryID='" + _categoryid + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}

using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class CategoryInfo
    {
        public String CategoryID { get; set; }
        public String CategoryName { get; set; }
        public CategoryInfo(String CategoryID, String CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }
        public CategoryInfo()
        {
        }
        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<CategoryInfo> GetListCategory()
        {
            CategoryService categoryService = new CategoryService();
            return categoryService.GetListCategory();
        }
        
        public bool Delete(string _id)
        {
            CategoryService categoryService = new CategoryService();
            return categoryService.DeleteCategory(_id);
        }
    }
}
    

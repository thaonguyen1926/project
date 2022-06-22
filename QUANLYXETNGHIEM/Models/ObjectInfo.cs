using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class ObjectInfo
    {
        public String ObjectID { get; set; }
        public String ObjectName { get; set; }

       

        public ObjectInfo(String ObjectID, String ObjectName)
        {
            this.ObjectID = ObjectID;
            this.ObjectName = ObjectName;
        }
        public ObjectInfo()
        {
        }
        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<ObjectInfo> GetListObject()
        {
            ObjectService objectService = new ObjectService();
            return objectService.GetListObject();
        }

        public bool Delete(string _id)
        {
            ObjectService objectService = new ObjectService();
            return objectService.DeleteObject(_id);
        }
    }
}

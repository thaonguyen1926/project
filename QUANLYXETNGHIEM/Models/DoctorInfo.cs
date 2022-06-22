using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class DoctorInfo
    {
        public String DoctorID { get; set; }
        public String DoctorName { get; set; }

        public DoctorInfo()
        {
        }

        public DoctorInfo(String DoctorID, String DoctorName)
        {
            this.DoctorID = DoctorID;
            this.DoctorName = DoctorName;
        }
        /// <summary>
        /// Lấy danh để trả về view
        /// </summary>
        /// <returns></returns>
        public List<DoctorInfo> GetListCategory()
        {
            DoctorService _service = new DoctorService();
            return _service.GetListDoctor();
        }
        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public bool Delete(string _id)
        {
            DoctorService _service = new DoctorService();
            return _service.DeleteDoctor(_id);
        }
    }
}


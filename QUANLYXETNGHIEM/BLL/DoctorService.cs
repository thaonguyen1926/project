

using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{
    public class DoctorService
    {
        public List<DoctorInfo> GetListDoctor()
        {
            List<DoctorInfo> _listdoctor = new List<DoctorInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_Doctor");
                foreach (DataRow item in resuset.Rows)
                {
                    DoctorInfo _item = new DoctorInfo(item["DoctorID"].ToString(), item["DoctorName"].ToString());
                    _listdoctor.Add(_item);
                }
            }
            catch (Exception)
            {

            }
            return _listdoctor;
        }
        public Boolean InsertDoctor(DoctorInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_Doctor(DoctorID,DoctorName) VALUES ('" + _info.DoctorID + "',N'" + _info.DoctorName + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateDoctor(DoctorInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("Update tbl_Doctor set DoctorName=N'" + _info.DoctorName + "' WHERE DoctorID='" + _info.DoctorID + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean DeleteDoctor(String _doctorid)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_Doctor WHERE DoctorID='" + _doctorid + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
    
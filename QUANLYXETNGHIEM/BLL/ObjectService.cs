
using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{
    public class ObjectService
    {
        public List<ObjectInfo> GetListObject()
        {
            List<ObjectInfo> _listobject = new List<ObjectInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_Object");
                foreach (DataRow item in resuset.Rows)
                {
                    ObjectInfo _item = new ObjectInfo(item["ObjectID"].ToString(), item["ObjectName"].ToString());
                    _listobject.Add(_item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return _listobject;
        }
        public bool InsertObject(ObjectInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_Object(ObjectID,ObjectName) VALUES ('" + _info.ObjectID + "',N'" + _info.ObjectName + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateObject(ObjectInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("Update tbl_Object set ObjectID='" + _info.ObjectID + "' WHERE ObjectName=N'" + _info.ObjectName + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean DeleteObject(String _objectid)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_Object WHERE ObjectID='" + _objectid + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}

   
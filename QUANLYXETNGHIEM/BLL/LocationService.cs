
using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{
    public class LocationService
    {
        public List<LocationInfo> GetListLocation()
        {

            List<LocationInfo> _listlocation = new List<LocationInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_Location");
                foreach (DataRow item in resuset.Rows)
                {
                    LocationInfo _item = new LocationInfo(item["LocationID"].ToString(), item["LocationName"].ToString());
                    _listlocation.Add(_item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return _listlocation;
        }
        public bool InsertLocation(LocationInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_Category(LocationID,LocationName) VALUES ('" + _info.LocationID + "',N'" + _info.LocationName + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateLocation(LocationInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_Location(LocationID,LocationName) VALUES ('" + _info.LocationID + "',N'" + _info.LocationName + "')") > 0;
            }
            catch (Exception)
            {
                
            }
            return false;
        }
        public Boolean DeleteLocation(String _locationid)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_Location WHERE LocationID='" + _locationid + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }

    }
}
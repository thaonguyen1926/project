using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class LocationInfo
    {
        public String LocationID { get; set; }
        public String LocationName { get; set; }

        //public String getLocationID()
        //{
        //    return LocationID;
        //}

        //public void setLocationID(String LocationID)
        //{
        //    this.LocationID = LocationID;
        //}

        //public String getLocationName()
        //{
        //    return LocationName;
        //}

        //public void setLocationName(String LocationName)
        //{
        //    this.LocationName = LocationName;
        //}

        //public LocationInfo()
        //{
        //}

        public LocationInfo(String LocationID, String LocationName)
        {
            this.LocationID = LocationID;
            this.LocationName = LocationName;
        }

        public LocationInfo()
        {
        }
        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<LocationInfo> GetListLocation()
        {
            LocationService locationService = new LocationService();
            return locationService.GetListLocation();
        }

        public bool Delete(string _id)
        {
            LocationService locationService = new LocationService();
            return locationService.DeleteLocation(_id);
        }
    }

}

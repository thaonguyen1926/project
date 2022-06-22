
using Microsoft.VisualBasic;
using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{

    public class OrderTestService
    {
        public List<OrderTestInfo> GetListOrderTest()
        {
            List<OrderTestInfo> _listorderTest = new List<OrderTestInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_OrderTest");
                foreach (DataRow item in resuset.Rows)
                {
                    OrderTestInfo _item = new OrderTestInfo(item["SID"].ToString(), item["TestCode"].ToString(), Convert.ToDateTime(item["OrderDate"]), Convert.ToDateTime(item["ResultDate"]), item["Result"].ToString(), item["NormalFact"].ToString());
                    _listorderTest.Add(_item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return _listorderTest;
        }
        public Boolean InsertOrderTest(OrderTestInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_OrderTest(SID,TestCode,Result,OrderDate,ResultDate,NormalFact) VALUES ('" + _info.SID + "','" + _info.TestCode + "','" + _info.Result + "','" + _info.OrderDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + _info.ResultDate.ToString("yyyy-MM-dd HHm:ss") + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateOrderTest(OrderTestInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("Update tbl_OrderTest set SID='" + _info.SID + "' WHERE TestCode='" + _info.TestCode + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean DeleteOrderTest(String _SID)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_OrderTest WHERE SID='" + _SID + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
    }

    
}
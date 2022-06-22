using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;
namespace QUANLYXETNGHIEM.DLL
{

    public class TestCodeService
    {
        public List<TestCodeInfo> GetListTestCode()
        {
            List<TestCodeInfo> _listtestCode = new List<TestCodeInfo>();
            try
            {
                DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_TestCode");
                foreach (DataRow item in resuset.Rows)
                {
                    TestCodeInfo _item = new TestCodeInfo(item["TestCodeID"].ToString(), item["TestCodeName"].ToString());
              
                    _listtestCode.Add(_item);
                }
            }
            catch (Exception)
            {

            }
            return _listtestCode;
        }
        public Boolean InsertTestCode(TestCodeInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("INSERT INTO tbl_TestCode(TestCode,TestName,NormalSetOfStats,CategoryID) VALUES ('" + _info.TestCode + "',N'" + _info.TestName + "','" + _info.NormalSetOfStats + "','" + _info.CategoryId + "')") > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean UpdateTestCode(TestCodeInfo _info)
        {
            try
            {
                return MySQLConnection.excuteUpdate("Update tbl_TestCode set TestName=N'" + _info.TestName + "',NormalSetOfStats='" + _info.NormalSetOfStats + "',CategoryId='" + _info.CategoryId + "' WHERE TestCode='" + _info.TestCode + "' ") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
        public Boolean DeleteTestCode(String _TestCode)
        {
            try
            {
                return MySQLConnection.excuteUpdate("delete tbl_TestCode WHERE TestCode='" + _TestCode + "'") > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
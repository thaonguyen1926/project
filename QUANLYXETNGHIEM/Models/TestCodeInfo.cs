
using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class TestCodeInfo
    {
        public String TestCode { get; set; }
        public String TestName { get; set; }
        public String NormalSetOfStats { get; set; }
        public String CategoryId { get; set; }

        
        public TestCodeInfo(string _TestCode,string _TestName)
        {
            TestCode = _TestCode;
            TestName = _TestName;
        }
        public TestCodeInfo()
        {
           
        }

        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<TestCodeInfo> GetListTestCode()
        {
            TestCodeService testcodeService = new TestCodeService();
            return testcodeService.GetListTestCode();
        }

        public bool Delete(string _id)
        {
            TestCodeService testcodeService = new TestCodeService();
            return testcodeService.DeleteTestCode(_id);
        }


    }
}

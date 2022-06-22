
using QUANLYXETNGHIEM.DLL;
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class OrderTestInfo
    {
        public String SID { get; set; }
        public String TestCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ResultDate { get; set; }
        public String Result { get; set; }
        public String NormalFact { get; set; }



        public OrderTestInfo()
        {
        }

        public OrderTestInfo(String SID, String TestCode, DateTime OrderDate, DateTime ResultDate, String Result, String NormalFact)
        {
            this.SID = SID;
            this.TestCode = TestCode;
            this.OrderDate = OrderDate;
            this.ResultDate = ResultDate;
            this.Result = Result;
            this.NormalFact = NormalFact;
        }
        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<OrderTestInfo> GetListOrderTest()
        {
            OrderTestService ordertestService = new OrderTestService();
            return ordertestService.GetListOrderTest();
        }

        public bool Delete(string _id)
        {
            OrderTestService ordertestService = new OrderTestService();
            return ordertestService.DeleteOrderTest(_id);
        }
    }
}

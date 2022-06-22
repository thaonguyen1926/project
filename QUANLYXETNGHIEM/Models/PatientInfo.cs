
using System;
using System.Collections.Generic;

namespace QUANLYXETNGHIEM.Models
{
    public class PatientInfo
    {
        public String SID { get; set; }
        public String PID { get; set; }
        public String PatientName { get; set; }
        public String Sex { get; set; }
        public String Address { get; set; }
        public DateTime Datein { get; set; }
        public int YearOfBirth { get; set; }
        public String DoctorID { get; set; }
        public String LocationID { get; set; }
        public String ObjectID { get; set; }
        public String Diagnose { get; set; }

        public PatientInfo()
        {
        }

        public PatientInfo(String SID, String PID, String PatientName, String Sex, String Address, DateTime Datein, String DoctorID, String LocationID, String ObjectID, String Diagnose, int YearOfBirth)
        {
            this.SID = SID;
            this.PID = PID;
            this.PatientName = PatientName;
            this.Sex = Sex;
            this.Address = Address;
            this.Datein = Datein;
            this.LocationID = LocationID;
            this.DoctorID = DoctorID;
            this.ObjectID = ObjectID;
            this.YearOfBirth = YearOfBirth;
        }
        /// <summary>
        /// Lấy danh sách nhóm xét nghiệm để trả về view
        /// </summary>
        /// <returns></returns>
        public List<PatientInfo> GetListPatient()
        {
            PatientService patientService = new PatientService();
            return patientService.GetListPatient();
        }

        public bool Delete(string _id)
        {
            PatientService patientService = new PatientService();
            return patientService.DeletePatient(_id);
        }

    }
}

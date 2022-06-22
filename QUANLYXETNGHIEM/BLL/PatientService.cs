
using Microsoft.VisualBasic;
using QUANLYXETNGHIEM.DAL;
using QUANLYXETNGHIEM.Models;
using System;
using System.Collections.Generic;
using System.Data;

public class PatientService {
    public List<PatientInfo> GetListPatient()
    {
        List<PatientInfo> _listpatient= new List<PatientInfo>();
        try
        {
            DataTable resuset = MySQLConnection.excuteQuery("Select * from tbl_Patient");
            foreach (DataRow item in resuset.Rows)
            {
                PatientInfo _item = new PatientInfo(item["SID"].ToString(),
                    item["PID"].ToString(),
                    item["PatientName"].ToString(),
                    item["Sex"].ToString(),
                    item["Address"].ToString(),
                    Convert.ToDateTime(item["DateIn"]),
                    item["DocTorID"].ToString(),
                    item["LocationID"].ToString(),
                    item["ObjectID"].ToString(),
                    item["Diagnose"].ToString(),
                    Convert.ToInt32(item["YearOfBirth"]));
                _listpatient.Add(_item);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        return _listpatient;
    }
    public Boolean InsertPatient(PatientInfo _info)
    {
        try
        { 
            return MySQLConnection.excuteUpdate("INSERT INTO tbl_Patient(PID,SID,DateIn,PatientName,Sex,Address,YearOfBirth,DoctorID,LocationID,Diagnose,ObjectID) VALUES ('"+ _info.PID + "','"+ _info.SID+ "','"+ _info.Datein.ToString("yyyy-MM-dd HHm:ss") + "',N'"+ _info.PatientName + "','"+ _info.Sex + "','"+ _info.Address + "','"+ _info.YearOfBirth.ToString("yyyy-MM-dd HHm:ss") + "','"+ _info.DoctorID + "','"+ _info.LocationID+ "','"+ _info.Diagnose + "','"+ _info.ObjectID + "')") >0;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public Boolean UpdatePatient(PatientInfo _info)
    {
        try
        { 
            return MySQLConnection.excuteUpdate("Update tbl_Patient set PID='"+ _info.PID + "' WHERE SID='"+ _info.SID + "' WHRE DateIn='"+ _info.Datein.ToString("yyyy-MM-dd HHm:ss") + "' WHERE PatientName=N'"+ _info.PatientName + "' WHERE Sex='"+ _info.Sex + "' WHERE Address='"+ _info.Address+ "' WHERE YearOfBirth='"+ _info.YearOfBirth.ToString("yyyy-MM-dd HHm:ss") + "' WHERE DoctorID='"+ _info.DoctorID + "' WHERE LocationID='"+ _info.LocationID + "' WHERE Diagnose='"+ _info.Diagnose+ "' WHERE ObjectID='"+ _info.ObjectID + "' ") >0;
        }
        catch (Exception)
        {
            
        }
        return false;
    }
    public Boolean DeletePatient(String _PID)
    {
        try
        { 
            List<String> _arry=new List<String>();
            _arry.Add(_PID);
            return MySQLConnection.excuteUpdate("delete tbl_Patient WHERE PID='"+ _PID + "'") >0;
        }
        catch (Exception)
        {
            
        }
        return false;
    }
}
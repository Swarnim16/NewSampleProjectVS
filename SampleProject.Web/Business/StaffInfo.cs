using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Web.Business
{
    public class StaffInfo
    {
        public String staffName;
        public int staffID;
        int hourlyRate;

        public int Can_GetStaff_Detail(String sName, int sId, int sRate)
        {
            
            if (sRate <= 50)
            {
                staffName = sName;
                staffID = sId;
                hourlyRate = sRate;
                return hourlyRate;
            }
            else
            {
                staffName = sName;
                staffID = sId;
                hourlyRate = 50;
                return hourlyRate;
            }

        }
    }
}
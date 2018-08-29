using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Web.Business
{
    public class StaffWorkdays
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int WorkdayId { get; set; }
        public int TotalHour { get; set; }
        //public Double WorkdayRate { get; set; }

        public Double SaturdayPenaltyRate = 0.015;
        public Double SundayPenaltyRate = 0.02;

        public int GetStaffWorkdaysInfo(int id, int staffId, int workdayId, int totalHour)
        {
             Id = id;
                StaffId = staffId;
                WorkdayId = workdayId;
                TotalHour = totalHour;  
                
                return 1;
            
        }

        //public Double Can_GetWorkdayRate(int _WorkdayId,float _HourlyRate, int _TotalHour)
        //{
        //    if(_WorkdayId == 06 || _WorkdayId == 07)
        //    {
        //        if(_WorkdayId==06)
        //        {
        //            //WorkdayRate = (_HourlyRate * _TotalHour) - SaturdayPenaltyRate;
        //            //return WorkdayRate;
        //        }
        //        else if(_WorkdayId==07)
        //        {
        //            //WorkdayRate = (_HourlyRate * _TotalHour) - SundayPenaltyRate;
        //           // return WorkdayRate;
        //        }
        //    }
        //    else
        //    {
        //        //WorkdayRate = _HourlyRate * _TotalHour;
        //        //return WorkdayRate;
        //    }

        //    return WorkdayRate;

        //}
    }
}
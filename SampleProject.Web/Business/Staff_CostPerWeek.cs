using SampleProject.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Web.Business
{
    public class Staff_CostPerWeek
    {
        //private readonly SampleDbContext _context;
        //public Staff_CostPerWeek(SampleDbContext context)
        //{
        //    _context = context;
        //}
        public Decimal WorkdayRate { get; set; }

        public Decimal SaturdayPenaltyRate = 0.015M;
        public Decimal SundayPenaltyRate = 0.02M;

        public Decimal GetWorkdayRate(int sWorkdayId, Decimal sHourlyRate, int sTotalHour)
        {
            if (sWorkdayId == 06 || sWorkdayId == 07)
            {
                if (sWorkdayId == 06)
                {
                    WorkdayRate = (sHourlyRate * sTotalHour) + SaturdayPenaltyRate;
                    return WorkdayRate;
                }
                else if (sWorkdayId == 07)
                {
                    WorkdayRate = (sHourlyRate * sTotalHour) + SundayPenaltyRate;
                    return WorkdayRate;
                }
            }
            else
            {
                WorkdayRate = sHourlyRate * sTotalHour;
                return WorkdayRate;
            }

            return WorkdayRate;

        }

        public Decimal GetPerWeekRate(int staffId)
        {


            //var records = _context.StaffWorkdays.Where(i => i.StaffId == staffId).ToList();

            //return 1;
            Decimal PerWeekRate = 0;

            //Hourly rate of a staff from the StaffInfo table
            Decimal sHourlyRate = 30;
            //TotalHour from the StaffWorkday table
            int sTotalHour = 6; 

            for (int sDayId = 01; sDayId < 08; sDayId++)
            {              
                PerWeekRate = PerWeekRate + GetWorkdayRate(sDayId, sHourlyRate, sTotalHour);
            }

            return Math.Round(PerWeekRate);

        }
    }
}
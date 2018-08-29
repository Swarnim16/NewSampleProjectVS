using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Web.Modals
{
    public class StaffWorkdays
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int WorkdayId { get; set; }
        public int TotalHour { get; set; }
    }
}
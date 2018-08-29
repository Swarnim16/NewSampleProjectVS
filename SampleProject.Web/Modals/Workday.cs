using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Web.Data;

namespace SampleProject.Web.Modals
{
    public class Workday
    {
        public int Id { get; set; }
        public String Day { get; set; }

        public void Save_WorkdaysOfWeek(int wId, String wDay)
        {
            Id = wId;
            Day = wDay;
            //String queryInsertInToWorkday= "Insert into Workdays() values()"

            //SampleDbContext sampleDbContextObj = new SampleDbContext();
            //sampleDbContextObj.Database.ExecuteSqlCommand()

        }
    }
}
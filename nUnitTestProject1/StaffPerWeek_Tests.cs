using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject.Web.Business;
using NUnit.Framework;
using SampleProject.Web.Data;
using Moq;
namespace nUnitTestProject1
{
    [TestFixture]
    class StaffPerWeek_Tests
    {
        //private readonly SampleDbContext _context;
        //public StaffPerWeek_Tests(SampleDbContext context)
        //{
        //    _context = context;
        //}
        [Test]
        public void VerifyStaffPerDayRate()
        {
            //Staff_CostPerWeek sCostPerWeekObj = new Staff_CostPerWeek();

            //Decimal sCostResult = sCostPerWeekObj.GetWorkdayRate(01, 30, 4);

            //Assert.AreEqual(120, sCostResult);
        }

        [Test]
        public void VerifyStaffPerWeekRate()
        {
            //Mock<SampleDbContext> mockedDb = new Mock<SampleDbContext>();
            
            Staff_CostPerWeek sCostPerWeekObj = new Staff_CostPerWeek();
            Decimal Cost = 0;
            Decimal sCostResult = sCostPerWeekObj.GetPerWeekRate(1);
            Cost = 30 * 6 * 7;
            Assert.AreEqual(Cost, sCostResult);
        }

        }
}

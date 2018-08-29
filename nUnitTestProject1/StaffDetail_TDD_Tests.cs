using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject.Web.Business;


namespace nUnitTestProject1
{
    [TestFixture]
    class StaffDetail_TDD_Tests
    {
        [Test]
        public void VerifyHourlyRateNotExceed50_Staff()
        {
            StaffInfo staffInfoObj = new StaffInfo();

            //Passing values of Staff to get the result of Hourly Rate whether it is less than 50 or not
            int hourlyRateResult= staffInfoObj.Can_GetStaff_Detail("Swarnim", 001, 30);

            //Verifying the value
            Assert.AreEqual(30, hourlyRateResult);
        }

        [Test]
        public void VerifyHourlyRateMoreThan50_OfStaff()
        {
            StaffInfo staffInfoObj = new StaffInfo();

            //Passing values of Staff to get the result of Hourly Rate whether it is less than 50 or not
            int hourlyRateResult = staffInfoObj.Can_GetStaff_Detail("Simi", 002, 51);

            //Verifying the value
            Assert.AreEqual(50, hourlyRateResult);
        }

        [Test]
        public void VerifyHourlyRateEqualTo50_OfStaff()
        {
            StaffInfo staffInfoObj = new StaffInfo();

            //Passing values of Staff to get the result of Hourly Rate whether it is less than 50 or not
            int hourlyRateResult = staffInfoObj.Can_GetStaff_Detail("Sonam", 003, 50);

            //Verifying the value
            Assert.AreEqual(50, hourlyRateResult);
        }
    }
}

namespace SampleProject.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStaffDaysData : DbMigration
    {
        public override void Up()
        {
            
            //Seed StaffWorkdays table
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('1', '1', '5')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('2', '2', '6')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('3', '3', '4')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('1', '2', '7')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('1', '3', '7')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('2', '5', '8')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('2', '6', '8')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('4', '7', '10')");
            Sql("INSERT INTO [dbo].[StaffWorkdays]([StaffId] ,[WorkdayId], [TotalHour]) VALUES ('4', '3', '12')");

        }

        public override void Down()
        {
        }
    }
}

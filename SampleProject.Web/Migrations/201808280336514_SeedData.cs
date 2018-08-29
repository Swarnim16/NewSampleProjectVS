namespace SampleProject.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedData : DbMigration
    {
        public override void Up()
        {
            //Seed staffinfo table
            Sql("INSERT INTO [dbo].[StaffInfoes]([Name] ,[HourlyRate]) VALUES ('Swarnim', '20')");
            Sql("INSERT INTO [dbo].[StaffInfoes]([Name] ,[HourlyRate]) VALUES ('Daniel', '40')");
            Sql("INSERT INTO [dbo].[StaffInfoes]([Name] ,[HourlyRate]) VALUES ('Andrew', '50')");
            Sql("INSERT INTO [dbo].[StaffInfoes]([Name] ,[HourlyRate]) VALUES ('Kamrun', '25')");

            //Seed workdays table
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Monday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Tuesday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Wednesday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Thursday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Friday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Saturday')");
            Sql("INSERT INTO [dbo].[Workdays]([Day]) VALUES ('Sunday')");

      


        }

        public override void Down()
        {
        }
    }
}

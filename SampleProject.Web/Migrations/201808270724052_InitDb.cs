namespace SampleProject.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HourlyRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);

            //CreateTable(
            //    "dbo.StaffInfos",
            //    c => new
            //    {
            //        Id = c.Int(nullable: false, identity: true),
            //        Name = c.String(),
            //        HourlyRate = c.Decimal(nullable: false, precision: 18, scale: 2),
            //    })
            //    .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.StaffWorkdays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        WorkdayId = c.Int(nullable: false),
                        TotalHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workdays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workdays");
            DropTable("dbo.StaffWorkdays");
            DropTable("dbo.StaffInfoes");
        }
    }
}

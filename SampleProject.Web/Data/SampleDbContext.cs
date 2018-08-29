namespace SampleProject.Web.Data
{
    using SampleProject.Web.Modals;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SampleDbContext : DbContext
    {
        // Your context has been configured to use a 'SampleDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SampleProject.Web.Data.SampleDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SampleDbContext' 
        // connection string in the application configuration file.
        public SampleDbContext()
            : base("name=SampleDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


        public DbSet<StaffInfo> StaffInfos { get; set; }
        public DbSet<StaffWorkdays> StaffWorkdays { get; set; }
        public DbSet<Workday> Workdays { get; set; }
    }

    public class StaffInfos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal HourlyRate { get; set; }
    }
    public class Workday
    {
        public int Id { get; set; }
        public string Day { get; set; }
    }
    public class StaffWorkdays
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int WorkdayId { get; set; }
        public int TotalHour { get; set; }
    }
}
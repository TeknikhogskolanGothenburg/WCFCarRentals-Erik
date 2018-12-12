namespace CarRental.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnDateNullableMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "CarReturnedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "CarReturnedDate", c => c.DateTime(nullable: false));
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingLicenseToRegisterUser1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String());
        }
    }
}

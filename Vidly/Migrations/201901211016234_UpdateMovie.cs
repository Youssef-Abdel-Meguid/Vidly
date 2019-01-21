namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumebrAvailable", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "Availability");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Availability", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NumebrAvailable");
        }
    }
}

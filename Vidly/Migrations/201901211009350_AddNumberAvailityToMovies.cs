namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailityToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Availability", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET Availability = NumberInStock");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Availability");
        }
    }
}

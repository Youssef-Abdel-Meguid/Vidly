namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0e2dfc48-950b-4f5b-814c-203dff537f72', N'guest@vidly.com', 0, N'AOcFUQ0Vamc68Tl+08/55WAD8SuLM0GsKlDjShUHXznW9d3GNv/s5/ZAGEwePHZ7UA==', N'23ba24be-acf4-46b9-ba9c-4903c6677b1d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5c87875c-55a4-4b3e-a99d-cca7411deac2', N'admin@vidly.com', 0, N'AD5XE89A4JspYU+QlFy5k3l+rMQQLuuuDsfpdEhFi4qlLj0JFrUoNCrM2Jj6XCWoKA==', N'9de1b5fb-806a-4eef-89e5-60473d29e021', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b1e32348-3b3b-4e3f-8919-310670ac03cb', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5c87875c-55a4-4b3e-a99d-cca7411deac2', N'b1e32348-3b3b-4e3f-8919-310670ac03cb')
                ");
        }
        
        public override void Down()
        {
        }
    }
}

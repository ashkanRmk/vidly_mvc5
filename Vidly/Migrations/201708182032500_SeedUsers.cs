namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'595bcfa5-6956-4dd4-b0c4-a4e74b37ba3b', N'guest@vidly.com', 0, N'AIDFkXCPJlZHv66OtHTnJpg1sgl0h1SvuWVMgup0GiVXEgIvm5IH+yjgMuutaDEG0g==', N'945bcec0-e69e-463e-b3c5-00021d15bd79', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e74891c2-1cf8-44f1-8849-dea1e191a9c5', N'admin@vidly.com', 0, N'AO3CdoK7srDBuQZXywNMo47dXUHES8Ukrdkz9YywtfHTaOmW/+uv3lT7vV11bVKyhg==', N'c2fd7871-6a1d-40e5-b9ed-d2d5f6a8b260', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fd7abf26-9d7b-4c0f-b18c-d283d35ac097', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e74891c2-1cf8-44f1-8849-dea1e191a9c5', N'fd7abf26-9d7b-4c0f-b18c-d283d35ac097')

");
        }
        
        public override void Down()
        {
        }
    }
}

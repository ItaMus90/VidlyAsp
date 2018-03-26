namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'094c8806-67b0-4df4-a10f-e0897ccd4f7d', N'admin@mubi.com', 0, N'AD15+xrwaE/UMMVRfT3n/grDd8OgLwxvrpU62XWiS56RtihwMrVferVdPa/Pqtx+Bw==', N'4a6155c0-73cd-4735-969c-097489029ade', NULL, 0, 0, NULL, 1, 0, N'admin@mubi.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'320243d5-9bd6-4cf9-b2e8-c092b246fac8', N'ITAMAR@DOMAIN.COM', 0, N'AH5lJmHy2zGrPdsi0ZjG7HhwwXsfkzrfoCHBb/YGXusUGxq+aKuGM9dzTWaed3k10A==', N'49276251-1997-440a-957e-64dc39fc1be8', NULL, 0, 0, NULL, 1, 0, N'ITAMAR@DOMAIN.COM')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'584d3423-3bba-4e3a-91d7-2af538bb5ec3', N'CanChangeMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'094c8806-67b0-4df4-a10f-e0897ccd4f7d', N'584d3423-3bba-4e3a-91d7-2af538bb5ec3')

");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'007af31e-17be-4389-aa39-1f0b84c8f37e', N'greenmoregreent@gmail.com', 0, N'AJx/a4+Per7zjS3HwOG0+4R7faO8raEOhrK/698MN4AdXjKmaCjedSWW0UA/jEz1Dw==', N'663fd4e9-3338-4c87-8e78-ef27e18e80e9', NULL, 0, 0, NULL, 1, 0, N'greenmoregreent@gmail.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dde11a33-7b0c-4c6d-a8e0-7de35ac1ec28', N'admin@vidly.com', 0, N'AKk4FNFG6xzK5Vbo7illnR2Xc4Wpo2AqGb2cpRsYPp1kBfPC4+Mie2Yx4TPA04j5bA==', N'f0654ba5-6cc9-45b3-ac00-8fa927465ac3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'11950481-613c-4371-9648-7b5d26d82756', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dde11a33-7b0c-4c6d-a8e0-7de35ac1ec28', N'11950481-613c-4371-9648-7b5d26d82756')

");
        }
        
        public override void Down()
        {
        }
    }
}

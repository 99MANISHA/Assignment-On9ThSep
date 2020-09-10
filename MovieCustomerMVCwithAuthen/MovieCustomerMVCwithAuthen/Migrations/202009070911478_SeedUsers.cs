namespace MovieCustomerMVCwithAuthen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'bf30ec4d-8bc9-454b-b5e4-64b1a517a65a', N'lakshmimanisha9999@gmail.com', 0, N'AMQbU7edOnW4Z4HK82J7Tdtvqkv3NeHmWTktOZ5PBmaAq4tR4XFYF5WDkhoO343W0g==', N'a83fd114-6416-42d3-aa30-2be29e4606b2', NULL, 0, 0, NULL, 1, 0, N'lakshmimanisha9999@gmail.com', N'123456789')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be718e2a-66ea-42c4-be72-df14cf2a55a9', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c6f32de-d913-4b2c-87b5-3c3270f96ac7', N'be718e2a-66ea-42c4-be72-df14cf2a55a9')");
        }
        
        public override void Down()
        {
        }
    }
}

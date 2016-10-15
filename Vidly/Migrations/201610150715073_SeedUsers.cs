namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'4b4a50c6-2855-4b19-a616-85551afd5886', N'guest@vidly.com', 0, N'ANol9eC3XkAcEoxHlmstkmeWuhq+GYW9a6jE3u757KDJE27aJnueC/uSVyswxq7VQA==', N'ad2ae247-9eea-4545-a6e0-5f6e200dee4a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'992390cd-9c9c-45d5-91e7-049f431da507', N'admin@vidly.com', 0, N'AESXzG37b8DyfgL2dgsa3Sdww692ZbQGWwcsJMkff4ImEgBF85oY1TmgMqyhMgsS7A==', N'7e19b478-a45b-49f1-8147-6c4e8ffc5bb8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6d05c08e-e504-4391-826e-a0d39494d7d4', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'992390cd-9c9c-45d5-91e7-049f431da507', N'6d05c08e-e504-4391-826e-a0d39494d7d4')

            ");
        }

    public override void Down()
        {
        }
    }
}

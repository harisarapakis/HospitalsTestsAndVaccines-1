namespace HospitalsTestsAndVaccines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'43d8f57a-9a40-4547-91d1-c58d4b8cbd87', N'Dev')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'092d5ee2-1a84-43b3-92cf-c9990bfaeae8', N'HospAdmin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d055f55-ae7b-4342-bccb-72cdace6c999', N'Patient')

INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'207758ff-59e1-4cb9-a2ad-32efb936138c', N'Dev', N'Company', N'2106666666', N'09876543211', N'1/1/1990 12:00:00 AM', N'-', N'Marousi', N'Athens', N'17342', N'Attiki', N'dev@gmail.com', 0, N'APtZLCKB1cprSVs7hIoeTfCFQwaKmh/x48chN05nUKOEe+nHalErMKxSuM3XJX3Wcw==', N'63c88550-402f-4393-a10f-2db0271f1b29', NULL, 0, 0, NULL, 1, 0, N'dev@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'432ab792-b25d-4cfe-aae2-4ae38334f51e', N'Kostadinos', N'Skylakos', N'6984324519', N'12345678901', N'1990-06-04', N'-', N'Anoiksi', N'Athens', N'17582', N'Attiki', N'kostas@gmail.com', 0, N'AKAacajTD5gxddh0vsUfcRPfI5/uo9qKh/sKnqJrGGnx+iBHzCdSxNUXkpE19GxUiQ==', N'6bf89f99-3a49-465e-9545-32fb066ff956', NULL, 0, 0, NULL, 1, 0, N'kostas@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'450704d3-946a-4a5a-8dc6-e7c97f957ed0', N'Haris', N'Arapakis', N'6984324234', N'12345672344', N'1/1/1996 12:00:00 AM', N'yes', N'Ampelokipous', N'Athens', N'18210', N'Attiki', N'haris@gmail.com', 0, N'ANwEXmrTASvPzjkcSI6EewPKvWo94BHih3vUzzyAIs3gSbQRDZ9dUPt+4qcGWhdHbw==', N'9f0aed0c-f072-4b6d-92a4-14275b0adf92', NULL, 0, 0, NULL, 1, 0, N'haris@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4b7b583a-cd84-4683-90dd-9a897acd4417', N'Casper', N'TheGhost', N'6982342342', N'12345568565', N'2002-06-04', N'yes', N'Mansion', N'Athens', N'18210', N'Attiki', N'casper@gmail.com', 0, N'AO3RmNnOIhiHzO+ueDn8Qx3Bzr6nFaEY/HsvgGeqqfZeX71wJtkuZN1a34RXoKR4fw==', N'40ba85b7-c657-4ebb-a60e-a390b8d900d5', NULL, 0, 0, NULL, 1, 0, N'casper@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b58d93ec-a5f3-4135-bd27-f1847ef332c1', N'TestUser', N'UserTest', N'6823423565', N'32567195287', N'6/6/2000 12:00:00 AM', N'yes', N'Test', N'Athens', N'18210', N'Attiki', N'test@gmail.com', 0, N'APDWQZvgSBD/aYQLn+xt+dImK/IY7crcNmzjoIxzF6KdXmYSxq+xWgZqV88sghqhSw==', N'de340848-cc6b-4bb2-b512-c4088c9ccee0', NULL, 0, 0, NULL, 1, 0, N'test@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cfc121a5-0477-4dc9-8a56-6ea7b9235935', N'Giorgos', N'Gialouris', N'6945596924', N'12345643857', N'1993-01-13', N'yes', N'Tritonos', N'Athens', N'18452', N'Attiki', N'giorgos@gmail.com', 0, N'AKXGP4hHGX6hdZb+geS/5cyHZISlTkkCHt8hbCxFcA77MTf9+xbXXkXTJCnUoELgVA==', N'29b4c08c-92b6-4b10-b0b0-ef7fc8f68691', NULL, 0, 0, NULL, 1, 0, N'giorgos@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd8417601-4cbb-4281-87d6-43b61a894e7d', N'Hosp', N'Admin', N'2104809000', N'23326895012', N'1990-06-14', N'-', N'Peiraias', N'Peiraias', N'18547', N'attiki', N'admin@gmail.com', 0, N'AAW4Sx104Ttffi/TAMwLgwuVk3Oe2+P2I/fj4vNVCoE4YdTS/Y4l0v8TRWRIODcxtA==', N'5603eb49-a919-4dc6-b434-a55ab68c04bb', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Phone], [Amka], [DateOfBirth], [HealthIssues], [Address], [City], [PostalCode], [State], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f531fada-6f77-42b1-ab1d-1faedfd30ad7', N'Marios', N'Michalopoulos', N'6952351356', N'12342359722', N'2001-07-12', N'yes', N'Marousi', N'Athens', N'18210', N'Attiki', N'marios@gmail.com', 0, N'ABAezsm053MpTSh8htzYHz3eDF7YkZiWRfKMqmCeq4CwFgy4xLXVDnS9+TxV02f8cQ==', N'ce434fe8-17f7-4363-835c-d1ddd8243276', NULL, 0, 0, NULL, 1, 0, N'marios@gmail.com')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd8417601-4cbb-4281-87d6-43b61a894e7d', N'092d5ee2-1a84-43b3-92cf-c9990bfaeae8')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'207758ff-59e1-4cb9-a2ad-32efb936138c', N'43d8f57a-9a40-4547-91d1-c58d4b8cbd87')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'432ab792-b25d-4cfe-aae2-4ae38334f51e', N'5d055f55-ae7b-4342-bccb-72cdace6c999')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'450704d3-946a-4a5a-8dc6-e7c97f957ed0', N'5d055f55-ae7b-4342-bccb-72cdace6c999')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4b7b583a-cd84-4683-90dd-9a897acd4417', N'5d055f55-ae7b-4342-bccb-72cdace6c999')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b58d93ec-a5f3-4135-bd27-f1847ef332c1', N'5d055f55-ae7b-4342-bccb-72cdace6c999')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cfc121a5-0477-4dc9-8a56-6ea7b9235935', N'5d055f55-ae7b-4342-bccb-72cdace6c999')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f531fada-6f77-42b1-ab1d-1faedfd30ad7', N'5d055f55-ae7b-4342-bccb-72cdace6c999')

SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([Id], [ProductName], [ProductCategory], [Description], [Price]) VALUES (1, N'Rapid Test', 0, N'A quick test', 120)
INSERT INTO [dbo].[Products] ([Id], [ProductName], [ProductCategory], [Description], [Price]) VALUES (2, N'Cambridge Vaccine', 1, N'The vaccine of Cambridge institute', 0)
INSERT INTO [dbo].[Products] ([Id], [ProductName], [ProductCategory], [Description], [Price]) VALUES (4, N'Molecular Test', 0, N'A pcr testing', 230)
INSERT INTO [dbo].[Products] ([Id], [ProductName], [ProductCategory], [Description], [Price]) VALUES (5, N'China Vaccine', 1, N'The chinese vaccine', 0)
SET IDENTITY_INSERT [dbo].[Products] OFF

SET IDENTITY_INSERT [dbo].[Appointments] ON
INSERT INTO [dbo].[Appointments] ([Id], [StartDateTime], [EndDate], [Detail], [Status], [ApplicationUserId], [ProductId]) VALUES (1, N'2021-01-26 16:30:00', N'2021-01-30 17:00:00', N'I''m feeling sick', 0, N'cfc121a5-0477-4dc9-8a56-6ea7b9235935', 1)
INSERT INTO [dbo].[Appointments] ([Id], [StartDateTime], [EndDate], [Detail], [Status], [ApplicationUserId], [ProductId]) VALUES (2, N'2021-01-28 00:00:00', N'2021-01-30 14:30:00', N'I want to do the vaccine', 1, N'f531fada-6f77-42b1-ab1d-1faedfd30ad7', 2)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
");
        }

        public override void Down()
        {
        }
    }
}

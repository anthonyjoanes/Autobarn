﻿-- MAKES
SET IDENTITY_INSERT [dbo].[Makes] ON
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (1, N'Audi')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (2, N'BMW')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (3, N'Mercedes-Benz')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (4, N'Other')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (5, N'SEAT')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (6, N'Skoda')
INSERT INTO [dbo].[Makes] ([Id], [Name]) VALUES (7, N'Volkswagen')
SET IDENTITY_INSERT [dbo].[Makes] OFF

-- MODELS
SET IDENTITY_INSERT [dbo].[Models] ON
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (1, N'A3', 1)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (2, N'A4', 1)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (3, N'A5', 1)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (4, N'A6', 1)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (5, N'A8', 1)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (6, N'1 Series', 2)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (7, N'2 Series', 2)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (8, N'5 Series', 2)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (9, N'7 Series', 2)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (10, N'A CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (11, N'B CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (12, N'C CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (13, N'CLK', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (14, N'E CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (15, N'M CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (16, N'Other', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (17, N'S CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (18, N'SLK', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (19, N'SPRINTER', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (20, N'V CLASS', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (21, N'VITO', 3)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (22, N'Other', 4)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (23, N'Ibiza', 5)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (24, N'Leon', 5)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (25, N'Fabia', 6)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (26, N'Octavia', 6)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (27, N'Superb', 6)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (28, N'Bora', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (29, N'Fox', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (30, N'Golf', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (31, N'Passat', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (32, N'Polo', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (33, N'Sharan', 7)
INSERT INTO [dbo].[Models] ([Id], [Name], [Make_Id]) VALUES (34, N'Touran', 7)
SET IDENTITY_INSERT [dbo].[Models] OFF

-- SERVICES
SET IDENTITY_INSERT [dbo].[Services] ON
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (1, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(165.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (2, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(245.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (3, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(370.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (4, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (5, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(255.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (6, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(380.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (7, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (8, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(265.00 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (9, N'Major Service', CAST(209.00 AS Decimal(18, 2)), CAST(385.00 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (10, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(190.00 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (11, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(270.00 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (12, N'Major Service', CAST(209.00 AS Decimal(18, 2)), CAST(386.00 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (13, N'Oil Service', CAST(114.00 AS Decimal(18, 2)), CAST(210.00 AS Decimal(18, 2)), 5)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (14, N'Annual Service', CAST(149.00 AS Decimal(18, 2)), CAST(310.00 AS Decimal(18, 2)), 5)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (15, N'Major Service', CAST(219.00 AS Decimal(18, 2)), CAST(395.00 AS Decimal(18, 2)), 5)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (16, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 6)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (17, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 6)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (18, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 6)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (19, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), 7)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (20, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(310.00 AS Decimal(18, 2)), 7)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (21, N'Major Service', CAST(194.00 AS Decimal(18, 2)), CAST(480.00 AS Decimal(18, 2)), 7)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (22, N'Oil Service', CAST(105.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)), 8)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (23, N'Annual Service', CAST(135.00 AS Decimal(18, 2)), CAST(330.00 AS Decimal(18, 2)), 8)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (24, N'Major Service', CAST(205.00 AS Decimal(18, 2)), CAST(485.00 AS Decimal(18, 2)), 8)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (25, N'Oil Service', CAST(119.00 AS Decimal(18, 2)), CAST(255.00 AS Decimal(18, 2)), 9)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (26, N'Annual Service', CAST(149.00 AS Decimal(18, 2)), CAST(375.00 AS Decimal(18, 2)), 9)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (27, N'Major Service', CAST(219.00 AS Decimal(18, 2)), CAST(495.00 AS Decimal(18, 2)), 9)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (28, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 10)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (29, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 10)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (30, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 10)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (31, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 11)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (32, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 11)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (33, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 11)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (34, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 12)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (35, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 12)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (36, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 12)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (37, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 13)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (38, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 13)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (39, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 13)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (40, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 14)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (41, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 14)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (42, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 14)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (43, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (44, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (45, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (46, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 16)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (47, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 16)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (48, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 16)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (49, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 17)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (50, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 17)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (51, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 17)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (52, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 18)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (53, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 18)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (54, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 18)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (55, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 19)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (56, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 19)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (57, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 19)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (58, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 20)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (59, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 20)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (60, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 20)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (61, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 21)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (62, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 21)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (63, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 21)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (64, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 23)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (65, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 23)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (66, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 23)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (67, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 24)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (68, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 24)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (69, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 24)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (70, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 25)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (71, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 25)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (72, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 25)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (73, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 26)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (74, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 26)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (75, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 26)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (76, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 27)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (77, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 27)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (78, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 27)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (79, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 28)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (80, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 28)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (81, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 28)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (82, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 29)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (83, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 29)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (84, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 29)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (85, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 30)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (86, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 30)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (87, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 30)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (88, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 31)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (89, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 31)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (90, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 31)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (91, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 32)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (92, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 32)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (93, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 32)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (94, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 33)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (95, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 33)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (96, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 33)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (97, N'Oil Service', CAST(99.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), 34)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (98, N'Annual Service', CAST(129.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), 34)
INSERT INTO [dbo].[Services] ([Id], [Name], [Price], [DealerPrice], [Model_Id]) VALUES (99, N'Major Service', CAST(199.00 AS Decimal(18, 2)), CAST(460.00 AS Decimal(18, 2)), 34)
SET IDENTITY_INSERT [dbo].[Services] OFF
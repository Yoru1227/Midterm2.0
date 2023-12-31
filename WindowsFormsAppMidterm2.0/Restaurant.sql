USE [RestaurantDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2023/12/3 下午 11:15:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[phone] [nchar](10) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[account] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[isBanned] [bit] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2023/12/3 下午 11:15:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
	[onBoardingDate] [date] NOT NULL,
	[resignDate] [date] NULL,
	[permission] [int] NOT NULL,
	[account] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2023/12/3 下午 11:15:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[datetime] [date] NOT NULL,
	[productID] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[totalPrice] [int] NOT NULL,
	[employeeID] [int] NOT NULL,
	[comment] [nvarchar](50) NULL,
	[isPaid] [bit] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023/12/3 下午 11:15:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[isInStock] [bit] NOT NULL,
	[picName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [name], [gender], [phone], [address], [email], [account], [password], [isBanned]) VALUES (100002, N'王小明', N'女', N'0912345678', N'高雄市鼓山區1000號二樓', N'Wangxiaoming@example.com', N'123', N'1234', 0)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [name], [title], [salary], [onBoardingDate], [resignDate], [permission], [account], [password]) VALUES (1, N'admin', N'店長', 0, CAST(N'2000-12-27' AS Date), CAST(N'2023-12-03' AS Date), 10000, N'admin', N'admin')
INSERT [dbo].[Employee] ([ID], [name], [title], [salary], [onBoardingDate], [resignDate], [permission], [account], [password]) VALUES (6, N'海綿寶寶', N'店員', 38000, CAST(N'2023-12-03' AS Date), CAST(N'2023-12-03' AS Date), 100, N'sb', N'123')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [customerID], [datetime], [productID], [amount], [totalPrice], [employeeID], [comment], [isPaid]) VALUES (10, 100002, CAST(N'2023-12-03' AS Date), 1, 20, 600, 1, N'不要飯', 1)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (1, N'雞肉飯', 30, N'飯類', 1, N'雞肉飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (4, N'滷肉飯', 30, N'飯類', 1, N'滷肉飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (6, N'咖哩飯', 50, N'飯類', 1, N'咖哩飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (7, N'牛肉丼飯', 80, N'飯類', 1, N'牛肉丼飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (8, N'豬排蓋飯', 80, N'飯類', 1, N'豬排蓋飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (10, N'印度香料炒飯', 90, N'飯類', 1, N'印度香料炒飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (11, N'招牌乾麵', 50, N'麵類', 1, N'招牌乾麵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (12, N'餛飩乾麵', 60, N'麵類', 1, N'餛飩乾麵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (13, N'餛飩湯', 35, N'湯類', 1, N'餛飩湯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (14, N'炒空心菜', 45, N'小菜', 1, N'炒空心菜.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (15, N'炒地瓜葉', 45, N'小菜', 1, N'炒地瓜葉.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (16, N'炒高麗菜', 45, N'小菜', 1, N'炒高麗菜.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (17, N'豬耳朵', 40, N'小菜', 1, N'豬耳朵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (18, N'牛肉麵', 140, N'麵類', 1, N'牛肉麵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (19, N'貢丸湯', 30, N'湯類', 1, N'貢丸湯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (20, N'醬油蛋炒飯', 80, N'飯類', 1, N'醬油蛋炒飯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (21, N'頂級海鮮粥', 180, N'飯類', 1, N'頂級海鮮粥.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (22, N'海陸炒泡麵', 150, N'麵類', 1, N'海陸炒泡麵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (23, N'海鮮鍋燒意麵', 150, N'麵類', 1, N'海鮮鍋燒意麵.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (24, N'皮蛋豆腐', 35, N'小菜', 1, N'皮蛋豆腐.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (25, N'紫菜蛋花湯', 30, N'湯類', 1, N'紫菜蛋花湯.jpg')
INSERT [dbo].[Product] ([ID], [name], [price], [category], [isInStock], [picName]) VALUES (27, N'荷包蛋', 15, N'小菜', 1, N'荷包蛋.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_isBanned]  DEFAULT ((0)) FOR [isBanned]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_isPaid]  DEFAULT ((0)) FOR [isPaid]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO

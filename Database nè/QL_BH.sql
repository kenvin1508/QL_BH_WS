USE [QL_BanHang]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 2/15/2019 9:14:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[Name] [nchar](30) NOT NULL,
	[Password] [nchar](30) NOT NULL,
	[Mobile] [int] NOT NULL,
 CONSTRAINT [PK_KHACHHANG_1] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (12, N'cho viet', N'viet cho                      ', N'123                           ', 9372772)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (7, N'd', N'd                             ', N'123                           ', 123)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (9, N'dd', N'd                             ', N'1                             ', 1)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (10, N'ddd', N'd                             ', N'd                             ', 928171615)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (11, N'dddd', N'1                             ', N'1                             ', 929181615)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (8, N'de', N'd                             ', N'123                           ', 56)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (6, N'thuong@gmail.com', N'Thương                        ', N'123                           ', 293765238)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (2, N'vht@gmail.com', N'Tùng                          ', N'456                           ', 928304386)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (5, N'viet@gmail.com', N'viet                          ', N'123                           ', 293765238)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (1, N'vtn@gmail.com', N'Nghĩa                         ', N'123                           ', 929181615)
INSERT [dbo].[KHACHHANG] ([id], [Email], [Name], [Password], [Mobile]) VALUES (3, N'vtnhan@gmail.com', N'Nhân                          ', N'123                           ', 98273612)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF

CREATE TABLE [dbo].[ProductTypeDst](
	[ProductTypeID] [int] NOT NULL,
	[ProductTypeCode] [nvarchar](50) NOT NULL,
	[ProductTypeName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ProductTypeDst] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO

CREATE TABLE [dbo].[ProductTypeSrc](
	[ProductTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeCode] [nvarchar](50) NOT NULL,
	[ProductTypeName] [nvarchar](max) NOT NULL,
	[ProductTypeProcessed] [datetime] NULL,
 CONSTRAINT [PK_ProductTypeSrc] PRIMARY KEY CLUSTERED 
(
	[ProductTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ProductTypeSrc] ON 
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (1, N'1', N'TomTom', NULL)
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (2, N'17', N'TP-LINK', NULL)
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (3, N'87', N'Garmin OEM', NULL)
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (4, N'87.a', N'Garmin Fishfinders', NULL)
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (5, N'15', N'Cardo', NULL)
GO
INSERT [dbo].[ProductTypeSrc] ([ProductTypeID], [ProductTypeCode], [ProductTypeName], [ProductTypeProcessed]) VALUES (6, N'23.x', N'Jabra', NULL)
GO
SET IDENTITY_INSERT [dbo].[ProductTypeSrc] OFF
GO

USE [MT]
GO
/****** Object:  Table [dbo].[MOXGEA]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXGEA](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[GEA001] [nvarchar](50) NULL,
	[GEA002] [nvarchar](50) NULL,
	[GEA003] [nvarchar](50) NULL,
	[GEA004] [nvarchar](50) NULL,
	[GEA005] [nchar](10) NULL,
	[GEA006] [nchar](10) NULL,
	[GEA007] [nchar](10) NULL,
	[GEA008] [nchar](10) NULL,
	[GEA009] [nchar](10) NULL,
	[GEA010] [nchar](10) NULL,
	[GEA011] [nchar](10) NULL,
	[GEA012] [nchar](10) NULL,
	[GEA013] [nchar](10) NULL,
	[GEA014] [nchar](10) NULL,
	[GEA015] [nchar](10) NULL,
	[GEA016] [nchar](10) NULL,
	[GEA017] [nchar](10) NULL,
	[GEA018] [nchar](10) NULL,
	[GEA019] [nchar](10) NULL,
	[GEA020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEA', @level2type=N'COLUMN',@level2name=N'GEA001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEA', @level2type=N'COLUMN',@level2name=N'GEA002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEA', @level2type=N'COLUMN',@level2name=N'GEA003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEA', @level2type=N'COLUMN',@level2name=N'GEA004'
GO

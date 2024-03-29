USE [MT]
GO
/****** Object:  Table [dbo].[MOXFOR]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXFOR](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[FOR001] [nvarchar](100) NULL,
	[FOR002] [nvarchar](100) NULL,
	[FOR003] [nchar](10) NULL,
	[FOR004] [nvarchar](100) NULL,
	[FOR005] [date] NULL,
	[FOR006] [nchar](10) NULL,
	[FOR007] [nchar](10) NULL,
	[FOR008] [nchar](10) NULL,
	[FOR009] [nchar](10) NULL,
	[FOR010] [nchar](10) NULL,
	[FOR011] [nchar](10) NULL,
	[FOR012] [nchar](10) NULL,
	[FOR013] [nchar](10) NULL,
	[FOR014] [nchar](10) NULL,
	[FOR015] [nchar](10) NULL,
	[FOR016] [nchar](10) NULL,
	[FOR017] [nchar](10) NULL,
	[FOR018] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'程序名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXFOR', @level2type=N'COLUMN',@level2name=N'FOR001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'程序编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXFOR', @level2type=N'COLUMN',@level2name=N'FOR002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'程序类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXFOR', @level2type=N'COLUMN',@level2name=N'FOR003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'程序用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXFOR', @level2type=N'COLUMN',@level2name=N'FOR004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXFOR', @level2type=N'COLUMN',@level2name=N'FOR005'
GO

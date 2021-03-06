USE [MT]
GO
/****** Object:  Table [dbo].[MOXBRB]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXBRB](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[BRB001] [nvarchar](50) NULL,
	[BRB002] [nvarchar](50) NULL,
	[BRB003] [nvarchar](100) NULL,
	[BRB004] [nvarchar](50) NULL,
	[BRB005] [date] NULL,
	[BRB006] [int] NULL,
	[BRB007] [nchar](10) NULL,
	[BRB008] [nchar](10) NULL,
	[BRB009] [nchar](10) NULL,
	[BRB010] [nchar](10) NULL,
	[BRB011] [nchar](10) NULL,
	[BRB012] [nchar](10) NULL,
	[BRB013] [nchar](10) NULL,
	[BRB014] [nchar](10) NULL,
	[BRB015] [nchar](10) NULL,
	[BRB016] [nchar](10) NULL,
	[BRB017] [nchar](10) NULL,
	[BRB018] [nchar](10) NULL,
	[BRB019] [nchar](10) NULL,
	[BRB020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工步' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'填写时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRB', @level2type=N'COLUMN',@level2name=N'BRB006'
GO

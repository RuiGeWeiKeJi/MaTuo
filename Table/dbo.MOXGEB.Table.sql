USE [MT]
GO
/****** Object:  Table [dbo].[MOXGEB]    Script Date: 10/25/2017 17:21:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXGEB](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[GEB001] [nvarchar](50) NULL,
	[GEB002] [nvarchar](50) NULL,
	[GEB003] [nvarchar](200) NULL,
	[GEB004] [nvarchar](200) NULL,
	[GEB005] [nvarchar](50) NULL,
	[GEB006] [int] NULL,
	[GEB007] [date] NULL,
	[GEB008] [nchar](10) NULL,
	[GEB009] [nchar](10) NULL,
	[GEB010] [nchar](10) NULL,
	[GEB011] [nchar](10) NULL,
	[GEB012] [nchar](10) NULL,
	[GEB013] [nchar](10) NULL,
	[GEB014] [nchar](10) NULL,
	[GEB015] [nchar](10) NULL,
	[GEB016] [nchar](10) NULL,
	[GEB017] [nchar](10) NULL,
	[GEB018] [nchar](10) NULL,
	[GEB019] [nchar](10) NULL,
	[GEB020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工步' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'填写时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXGEB', @level2type=N'COLUMN',@level2name=N'GEB007'
GO

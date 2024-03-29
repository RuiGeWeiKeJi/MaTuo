USE [MT]
GO
/****** Object:  Table [dbo].[MOXWID]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOXWID](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[WID001] [varchar](50) NULL,
	[WID002] [varchar](50) NULL,
	[WID003] [varchar](50) NULL,
	[WID004] [varchar](50) NULL,
	[WID005] [date] NULL,
	[WID006] [nchar](10) NULL,
	[WID007] [nchar](10) NULL,
	[WID008] [nchar](10) NULL,
	[WID009] [nchar](10) NULL,
	[WID010] [nchar](10) NULL,
	[WID011] [nchar](10) NULL,
	[WID012] [nchar](10) NULL,
	[WID013] [nchar](10) NULL,
	[WID014] [nchar](10) NULL,
	[WID015] [nchar](10) NULL,
	[WID016] [nchar](10) NULL,
	[WID017] [nchar](10) NULL,
	[WID018] [nchar](10) NULL,
	[WID019] [nchar](10) NULL,
	[WID020] [nchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWID', @level2type=N'COLUMN',@level2name=N'WID001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWID', @level2type=N'COLUMN',@level2name=N'WID002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWID', @level2type=N'COLUMN',@level2name=N'WID003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWID', @level2type=N'COLUMN',@level2name=N'WID004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'派工时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWID', @level2type=N'COLUMN',@level2name=N'WID005'
GO

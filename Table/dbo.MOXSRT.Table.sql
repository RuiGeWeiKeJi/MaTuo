USE [MT]
GO
/****** Object:  Table [dbo].[MOXSRT]    Script Date: 10/30/2017 15:13:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXSRT](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[SRT001] [nvarchar](50) NULL,
	[SRT002] [nvarchar](50) NULL,
	[SRT003] [nvarchar](50) NULL,
	[SRT004] [nvarchar](50) NULL,
	[SRT005] [nvarchar](50) NULL,
	[SRT006] [int] NULL,
	[SRT007] [nvarchar](50) NULL,
	[SRT008] [nvarchar](50) NULL,
	[SRT009] [nvarchar](50) NULL,
	[SRT010] [nchar](10) NULL,
	[SRT011] [nchar](10) NULL,
	[SRT012] [nchar](10) NULL,
	[SRT013] [nchar](10) NULL,
	[SRT014] [nchar](10) NULL,
	[SRT015] [nchar](10) NULL,
	[SRT016] [nchar](10) NULL,
	[SRT017] [nchar](10) NULL,
	[SRT018] [nchar](10) NULL,
	[SRT019] [nchar](10) NULL,
	[SRT020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'定子条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'制动器条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT008'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总装配条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRT', @level2type=N'COLUMN',@level2name=N'SRT009'
GO

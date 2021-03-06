USE [MT]
GO
/****** Object:  Table [dbo].[MOXSTD]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXSTD](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[STD001] [nvarchar](50) NULL,
	[STD002] [nvarchar](50) NULL,
	[STD003] [nvarchar](50) NULL,
	[STD004] [nvarchar](50) NULL,
	[STD005] [nvarchar](50) NULL,
	[STD006] [int] NULL,
	[STD007] [nvarchar](50) NULL,
	[STD008] [date] NULL,
	[STD009] [date] NULL,
	[STD010] [nchar](10) NULL,
	[STD011] [nchar](10) NULL,
	[STD012] [nchar](10) NULL,
	[STD013] [nchar](10) NULL,
	[STD014] [nchar](10) NULL,
	[STD015] [nchar](10) NULL,
	[STD016] [nchar](10) NULL,
	[STD017] [nchar](10) NULL,
	[STD018] [nchar](10) NULL,
	[STD019] [nchar](10) NULL,
	[STD020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工序名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工序内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'测试数据' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'检验方法' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最终工时' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSTD', @level2type=N'COLUMN',@level2name=N'STD008'
GO

USE [MT]
GO
/****** Object:  Table [dbo].[MOXPOW]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXPOW](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[POW001] [nvarchar](10) NULL,
	[POW002] [nvarchar](20) NULL,
	[POW003] [nvarchar](50) NULL,
	[POW004] [bit] NULL,
	[POW005] [bit] NULL,
	[POW006] [bit] NULL,
	[POW007] [bit] NULL,
	[POW008] [bit] NULL,
	[POW009] [bit] NULL,
	[POW010] [bit] NULL,
	[POW011] [bit] NULL,
	[POW012] [bit] NULL,
	[POW013] [bit] NULL,
	[POW014] [date] NULL,
	[POW015] [nvarchar](20) NULL,
	[POW016] [bit] NULL,
	[POW017] [bit] NULL,
	[POW018] [nchar](10) NULL,
	[POW019] [nchar](10) NULL,
	[POW020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'程序编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'查询' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新增' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编辑' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'送审' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW008'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW009'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保存' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW010'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'取消' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW011'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注销' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW012'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'运行' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW013'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW014'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW015'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'打印' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW016'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'导出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXPOW', @level2type=N'COLUMN',@level2name=N'POW017'
GO

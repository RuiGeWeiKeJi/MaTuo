USE [MT]
GO
/****** Object:  Table [dbo].[MOXWIB]    Script Date: 10/30/2017 08:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOXWIB](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[WIB001] [nvarchar](50) NOT NULL,
	[WIB002] [nvarchar](50) NULL,
	[WIB003] [nvarchar](50) NULL,
	[WIB004] [int] NULL,
	[WIB005] [int] NULL,
	[WIB006] [int] NULL,
	[WIB007] [int] NULL,
	[WIB008] [nvarchar](50) NULL,
	[WIB009] [varchar](50) NULL,
	[WIB010] [int] NULL,
	[WIB011] [int] NULL,
	[WIB012] [int] NULL,
	[WIB013] [int] NULL,
	[WIB014] [nchar](10) NULL,
	[WIB015] [nchar](10) NULL,
	[WIB016] [nchar](10) NULL,
	[WIB017] [nchar](10) NULL,
	[WIB018] [nchar](10) NULL,
	[WIB019] [nchar](10) NULL,
	[WIB020] [nchar](10) NULL,
 CONSTRAINT [PK_MOXWIB] PRIMARY KEY CLUSTERED 
(
	[WIB001] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'匝数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'绕线模号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'绕线模数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'软管号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB008'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'线规' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB009'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'额定电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB010'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'并联路数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB011'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'引出线规格（平方）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB012'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'引出线长度（根）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIB', @level2type=N'COLUMN',@level2name=N'WIB013'
GO

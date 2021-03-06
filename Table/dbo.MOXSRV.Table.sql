USE [MT]
GO
/****** Object:  Table [dbo].[MOXSRV]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOXSRV](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[SRV001] [nvarchar](50) NULL,
	[SRV002] [nvarchar](50) NULL,
	[SRV003] [nvarchar](50) NULL,
	[SRV004] [nvarchar](50) NULL,
	[SRV005] [nvarchar](50) NULL,
	[SRV006] [decimal](11, 6) NULL,
	[SRV007] [varchar](50) NULL,
	[SRV008] [nchar](10) NULL,
	[SRV009] [nchar](10) NULL,
	[SRV010] [nchar](10) NULL,
	[SRV011] [nchar](10) NULL,
	[SRV012] [nchar](10) NULL,
	[SRV013] [nchar](10) NULL,
	[SRV014] [nchar](10) NULL,
	[SRV015] [nchar](10) NULL,
	[SRV016] [nchar](10) NULL,
	[SRV017] [nchar](10) NULL,
	[SRV018] [nchar](10) NULL,
	[SRV019] [nchar](10) NULL,
	[SRV020] [nchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRV', @level2type=N'COLUMN',@level2name=N'SRV007'
GO

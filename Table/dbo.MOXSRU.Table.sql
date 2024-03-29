USE [MT]
GO
/****** Object:  Table [dbo].[MOXSRU]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MOXSRU](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[SRU001] [nvarchar](50) NULL,
	[SRU002] [nvarchar](50) NULL,
	[SRU003] [nvarchar](50) NULL,
	[SRU004] [nvarchar](50) NULL,
	[SRU005] [nvarchar](50) NULL,
	[SRU006] [decimal](11, 6) NULL,
	[SRU007] [varchar](50) NULL,
	[SRU008] [nchar](10) NULL,
	[SRU009] [nchar](10) NULL,
	[SRU010] [nchar](10) NULL,
	[SRU011] [nchar](10) NULL,
	[SRU012] [nchar](10) NULL,
	[SRU013] [nchar](10) NULL,
	[SRU014] [nchar](10) NULL,
	[SRU015] [nchar](10) NULL,
	[SRU016] [nchar](10) NULL,
	[SRU017] [nchar](10) NULL,
	[SRU018] [nchar](10) NULL,
	[SRU019] [nchar](10) NULL,
	[SRU020] [nchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXSRU', @level2type=N'COLUMN',@level2name=N'SRU007'
GO

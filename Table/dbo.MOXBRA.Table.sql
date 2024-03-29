USE [MT]
GO
/****** Object:  Table [dbo].[MOXBRA]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXBRA](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[BRA001] [nvarchar](50) NULL,
	[BRA002] [nvarchar](50) NULL,
	[BRA003] [nvarchar](50) NULL,
	[BRA004] [nvarchar](50) NULL,
	[BRA005] [nchar](10) NULL,
	[BRA006] [nchar](10) NULL,
	[BRA007] [nchar](10) NULL,
	[BRA008] [nchar](10) NULL,
	[BRA009] [nchar](10) NULL,
	[BRA010] [nchar](10) NULL,
	[BRA011] [nchar](10) NULL,
	[BRA012] [nchar](10) NULL,
	[BRA013] [nchar](10) NULL,
	[BRA014] [nchar](10) NULL,
	[BRA015] [nchar](10) NULL,
	[BRA016] [nchar](10) NULL,
	[BRA017] [nchar](10) NULL,
	[BRA018] [nchar](10) NULL,
	[BRA019] [nchar](10) NULL,
	[BRA020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRA', @level2type=N'COLUMN',@level2name=N'BRA001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRA', @level2type=N'COLUMN',@level2name=N'BRA002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRA', @level2type=N'COLUMN',@level2name=N'BRA003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXBRA', @level2type=N'COLUMN',@level2name=N'BRA004'
GO

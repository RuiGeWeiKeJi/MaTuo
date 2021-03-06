USE [MT]
GO
/****** Object:  Table [dbo].[MOXRES]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXRES](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[RES001] [nvarchar](50) NULL,
	[RES002] [nvarchar](50) NULL,
	[RES003] [nvarchar](50) NULL,
	[RES004] [nvarchar](50) NULL,
	[RES005] [bit] NULL,
	[RES006] [bit] NULL,
	[RES007] [nvarchar](10) NULL,
	[RES008] [decimal](11, 2) NULL,
	[RES009] [decimal](11, 2) NULL,
	[RES010] [decimal](11, 2) NULL,
	[RES011] [nvarchar](10) NULL,
	[RES012] [nvarchar](10) NULL,
	[RES013] [nchar](10) NULL,
	[RES014] [nchar](10) NULL,
	[RES015] [nchar](10) NULL,
	[RES016] [nchar](10) NULL,
	[RES017] [nchar](10) NULL,
	[RES018] [nchar](10) NULL,
	[RES019] [nchar](10) NULL,
	[RES020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'耐压2260V，测试一分钟无击穿' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'匝间检验合格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 绝缘电阻（MΩ）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'(黄-绿)线间电阻(Ω)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES008'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'(绿-红)线间电阻(Ω)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES009'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'(黄-红)线间电阻(Ω)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES010'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'环境温度（℃）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES011'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电阻不平衡度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXRES', @level2type=N'COLUMN',@level2name=N'RES012'
GO

USE [MT]
GO
/****** Object:  Table [dbo].[MOXWIE]    Script Date: 10/30/2017 08:59:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXWIE](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[WIE001] [nvarchar](50) NULL,
	[WIE002] [nvarchar](50) NULL,
	[WIE003] [nvarchar](50) NULL,
	[WIE004] [date] NULL,
	[WIE005] [nvarchar](50) NULL,
	[WIE006] [int] NULL,
	[WIE007] [nvarchar](50) NULL,
	[WIE008] [int] NULL,
	[WIE009] [int] NULL,
	[WIE010] [decimal](11, 2) NULL,
	[WIE011] [nchar](10) NULL,
	[WIE012] [nchar](10) NULL,
	[WIE013] [nchar](10) NULL,
	[WIE014] [nchar](10) NULL,
	[WIE015] [nchar](10) NULL,
	[WIE016] [nchar](10) NULL,
	[WIE017] [nchar](10) NULL,
	[WIE018] [nchar](10) NULL,
	[WIE019] [nchar](10) NULL,
	[WIE020] [nchar](10) NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE002'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE003'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生产时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE004'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'批号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE005'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE006'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品质部签字(换线规时）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE007'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作时间(同一规格）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE008'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'平均时间（同一规格）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE009'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'重量(KG)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXWIE', @level2type=N'COLUMN',@level2name=N'WIE010'
GO

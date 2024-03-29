USE [MT]
GO
/****** Object:  Table [dbo].[MOXART]    Script Date: 10/18/2017 13:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOXART](
	[idx] [int] IDENTITY(1,1) NOT NULL,
	[ART001] [nvarchar](50) NOT NULL,
	[ART002] [nvarchar](50) NOT NULL,
	[ART003] [nchar](10) NULL,
	[ART004] [nchar](10) NULL,
	[ART005] [nchar](10) NULL,
	[ART006] [nchar](10) NULL,
	[ART007] [nchar](10) NULL,
	[ART008] [nchar](10) NULL,
	[ART009] [nchar](10) NULL,
	[ART010] [nchar](10) NULL,
 CONSTRAINT [PK_MOXART] PRIMARY KEY CLUSTERED 
(
	[ART001] ASC,
	[ART002] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工艺名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXART', @level2type=N'COLUMN',@level2name=N'ART001'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工艺类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MOXART', @level2type=N'COLUMN',@level2name=N'ART002'
GO

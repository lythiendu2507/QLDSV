drop Table [dbo].[DIEM]
go
SET ANSI_PADDING ON
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [char](12) NOT NULL,
	[MAMH] [char](6) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[DIEM] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_999713B2414D4E138AB3C3E8A848E28A]  DEFAULT (newsequentialid())
)

GO
SET ANSI_NULLS ON

go

SET QUOTED_IDENTIFIER ON

go

SET ANSI_PADDING ON

GO
ALTER TABLE [dbo].[DIEM] ADD  CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO

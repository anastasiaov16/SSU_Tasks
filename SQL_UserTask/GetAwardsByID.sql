USE [User]
GO

/****** Object:  Table [dbo].[Awards]    Script Date: 06.06.2019 14:17:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Awards](
	[ID] [int] NOT NULL,
	[Title] [varchar](30) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

drop table Awards


go
create procedure GetAwardsByID
@ID int
as
select * from Awards
where ID=@ID

exec GetAwardsByID 1

drop procedure GetAwardsByID
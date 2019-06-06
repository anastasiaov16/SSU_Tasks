USE [User]
GO

/****** Object:  Table [dbo].[UsAw]    Script Date: 05.06.2019 13:32:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UsAw](
	[ID] [int] NOT NULL,
	[Us] [int] NOT NULL,
	[Aw] [int] NOT NULL
) ON [PRIMARY]

go
create procedure UserAwards
@IdUs int,
@IdAw int
as
insert into UsAw values((select MAX(ID) from UsAw)+1, @IdUs, @IdAw)

insert into UsAw values(1, 1,1)

drop table UsAw

go
create procedure GetUsAw
@IdUs int
as
select UA.Us,
A.ID,
A.Title
from UsAw as UA
inner join Awards as A on UA.Us=@IdUs and UA.Aw=A.ID

exec GetUsAw 1

drop procedure GetUsAw
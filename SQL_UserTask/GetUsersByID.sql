go
create procedure GetByID
@ID int
as
select * from Users
where ID=@ID
go 
create procedure DeleteUser
@ID int
as
delete from Users
where ID=@ID

exec DeleteUser 3
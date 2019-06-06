go
create procedure AddUser
@Name varchar(30),
@DateOfBirth datetime,
@Age int
as
Insert into Users(ID, Name, DateOfBirth, Age) values((select MAX(ID) from Users)+1 , @Name, @DateOfBirth, @Age)

drop procedure AddUser

exec AddUser Petrov, "2014.01.01", 6

select * from Users
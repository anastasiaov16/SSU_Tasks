go
create procedure AddAwards
@Title varchar(30)
as
Insert into Awards(ID, Title) values((select MAX(ID) from Awards)+1 , @Title)

drop procedure AddUser

exec AddUser Petrov, "2014.01.01", 6

select * from Users

insert into Awards(ID, Title) values (1, 'GoodBoy')
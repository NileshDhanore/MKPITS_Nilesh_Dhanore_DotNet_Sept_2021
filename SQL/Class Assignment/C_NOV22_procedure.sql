create procedure SPshowEmployeeSalary
(
@sal decimal
)
as
begin
select * from employee where salary<@sal;
end
go

drop procedure SPshowEmployeeSalary ------ to delet the procedure

execute SPshowEmployeeSalary 3000;

Alter procedure SPshowEmployeeSalary
(@sal decimal)
as 
begin
select * from employee where salary <@sal;
select * from employee where salary >=@sal;
end

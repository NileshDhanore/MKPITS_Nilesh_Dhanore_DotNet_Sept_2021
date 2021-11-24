
use mydb;
create table employee(Id int primary key identity(1,1),firstname varchar(20),lastname varchar(20), 
salary decimal(12,2),branch varchar(20),city varchar(20));
--drop table employee

insert into employee(firstname,lastname,salary,city)values('Bill','Gates',2400.00,'Newyork');
insert into employee(firstname,lastname,salary,city)values('Ashok','Kumar',2300.00,'Mumbai');
insert into employee(firstname,lastname,salary,city)values('Kishor','Kumar',3500.00,'Delhi');
insert into employee(firstname,lastname,salary,city)values('Bilas','Ghui',9400.00,'Asansol');
insert into employee(firstname,lastname,salary,city)values('Amit','Kumar',8300.00,'Mumbai');
insert into employee(firstname,lastname,salary,city)values('Manoj','Kumar',7500.00,'Delhi');
------------------------------------------------------------------------------------------
select * from employee where city like 'Delhi';
--------------------------------------------------------------------------
select firstname,lastname,city from employee where city like 'Delhi';
select firstname,lastname,city from employee where city like 'Mu%';
select firstname,lastname,city from employee where city like '%s%';
select firstname,lastname,city from employee where city like '%lh%';
------------------------------------------------------------------------------
--wild card character % ?,*
-----------------------------------------------------------------------------

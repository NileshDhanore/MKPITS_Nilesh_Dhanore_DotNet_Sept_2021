use mydb;
create table Teacher(Id int, fname varchar(20),lname varchar(20),qualification varchar(20),Institute varchar(20),category varchar(20));
insert into Teacher values(12,'Nilesh','Dhanore','BE,MTECH' ,'JIT', 'Asst.Professor');
select * from Teacher;
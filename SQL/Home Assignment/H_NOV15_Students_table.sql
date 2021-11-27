create table students(id int, firstname varchar(20), lastname varchar(20), branch varchar(20), city varchar (20));
-----drop table students
insert into students values (1, 'Akash', 'Narwade','electrical','nagpur');
insert into students values (2, 'Roshan', 'Thakre','ETC','nagpur');
insert into students values (3, 'Hritvik', 'Gayaki','CSE','Saikheda');
insert into students values (4, 'Nikhil', 'Kumbhare','AI&ML','Banglore');
insert into students values (5, 'Ashish', 'Dongre','ME','nagpur');

select * from students order by firstname  ----- it is used to select name by firstname alphabate
update students set city='Mumbai' where id= 1; -----to upate already data present in akash city is changes from nagpur to mumbai
update students set branch ='ETC' where firstname='Nikhil';
select * from students
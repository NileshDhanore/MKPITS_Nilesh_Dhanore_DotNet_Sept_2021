create table showconstraints(ID int primary key identity(11,1),firstname varchar(20) not null,lastname varchar(20) default('kumar'));
insert into showconstraints(firstname)values('Akash'); -----not null have given compulsary data in vox
insert into showconstraints(firstname,lastname)values('Akash','Narwade');
select * from showconstraints;
alter table showconstraints alter column firstname varchar(30); ---to increase size  (it has to be chnge after amking table)
alter table showconstraints alter column lastname varchar(20) not null;   --value has to be given
alter table showconstraints add salary decimal(12,2);   --to insert salary column

insert into showconstraints(firstname,salary)values('Yashwant','34000');
insert into showconstraints(firstname,salary)values('Aamn','25000');
alter table showconstraints alter column salary decimal(12,2) not null; --- already null value is there in some record
alter table showconstraints alter column salary decimal(12,2) check
--(to check check condition)
create table IndianEmployee(ID int primary key identity(11,1),firstname varchar(20) not null,lastname varchar(20) default('kumar'),salary decimal(12,0)check(salary>10000));;
insert into IndianEmployee(firstname,salary)values('Mayur',4000);
insert into IndianEmployee(firstname,salary)values('Vikas',12000);
select * from IndianEmployee;


--(primary key never empty)
--(unique has one empty cell)
create table Indiancar(carId int primary key identity(11,1),carname varchar(30) unique,brand varchar(30)check(brand in ('Maruti','Mahindra','Tata','Hero','Bajaj')),model varchar(10),price decimal(12,0)check(price>50000));
insert into IndianCar(carname,brand,model,price)values('maruti car','Maruti','Alto k10',400000);
insert into IndianCar(carname,brand,model,price)values('tata Indica','tata','Indica',700000);
insert into IndianCar(brand,model,price)values('Maruti','Swift',600000);--unique concept has one empty cell
insert into IndianCar(brand,model,price)values('Maruti','Swiftsuv',900000); --only one time it will execute
select * from Indiancar;
--(concept to learn)
--create table mymath(a int ,b int);
--insert into mymath values(12,24)
--select *from mymath;
--alter table mymath add constraint pk primary key;  --primary key is always apply during making table 
create table category(catid int primary key identity(1,1), catname varchar(30) unique check (catname in ('soap','shampoo','Detergent','oil','handwash','grains','biscuits','pulses','edible oil')));
drop table category;
insert into category(catname)values('soap');
insert into category(catname)values('shampoo');
insert into category(catname)values('Detergent');
insert into category(catname)values('oil');
insert into category(catname)values('handwash');
insert into category(catname)values('grains');
insert into category(catname)values('biscuit');
insert into category(catname)values('pulses');
insert into category(catname)values('edible oil');
insert into category(catname)values(null);
delete from category where catname= null

select *from category order by catid;


create table products (id int primary key identity(1,1), productname varchar(20),price decimal(10,2) check (price>0.0),mfg date,
catId int foreign key references category(catid));
drop table products;
insert into products(productname,price,mfg,catid)values('wheat',40,getdate(),6);
insert into products(productname,price,mfg,catid)values('Mung',40,'2021-10-08',8);
insert into products(productname,price,mfg,catid)values('Santoor',30,getdate(),1);
insert into products(productname,price,mfg,catid)values('LifeBuy',20,'2021-10-08',1);
insert into products(productname,price,mfg,catid)values('Patanjali',40,getdate(),7);
insert into products(productname,price,mfg,catid)values('Coconut biscuit',40,'2021-10-08',7);
insert into products(productname,price,mfg,catid)values('Fortune',2800,getdate(),9);
insert into products(productname,price,mfg,catid)values('Medicare',40,'2021-10-08',5);
insert into products(productname,price,mfg,catid)values('Rice',70,getdate(),6);
insert into products(productname,price,mfg,catid)values('Lux',140,'2021-10-08',2);
select * from products;
select count(*) from products where catid=1;
----group by clause of select query is used with aggrigate functions to get sum, avg etc for specific category
select  sum(price)from products group by catid;
select  avg(price)from products group by catid;
select  catid, sum(price)from products group by catid having catid=1;
select  catid, avg(price)from products group by catid having catid=1;
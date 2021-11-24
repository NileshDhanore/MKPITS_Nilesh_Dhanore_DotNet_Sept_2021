use mydb;
create table Indiancars(carid int primary key identity(1,1),carname varchar(20),brand  varchar(20), model varchar(20), price int, modelyear int);
drop table Indiancars;
insert into Indiancars (carname,brand,model,price,modelyear)values('Maruti car','Maruti','Alto K10', 400000,1990);
insert into Indiancars (carname,brand,model,price,modelyear)values('Swift Desire','Maruti','Swift', 600000,2005);
insert into Indiancars (carname,brand,model,price,modelyear)values('Tata Indica','Tata','Indica', 700000,2001);
insert into Indiancars (carname,brand,model,price,modelyear)values('indica5','Tata','tataIndica', 78000,1987);
insert into Indiancars (carname,brand,model,price,modelyear)values('boolero7','mahindra','boolero', 98000,1987);
insert into Indiancars (carname,brand,model,price,modelyear)values('Tiago 5','Tata','tata Tiago', 908000,1989);
insert into Indiancars (carname,brand,model,price,modelyear)values('Scoda','Tata','XYZ', 108000,1389);

select * from Indiancars;


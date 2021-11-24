create table tblproducts(productid int primary key,productname varchar(30),qty int,price int);

insert into tblproducts(productid,productname,qty,price)values(1,'Egg',10,80);


select * from tblproducts;

create table tblsales(salesid int identity(1,1),productid int,QtySold int);

select * from tblsales;

declare @productid int =2,@qtyforsale int=300, @qty int;
begin transaction
select @qty=qty from tblproducts where productid = @productid;
update tblproducts set qty=qty-@qtyforsale where productid =@productid;
insert into tblsales(productid,qtysold)values (@productid,@qtyforsale);
if(@qty<@qtyforsale)
begin
rollback transaction
print 'transaction failed'
end
else 
begin
commit transaction
print 'transaction successfull'
end
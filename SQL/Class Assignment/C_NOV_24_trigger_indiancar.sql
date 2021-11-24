create trigger trgInsteadOfupdate ON dbo.Indiancars
instead of update
as
declare @cars_id int, @cars_name varchar(20),
@cars_brand varchar(20),@cars_model varchar(20),
@cars_price int, @cars_modelyear int, @audit_action varchar(220);
select @cars_id=i.carid from inserted i;
select @cars_name=i.carname from inserted i;
select @cars_brand=i.brand from inserted i;
select @cars_model=i.model from inserted i;
select @cars_price=i.price from inserted i;
select @cars_modelyear=i.modelyear from inserted i;
set @audit_action='update data using trigger';

begin
    begin tran
	if(@cars_price<100)
	begin
	raiserror ('cannot udate price < 100',16,1);
	rollback;
	end

	else
	 begin 
	 insert into Indiancar_test_audit(carid,carname,brand,model,price,modelyear) values(
	 @cars_id,@cars_name,@cars_brand,@cars_model,@cars_price,@cars_modelyear);
	 update Teacher set price=@cars_price,modelyear=@cars_modelyear
	 commit;
	 print 'record updated === instead of update trigger';
	 end
end
	 
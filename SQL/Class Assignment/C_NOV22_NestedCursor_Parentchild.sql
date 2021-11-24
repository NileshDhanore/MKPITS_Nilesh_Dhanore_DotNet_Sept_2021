DECLARE @parentid INT, @parentname varchar(20),
@childid int, @childname varchar(20), @age int;

declare parent_cursor cursor 
for
select parentid,parentname from parent 

open parent_cursor;

fetch next from parent_cursor into @parentid,@parentname;

select @parentid;
while @@FETCH_STATUS = 0

begin
fetch next from parent_cursor into @parentid,@parentname;
print convert(varchar(20),@parentid) +@parentname;
end

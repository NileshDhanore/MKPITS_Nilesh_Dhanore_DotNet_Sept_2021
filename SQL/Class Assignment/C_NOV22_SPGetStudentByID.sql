create procedure SPGetStudentByID
(
@id int
)
as
begin
select * from student where Roll_no = @id;
end
go

execute SPGetStudentByID 2

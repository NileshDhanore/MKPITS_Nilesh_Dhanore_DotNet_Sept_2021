

Alter procedure ADDtwonumbers(@p1 int,@p2 int, @result int output)

as
begin
   set @result = @p1+@p2
   end
   go

  

	DECLARE @R int

EXEC	ADDtwonumbers
		@p1 = 24,
		@p2 = 20,
		@Result = @R OUTPUT

SELECT	@R as '@Result'


GO
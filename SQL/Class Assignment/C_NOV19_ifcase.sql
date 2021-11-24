Alter procedure SPCallvVelocity
                 @distance float,
				 @time float,
				 @velocity float OUTPUT
AS
if(@time=0.0)
BEGIN
select @time = 1;
select @velocity = @distance;
END
ELSE
BEGIN
select @velocity=@distance/@time;
end
----------------------
declare @v float
execute SPCallvVelocity
@distance=80,
@time=5.2,
@velocity=@v output;
select @v

CREATE PROCEDURE SPFindCarByModelyear
	
(
    @modelyear varchar(20),
    @car_count INT OUTPUT
) AS
BEGIN
    SELECT 
        carname,
        brand,modelyear
    FROM
        Indiancars
    WHERE
        modelyear= @modelyear;

    SELECT @car_count = @@ROWCOUNT;------ rowcount is from serever not form users laptop
END;
declare @count int;
execute SPFindCarByModelyear @modelyear=1987,
                          @car_count =@count out;
	select @count as 'count of cars';

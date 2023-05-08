create or alter procedure SP_city
@personid int,
@city varchar(255) output
as
begin
select @city = city from persons where @personid = @personid
end;


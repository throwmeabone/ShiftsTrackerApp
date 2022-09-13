CREATE PROCEDURE [dbo].[spShifts_InsertShift]
	@startDateTime date,
	@endDateTime date,
	@pay money,
	@minutes decimal(8,2),
	@location nvarchar(50)
AS
begin

insert into dbo.Shifts (StartDateTime, EndDateTime, Pay, Minutes, Location)
values (@startDateTime, @endDateTime, @pay, @minutes, @location)

end
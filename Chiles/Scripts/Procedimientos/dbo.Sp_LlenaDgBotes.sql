CREATE PROCEDURE [dbo].[Sp_LlenaDgBotes]
@IdProduccion as int
AS
	SELECT *
	from Botes
	where IdProduccion = @IdProduccion
	order by IdBotes desc
CREATE PROCEDURE [dbo].[sp_EliBotes]
@IdBotes int 
AS
DELETE FROM Botes  WHERE IdBotes = @IdBotes
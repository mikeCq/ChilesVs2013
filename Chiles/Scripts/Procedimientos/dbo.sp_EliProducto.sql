CREATE PROCEDURE [dbo].[sp_EliProducto]
	@IdProducto int
AS
declare @conteo int
begin
delete from Productos where IdProducto = @IdProducto

set @conteo = (select count(idproducto) from Productos)

DBCC CHECKIDENT (Productos, RESEED, @conteo)
end
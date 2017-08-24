CREATE PROCEDURE [dbo].[sp_selProducto]
	@IdProducto int
AS
	SELECT idproducto, nombre 
	from Productos 
	where IdProducto = @idproducto
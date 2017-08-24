CREATE PROCEDURE [dbo].[sp_LLenaDgBusquedaProduccion]
@fechaini as date ,
@fechafin as date ,
@Producto as varchar(20)
AS
DECLARE
@FECHAHOY AS DATE = GETDATE()
BEGIN
	if @fechaini = '01/01/2000' and @fechafin = '01/01/2000' and @Producto = ''
		begin
			SELECT IdProduccion,
				   fecha,
				   precio,
				   Producto,
				   IdEstatus
			from Produccion
			where IdEstatus = 1
		end
	if @fechaini = '01/01/2000' and @fechafin = '01/01/2000' and @Producto <> ''
		begin
			SELECT IdProduccion,
				   fecha,
				   precio,
				   Producto,
				   IdEstatus
			from Produccion
			where Producto = @Producto and IdEstatus = 1
		end
	if @fechaini <> '01/01/2000' and @fechafin <> '01/01/2000' and @Producto <> ''
		begin
			SELECT IdProduccion,
				   fecha,
				   precio,
				   Producto,
				   IdEstatus
			from Produccion
			where Fecha between @fechaini and @fechafin and Producto = @Producto and IdEstatus = 1
		end
	if @fechaini = @FECHAHOY and @fechafin = @FECHAHOY and @Producto <> ''
		begin
			SELECT IdProduccion,
				   fecha,
				   precio,
				   Producto,
				   IdEstatus
			from Produccion
			where Fecha = @fechaini or Fecha = @fechafin and
				  Producto = @Producto and
				  IdEstatus = 1
		end
	if @fechaini = @FECHAHOY and @fechafin = @FECHAHOY and @Producto = ''
		begin
			SELECT IdProduccion,
				   fecha,
				   precio,
				   Producto,
				   IdEstatus
			from Produccion
			where Fecha = @fechaini or Fecha = @fechafin and
				  IdEstatus = 1
		end
END
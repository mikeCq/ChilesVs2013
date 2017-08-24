CREATE TABLE [dbo].[Produccion] (
    [IdProduccion]  INT             IDENTITY (1, 1) NOT NULL,
    [Fecha]         DATE            NULL,
    [Precio]        DECIMAL (10, 2) NULL,
    [CantidadBotes] INT             NULL,
    [SumaBotes]     DECIMAL (10, 2) NULL,
    [Producto]      VARCHAR (20)    NULL,
    [IdEstatus]     INT             NULL,
    [FechaLetra]    VARCHAR (20)    NULL,
    PRIMARY KEY CLUSTERED ([IdProduccion] ASC)
);


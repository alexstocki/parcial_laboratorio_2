USE [SistemaDB]
GO

/****** Object:  Table [dbo].[Compra_detalle]    Script Date: 24/11/2020 06:41:53 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Compra_detalle](
	[id] [int] NOT NULL,
	[producto] [varchar](100) NOT NULL,
	[precio] [decimal](6, 2) NOT NULL
) ON [PRIMARY]
GO


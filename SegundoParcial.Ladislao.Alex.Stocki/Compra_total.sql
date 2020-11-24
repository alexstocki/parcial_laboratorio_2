USE [SistemaDB]
GO

/****** Object:  Table [dbo].[Compra_total]    Script Date: 24/11/2020 06:42:10 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Compra_total]') AND type in (N'U'))
DROP TABLE [dbo].[Compra_total]
GO

/****** Object:  Table [dbo].[Compra_total]    Script Date: 24/11/2020 06:42:10 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Compra_total](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[total] [decimal](6, 2) NOT NULL,
	[direccion] [varchar](150) NOT NULL,
	[cliente] [varchar](150) NOT NULL,
	[tipo_entrega] [varchar](100) NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Compra_total] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


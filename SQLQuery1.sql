select * from escuela\

drop table escuela

USE [estudiante]
GO

/****** Object:  Table [dbo].[Escuela]    Script Date: 01/09/2020 2:22:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Escuela](
	[Nombre] [varchar](50) NULL,
	[Genero] [nchar](10) NULL,
	[Telefono] [varchar](50) NULL,
	[Carrera] [varchar](50) NULL,
	[Condiciones] [varchar](50) NULL
) ON [PRIMARY]
GO



select * from [Escuela]
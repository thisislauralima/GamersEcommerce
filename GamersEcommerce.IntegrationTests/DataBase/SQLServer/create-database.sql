USE GamersEcommerce

BEGIN TRANSACTION;
SET ANSI_NULLS ON
GO -- isso aqui faz com que as linhas null não sejam retornadas em comandos WHERE

SET QUOTED_IDENTIFIER ON
GO -- aspas duplas serão interpretadas como [], sendo interpretadas pelo sql como objetos
-- se fosse simples as aspas seriam interpratadas interpretadas como '', que são usadas para strings no sql

CREATE TABLE [dbo].PRODUCT(
 [ProductId] INT NOT NULL,
 [Name] [nvarchar] (150) NOT NULL,
 [CategoryId] INT NOT NULL,
 [Product_Registration_Date] DATETIME NOT NULL,
 CONSTRAINT [ProductId] PRIMARY KEY CLUSTERED
 ([ProductId] ASC)
 WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
)
ON [PRIMARY]
GO
COMMIT TRANSACTION;
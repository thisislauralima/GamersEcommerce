USE GamersEcommerce

BEGIN TRANSACTION;
SET ANSI_NULLS ON
GO -- isso aqui faz com que as linhas null não sejam retornadas em comandos WHERE

SET QUOTED_IDENTIFIER ON
GO -- aspas duplas serão interpretadas como [], sendo interpretadas pelo sql como objetos
-- se fosse simples as aspas seriam interpratadas interpretadas como '', que são usadas para strings no sql

CREATE TABLE [dbo].PRODUCT(
 [Product_Id] INT NOT NULL,
 [Name] [nvarchar] (150) NOT NULL,
 [Category_Id] INT NOT NULL,
 [Product_Registration_Date] DATETIME NOT NULL,
 CONSTRAINT [Product_Id] PRIMARY KEY CLUSTERED
 ([Product_Id] ASC)
 WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
)
ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].PRODUCT_STOCK_QUANTITY(
 [Product_Stock_Quantity_Id] INT NOT NULL,
 [Product_Quantity] INT NOT NULL,
 [Is_Out_Of_Stock] BIT NOT NULL,
 [Product_Id] INT NOT NULL,
 CONSTRAINT [FK_ProductId] FOREIGN KEY (Product_Id) REFERENCES PRODUCT(Product_Id),
 CONSTRAINT [Product_Stock_Quantity_Id] PRIMARY KEY CLUSTERED
 ([Product_Stock_Quantity_Id] ASC)
 WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
)
ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].PRODUCT_SALE_HISTORY(
 [Product_Sale_History_Id] INT NOT NULL,
 [Product_Id] INT NOT NULL,
 [Product_Registration_Date] DATETIME NOT NULL,
 CONSTRAINT [FK_PSH_ProductId] FOREIGN KEY (Product_Id) REFERENCES Product(Product_Id),
 CONSTRAINT [Product_Sale_History_Id] PRIMARY KEY CLUSTERED
 ([Product_Sale_History_Id] ASC)
 WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
)
ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].CATEGORY(
 [Category_Id] INT NOT NULL,
 [Name] Varchar(150) NOT NULL,
 CONSTRAINT [Category_Id] PRIMARY KEY CLUSTERED
 ([Category_Id] ASC)
 WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
)
ON [PRIMARY]
GO

COMMIT TRANSACTION;


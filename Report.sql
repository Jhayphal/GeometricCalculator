DROP TABLE IF EXISTS dbo.[Products];
GO

CREATE TABLE dbo.[Products] (
	[Id] BIGINT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(64) NOT NULL
)
GO

DROP TABLE IF EXISTS dbo.[Categories];
GO

CREATE TABLE dbo.[Categories] (
	[Id] BIGINT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(64) NOT NULL
)
GO

DROP TABLE IF EXISTS dbo.[ProductCategory];
GO

CREATE TABLE dbo.[ProductCategory] (
	[Id] BIGINT IDENTITY PRIMARY KEY,
	[ProductId] BIGINT NOT NULL,
	[CategoryId] BIGINT NOT NULL
)
GO

INSERT INTO dbo.[Products] ([Name]) VALUES
  ('dbForge Studio for SQL Server')
, ('dbForge Studio for Postgres')
, ('dbForge Studio for MySQL')
, ('dbForge Studio for Oracle')
, ('OnTaxi')
, ('dbExpress Drivers')
, ('Skyvia');
GO

INSERT INTO dbo.[Categories] ([Name]) VALUES
  ('Database Tools')
, ('Drivers')
, ('Web Services')
GO

INSERT INTO dbo.[ProductCategory] ([ProductId], [CategoryId]) VALUES
  (1, 1)
, (2, 1)
, (3, 1)
, (4, 1)
, (6, 2)
, (7, 3);
GO

SELECT
	  p.[Name] [Product]
	, c.[Name] [Category]
FROM dbo.[Products] p
LEFT JOIN dbo.[ProductCategory] pc
	ON pc.[ProductId] = p.[Id]
LEFT JOIN dbo.[Categories] c
	ON c.[Id] = pc.[CategoryId]
GO
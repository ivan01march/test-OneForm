--
-- Скрипт сгенерирован Devart dbForge Studio for SQL Server, Версия 5.5.369.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/sql/studio
-- Дата скрипта: 31.08.2018 12:34:33
-- Версия сервера: 14.00.3035
--

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT dbo.Countries ON
GO
MERGE INTO dbo.Countries t1 USING (SELECT 1 id) t2 ON (t1.Id = 2)
WHEN MATCHED THEN UPDATE  SET CreatedDate = '2018-08-31 12:29:52.8197990', UpdatedDate = '2018-08-31 12:29:55.0697821', Name = N'Россия'
WHEN NOT MATCHED THEN INSERT (Id, CreatedDate, UpdatedDate, Name) VALUES (2, '2018-08-31 12:29:52.8197990', '2018-08-31 12:29:55.0697821', N'Россия');
MERGE INTO dbo.Countries t1 USING (SELECT 1 id) t2 ON (t1.Id = 3)
WHEN MATCHED THEN UPDATE  SET CreatedDate = '2018-08-31 12:30:06.1481569', UpdatedDate = '2018-08-31 12:30:08.0819855', Name = N'Казахстан'
WHEN NOT MATCHED THEN INSERT (Id, CreatedDate, UpdatedDate, Name) VALUES (3, '2018-08-31 12:30:06.1481569', '2018-08-31 12:30:08.0819855', N'Казахстан');
GO
SET IDENTITY_INSERT dbo.Countries OFF
GO
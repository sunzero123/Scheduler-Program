USE [<<DATABASE NAME HERE>>]
GO

UPDATE TaskTypes
    SET deleted = 1
    WHERE taskType = '<<task type to delete goes here>>';

GO






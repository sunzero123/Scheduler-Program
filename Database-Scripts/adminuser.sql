USE [<<DATABASE NAME HERE>>]
GO

INSERT INTO users
           (username, password, isAdmin, deleted)
     VALUES
           ('admin',
		HASHBYTES('SHA2_512', 'admin'), -- 'admin' can be changed to any default password you want
           1, 0)
GO



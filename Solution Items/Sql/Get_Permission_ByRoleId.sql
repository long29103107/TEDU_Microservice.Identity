Use [TeduIdentity]
GO 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON 
GO 

CREATE PROCEDURE [Get_Permission_ByRoleId]
	@roleId varchar(50) null

AS 
BEGIN
	-- Set NOCOUNT ON added to prevent extra result sets from
	-- intefering  with SELECT statements
	SET NOCOUNT ON;
	SELECT *
	FROM [Identity].Permissions
	WHERE roleId = @roleId
END


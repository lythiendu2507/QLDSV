drop Procedure [dbo].[sp_TaoTaiKhoan]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[sp_TaoTaiKhoan]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'PGV' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'KHOA'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'USER'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

   IF @ROLE= 'PKeToan'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
go

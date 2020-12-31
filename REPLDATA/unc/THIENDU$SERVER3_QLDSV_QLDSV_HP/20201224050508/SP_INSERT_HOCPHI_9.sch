drop Procedure [dbo].[SP_INSERT_HOCPHI]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go

CREATE PROC [dbo].[SP_INSERT_HOCPHI]
@MASV char(12),
@NIENKHOA nvarchar(50),
@HOCKY INT,
@HOCPHI INT,
@SOTIENDONG INT

AS
DECLARE @ngaythang date
SET @ngaythang = GETDATE()



INSERT DBO.CT_DONGHOCPHI(MASV,NIENKHOA,HOCKY,NGAYDONG,SOTIENDONG)
VALUES(@MASV,@NIENKHOA,@HOCKY,@ngaythang,@SOTIENDONG)
go

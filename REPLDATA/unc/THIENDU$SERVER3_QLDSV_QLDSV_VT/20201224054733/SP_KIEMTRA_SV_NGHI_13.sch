drop Procedure [dbo].[SP_KIEMTRA_SV_NGHI]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[SP_KIEMTRA_SV_NGHI]
@MASV char(12)
AS
IF EXISTS(SELECT 1 FROM DBO.SINHVIEN WHERE MASV=@MASV)
BEGIN
SELECT SV.NGHIHOC
FROM DBO.SINHVIEN SV
WHERE SV.MASV=@MASV
END
ELSE
SELECT CAST(0 as bit)




go

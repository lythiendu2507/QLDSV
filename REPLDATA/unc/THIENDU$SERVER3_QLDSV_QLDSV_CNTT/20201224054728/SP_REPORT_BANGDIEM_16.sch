drop Procedure [dbo].[SP_REPORT_BANGDIEM]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[SP_REPORT_BANGDIEM]
@MALOP CHAR(8),
@MAMH CHAR(6),
@LANTHI smallint
AS

SELECT SV.HOTEN, D.DIEM
FROM (SELECT MASV, HO+' '+TEN HOTEN
FROM SINHVIEN
WHERE MALOP=@MALOP AND NGHIHOC=0) SV JOIN DIEM D ON SV.MASV=D.MASV
WHERE D.MAMH=@MAMH AND D.LAN=@LANTHI


go

drop Procedure [dbo].[SP_SELECT_DIEM_THEO_MALOP_MAMH_LAN]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[SP_SELECT_DIEM_THEO_MALOP_MAMH_LAN]
@MALOP char(8),
@MAMH char(6),
@LAN smallint
AS
IF(@LAN=1)
BEGIN
	SELECT SV.MASV, (SV.HO + SV.TEN) HOTEN, SV.NGHIHOC, COALESCE(D.DIEM,-1) DIEM, COALESCE(D.LAN,1) LAN
	FROM (SELECT * FROM DBO.SINHVIEN WHERE MALOP=@MALOP) SV LEFT JOIN (SELECT * FROM DBO.DIEM WHERE MAMH=@MAMH AND LAN=1) D ON SV.MASV= D.MASV
	WHERE SV.NGHIHOC=0 OR D.DIEM IS NOT NULL -- NẾU SINH VIÊN ĐÃ NGHỈ HỌC MÀ CÓ ĐIỂM LẦN 1 THÌ VẪN XUẤT RA 
											 --NẾU SINH VIÊN ĐÃ NGHỈ HỌC MÀ CHƯA CÓ ĐIỂM LẦN 1 THÌ KHÔNG XUẤT RA
END
ELSE
BEGIN
	SELECT SV.MASV, (SV.HO + SV.TEN) HOTEN, SV.NGHIHOC,COALESCE(D.DIEM,-1) DIEM, COALESCE(D.LAN,2) LAN
	FROM (SELECT * FROM DBO.SINHVIEN WHERE MALOP=@MALOP) SV LEFT JOIN (SELECT * FROM DBO.DIEM WHERE MAMH=@MAMH AND LAN=2) D ON SV.MASV= D.MASV
	WHERE (D.DIEM IS NOT NULL OR SV.NGHIHOC= 0) AND SV.MASV NOT IN( SELECT SV.MASV FROM (SELECT * FROM DBO.SINHVIEN WHERE MALOP=@MALOP) SV LEFT JOIN (SELECT * FROM DBO.DIEM WHERE MAMH=@MAMH AND LAN=1) D ON SV.MASV= D.MASV 
						  WHERE LAN=1 AND DIEM >=4 AND MAMH=@MAMH OR LAN IS NULL) 
						  --KIỂM TRA MÃ SINH VIÊN ĐIỂM LẦN 1 MÀ LỚN HƠN BẰNG 4 THÌ KHÔNG XUẤT ĐIỂM LẦN 2
						  --KIỂM TRA MÃ SINH VIÊN LẦN 1 CHƯA NHẬP (LAN IS NULL) THÌ KHÔNG XUẤT ĐIỂM LẦN 2
END






go

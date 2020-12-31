drop Procedure [dbo].[SP_INSERT_SINHVIEN]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go

CREATE PROC [dbo].[SP_INSERT_SINHVIEN]
@MASV char(12),
@HO nvarchar(40),
@TEN nvarchar(10),
@MALOP char(8),
@PHAI bit,
@NGAYSINH datetime,
@NOISINH nvarchar(40),
@DIACHI nvarchar(80),
@GHICHU ntext,
@NGHIHOC bit
AS
INSERT DBO.SINHVIEN(MASV,HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, NGHIHOC)
VALUES(@MASV,@HO,@TEN,@MALOP,@PHAI,@NGAYSINH,@NOISINH,@DIACHI,@GHICHU,@NGHIHOC)




go

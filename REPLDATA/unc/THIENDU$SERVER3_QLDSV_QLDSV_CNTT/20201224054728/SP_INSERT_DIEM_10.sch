drop Procedure [dbo].[SP_INSERT_DIEM]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go

CREATE PROC [dbo].[SP_INSERT_DIEM]
@MASV NVARCHAR(12),  
@MAMH NVARCHAR(10),  
@LAN  smallint,  
@DIEM float  
AS  
BEGIN  
            IF EXISTS (SELECT 1 FROM DBO.DIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN)  
                BEGIN  
					IF(@DIEM=-1)
					BEGIN
					DELETE FROM DBO.DIEM WHERE MASV= @MASV AND LAN=@LAN AND MAMH=@MAMH
					END
					ELSE
					BEGIN
                    UPDATE DIEM  
                    SET DIEM = @DIEM   
                    WHERE MASV= @MASV AND LAN=@LAN AND MAMH=@MAMH  
					END
                END  
            ELSE  
                BEGIN
					IF(@DIEM !=-1)
					BEGIN
                    INSERT INTO DBO.DIEM (MASV, MAMH, LAN, DIEM)  
                    VALUES (@MASV, @MAMH, @LAN, @DIEM)  
					END
                END   
END  


go

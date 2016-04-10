use CoffeeShop

GO

CREATE PROCEDURE TK_DANGNHAP
@TenDN VARCHAR(50),
@Pass VARCHAR(50)
AS
BEGIN
	SELECT * FROM TAIKHOAN
	WHERE TenDN = @TenDN AND Pass = @Pass
END

GO

/*INSERT INTO TAIKHAN(HoTen,TenDN,Pass,IsAdmin,SLDL,NH_XEM,NH_THEM,NH_SUA,NH_XOA,HH_XEM,HH_THEM,HH_SUA,HH_XOA,KH_XEM,
	KH_THEM,KH_SUA,KH_XOA,NCC_XEM,NCC_THEM,NCC_SUA,NCC_XOA,HDN_XEM,HDN_THEM,HDN_SUA,HDN_XOA,HDX_XEM,HDX_THEM,HDX_SUA,
	HDX_XOA,PT_XEM,PT_THEM,PT_SUA,PT_XOA,PC_XEM,PC_THEM,PC_SUA,PC_XOA,LAP_ORDER,IN_MA,BCNHAP,BCXUAT,BCTHU,BCCHI,BCCNKH,
	BCCNNCC,BCLAIKH)*/


CREATE PROCEDURE TK_INSERT
@HoTen NVARCHAR(50),
@TenDN VARCHAR(50),
@Pass VARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO TAIKHAN(HoTen,TenDN,Pass) VALUES (@HoTen,@TenDN,@Pass)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : '+ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO 

CREATE PROCEDURE NV_INSERT
@Ten NVARCHAR(50),
@SDT NVARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO NHANVIEN(Ten,SDT) VALUES (@Ten,@SDT)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE NV_UPDATE
@ID INT,
@Ten NVARCHAR(50),
@SDT NVARCHAR(20)
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM NHANVIEN WHERE ID  = @ID)
		BEGIN
			UPDATE NHANVIEN SET Ten = @Ten,SDT = @SDT WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay NhanVien nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE NV_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM NHANVIEN WHERE ID  = @ID)
		BEGIN
			DELETE FROM NHANVIEN
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay NhanVien nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH



GO

GO 

CREATE PROCEDURE BAN_INSERT
@Ten NVARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO BAN(TenBan) VALUES (@Ten)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE BAN_UPDATE
@ID INT,
@Ten NVARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM BAN WHERE ID  = @ID)
		BEGIN
			UPDATE BAN SET TenBan = @Ten WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay Ban nayy'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE BAN_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM BAN WHERE ID  = @ID)
		BEGIN
			DELETE FROM BAN
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay Ban nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH


GO 

CREATE PROCEDURE NH_INSERT
@Ten NVARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO NHOMHANG(TenNhom) VALUES (@Ten)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE NH_UPDATE
@ID INT,
@Ten NVARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM NHOMHANG WHERE ID  = @ID)
		BEGIN
			UPDATE NHOMHANG SET TenNhom = @Ten WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay Nhom Hang Nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE NH_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM NHOMHANG WHERE ID  = @ID)
		BEGIN
			DELETE FROM NHOMHANG
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay Nhom Hang nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO 

CREATE PROCEDURE HH_INSERT
@IDNhom int,
@Ten NVARCHAR(50),
@DVTinh NVARCHAR(20),
@GiaVon float,
@GiaBuon float,
@GiaLe float,
@ChietKhauXuat float,
@TonKho int
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO HANGHOA(IDNhom,Ten,DVTinh,GiaVon,GiaBuon,GiaLe,ChietKhauXuat,TonKho) VALUES (@IDNhom,@Ten,@DVTinh,@GiaVon,@GiaBuon,@GiaLe,@ChietKhauXuat,@TonKho)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE HH_UPDATE
@ID int,
@IDNhom int,
@Ten NVARCHAR(50),
@DVTinh NVARCHAR(20),
@GiaVon float,
@GiaBuon float,
@GiaLe float,
@ChietKhauXuat float,
@TonKho int
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM HANGHOA WHERE ID  = @ID)
		BEGIN
			UPDATE HANGHOA SET IDNhom = @IDNhom, Ten=@Ten,DVTinh=@DVTinh,GiaBuon=@GiaBuon,GiaVon=@GiaVon,GiaLe=@GiaLe,ChietKhauXuat=@ChietKhauXuat,TonKho=@TonKho WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay  Hang Hoa Nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE HH_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM HANGHOA WHERE ID  = @ID)
		BEGIN
			DELETE FROM HANGHOA
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay Hang Hoa nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE KH_INSERT
@Ten NVARCHAR(50),
@DiaChi NVARCHAR(50),
@SDT NVARCHAR(20),
@LoaiKH int,
@GiaBan	 NVARCHAR(20)
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO KHACHHANG(Ten,DiaChi,SDT,LoaiKH,GiaBan) VALUES (@Ten,@DiaChi,@SDT,@LoaiKH,@GiaBan)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE KH_UPDATE
@ID int,
@Ten NVARCHAR(50),
@DiaChi NVARCHAR(50),
@SDT NVARCHAR(20),
@LoaiKH int,
@GiaBan	 NVARCHAR(20)
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM KHACHHANG WHERE ID  = @ID)
		BEGIN
			UPDATE KHACHHANG  
			SET Ten=@Ten,DiaChi=@DiaChi,SDT=@SDT,LoaiKH=@LoaiKH,GiaBan=@GiaBan
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay  vi Khach Nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO

CREATE PROCEDURE KH_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM KHACHHANG WHERE ID  = @ID)
		BEGIN
			DELETE FROM KHACHHANG
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay vi Khach  nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO


CREATE PROCEDURE [dbo].[HD_INSERT]
@NguoiLap INT
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO HOADON VALUES (GETDATE(),@NguoiLap,null)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO
CREATE PROCEDURE HD_UPDATE
@ID INT,
@TongTien FLOAT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM HOADON WHERE ID  = @ID)
		BEGIN
			UPDATE HOADON  
			SET TongTien = @TongTien
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay  Hoa Don Nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO


CREATE PROCEDURE HD_DELETE
@ID INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM HOADON WHERE ID  = @ID)
		BEGIN
			DELETE FROM HOADON
			WHERE ID = @ID
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay HoaDon  nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO


CREATE PROCEDURE CTHD_INSERT
@ID INT,
@MaHang INT,
@SoLuong INT,
@DonGia FLOAT
AS
BEGIN TRAN
BEGIN TRY
	INSERT INTO CTHOADON VALUES (@ID,@MaHang,@SoLuong,@DonGia)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO


CREATE PROCEDURE CTHD_UPDATE
@ID INT,
@MaHang INT,
@SoLuong INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM CTHOADON WHERE ID  = @ID and MaHang=@MaHang)
		BEGIN
			UPDATE CTHOADON  
			SET SoLuong = @SoLuong
			WHERE ID = @ID and MaHang=@MaHang
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay  CT Hoa Don Nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH

GO


CREATE PROCEDURE CTHD_DELETE
@ID INT,
@MaHang INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS (SELECT * FROM CTHOADON WHERE ID  = @ID and MaHang=@MaHang)
		BEGIN
			DELETE FROM CTHOADON
			WHERE ID = @ID and MaHang=@MaHang
		END
	ELSE
		BEGIN 
			DECLARE @Message VARCHAR(200)
			SELECT @Message = 'Khong tim thay CT HoaDon  nay'
			RAISERROR (@Message,16,1)
		END
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
	DECLARE @ErrorMessage VARCHAR(200)
	SELECT @ErrorMessage = 'ERROR : ' + ERROR_MESSAGE()
	RAISERROR (@ErrorMessage,16,1)
END CATCH
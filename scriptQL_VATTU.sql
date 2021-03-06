USE [QL_VATTU]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 8/18/2018 9:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[ChiNhanh] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[ChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDDH]    Script Date: 8/18/2018 9:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDDH](
	[MasoDDH] [nchar](10) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTDDH] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 8/18/2018 9:20:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MAPN] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPX]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPX](
	[MAPX] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CTPX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MasoDDH] [nchar](10) NOT NULL,
	[NGAY] [date] NOT NULL,
	[MAKHO] [nchar](4) NULL,
	[NhaCC] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MAKHO] [nchar](4) NOT NULL,
	[TENKHO] [nvarchar](30) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENKHO] UNIQUE NONCLUSTERED 
(
	[TENKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [int] NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [datetime] NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiNV] [int] NULL,
	[LUONG] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MAPN] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[MasoDDH] [nchar](10) NOT NULL,
	[MAKHO] [nchar](4) NULL,
	[MANV] [int] NOT NULL,
	[TrangThaiPN] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_MaSoDDH] UNIQUE NONCLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MAPX] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL,
	[HOTENKH] [nvarchar](100) NOT NULL,
	[MAKHO] [nchar](4) NOT NULL,
	[MANV] [int] NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[DIACHI] [varchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_PX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vattu]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vattu](
	[MAVT] [nchar](4) NOT NULL,
	[TENVT] [nvarchar](30) NOT NULL,
	[DVT] [nvarchar](15) NOT NULL,
	[SOLUONGTON] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[TrangThaiVT] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENVT] UNIQUE NONCLUSTERED 
(
	[TENVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_9C4F2610893B48FC95D13CF0F121484F]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH] ADD  CONSTRAINT [MSmerge_df_rowguid_77E60BD865CD4EB7A47A4E7A83861E54]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPN] ADD  CONSTRAINT [MSmerge_df_rowguid_1EFD5EEEFB1144958A9F266596044146]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTPX] ADD  CONSTRAINT [MSmerge_df_rowguid_179A257806FA4AE49E34F4C0E9BEA1EA]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_MasoDDH]  DEFAULT (getdate()) FOR [MasoDDH]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [DF_DatHang_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DatHang] ADD  CONSTRAINT [MSmerge_df_rowguid_0FC7953EFE69401A89E80E1059A1476B]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Kho] ADD  CONSTRAINT [MSmerge_df_rowguid_E40E241A403B4315A99EF2C9595FC2A0]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_TrangThaiXoa]  DEFAULT ((0)) FOR [TrangThaiNV]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_LUONG]  DEFAULT ((4000000)) FOR [LUONG]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_C4741733F6E54CA3AD8EC3F20D813365]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_TrangThaiPN]  DEFAULT ((0)) FOR [TrangThaiPN]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [MSmerge_df_rowguid_AC49BAC2213E44EBA70BB5B13F06A90F]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [DF_PX_NGAY]  DEFAULT (getdate()) FOR [NGAY]
GO
ALTER TABLE [dbo].[PhieuXuat] ADD  CONSTRAINT [MSmerge_df_rowguid_FFCFB664751F4F09BB92E5FD2EE72C08]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [DF_Vattu_SOLUONGTON]  DEFAULT ((0)) FOR [SOLUONGTON]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [DF_Vattu_DONGIA]  DEFAULT ((0)) FOR [DONGIA]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [DF_Vattu_TrangThaiVT]  DEFAULT ((0)) FOR [TrangThaiVT]
GO
ALTER TABLE [dbo].[Vattu] ADD  CONSTRAINT [MSmerge_df_rowguid_D9A282E51A2246068C62C24867D3A3CE]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_DatHang]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_VatTu]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_PhieuNhap] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PhieuNhap] ([MAPN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_VatTu]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_PX] FOREIGN KEY([MAPX])
REFERENCES [dbo].[PhieuXuat] ([MAPX])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_PX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_VatTu]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_Kho]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH NOCHECK ADD  CONSTRAINT [FK_Kho_Kho] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Kho]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Kho]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_Kho] FOREIGN KEY([MAKHO])
REFERENCES [dbo].[Kho] ([MAKHO])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_Kho]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIA] CHECK NOT FOR REPLICATION (([DONGIA]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_DONGIA]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_SOLUONG]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPN] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_DONGIACTPN]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPN] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_SOLUONGCTPN]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPX] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_DONGIACTPX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPX] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_SOLUONGCTPX]
GO
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [CK_LUONG] CHECK NOT FOR REPLICATION (([LUONG]>=(4000000)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_LUONG]
GO
ALTER TABLE [dbo].[Vattu]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGTON] CHECK NOT FOR REPLICATION (([SOLUONGTON]>=(0)))
GO
ALTER TABLE [dbo].[Vattu] CHECK CONSTRAINT [CK_SOLUONGTON]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETHD]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHITIETHD]
	@MAPX nchar(10)
AS
BEGIN
	SELECT * FROM CHITIETHD
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUYEN_NV]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUYEN_NV] 
	@MANV NVARCHAR(20),
	@MACN NVARCHAR(20),
	@TENLOGIN NVARCHAR(20),
	@ROLE NVARCHAR(20)
AS
	DECLARE @RET INT
BEGIN

	BEGIN TRY
		EXEC SP_DROPLOGIN @TENLOGIN --XOA LOGIN NAME
		EXEC SP_DROPUSER @MANV -- XOA USERNAME TRONG ROLE
		UPDATE NhanVien SET TrangThaiNV = 2 WHERE MANV = @MANV -- update trang thai cho biet nhan vien đã chuyển

		--add login cho nhan vien sang chi nhanh kia
		EXEC @RET = LINK.QL_VATTU.dbo.SP_ADDLOGIN @TENLOGIN, '123', 'QL_VATTU' /* set cung password */
    
		declare @USERNAME varchar(50)  
		set @USERNAME = (SELECT Convert(INT,RAND() * 100000))

		IF (@RET = 1) RETURN 1  
			EXEC @RET = LINK.QL_VATTU.dbo.SP_GRANTDBACCESS @TENLOGIN, @USERNAME
		IF (@RET = 1) RETURN 1
		EXEC LINK.QL_VATTU.dbo.sp_addrolemember @ROLE, @USERNAME /* add login vao role*/
		BEGIN
			EXEC LINK.QL_VATTU.dbo.sp_addsrvrolemember @TENLOGIN, 'SecurityAdmin'
			EXEC LINK.QL_VATTU.dbo.sp_addsrvrolemember @TENLOGIN, 'sysadmin'
		
			 
				   Insert into LINK.QL_VATTU.dbo.NHANVIEN(MANV,
														HO,
														TEN,
														NGAYSINH,
														DIACHI,
														LUONG,
														MACN) 
														values(
														CONVERT(INT,@USERNAME),
														(select Ho from NhanVien a where a.MANV = @MANV),
														(select Ten from NhanVien a where a.MANV = @MANV),
														(select a.NGAYSINH from NhanVien a where a.MANV = @MANV),
														(select a.DIACHI from NhanVien a where a.MANV = @MANV),
														(select a.LUONG from NhanVien a where a.MANV = @MANV),
														@MACN )



		END	
	
		RETURN 0
	END TRY
	BEGIN CATCH
				DECLARE @ErrorMessage VARCHAR(2000)  
			   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()  
			   RAISERROR(@ErrorMessage, 16, 1)  
	END CATCH
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_CTPX]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CTPX]  
 @MAPHIEU NVARCHAR(20)  
AS  
BEGIN  
 SELECT CTPX.MAVT AS 'Mã Vật Tư', 
		VATTU.TENVT AS 'Tên Vật Tư', 
		CTPX.SOLUONG AS 'Số Lượng', 
		(CTPX.DONGIA * CTPX.SOLUONG) AS 'Tổng Đơn Giá'  
 FROM CTPX JOIN VATTU ON CTPX.MAVT = VATTU.MAVT   
 WHERE CTPX.MAPX = @MAPHIEU  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DANGNHAP]
	-- Add the parameters for the stored procedure here
	@LOGINNAME varchar(50)
AS
BEGIN
	SET NOCOUNT ON
	declare @role nvarchar(20)
	declare @username nvarchar(50)
	set @username = (SELECT NAME FROM sys.sysusers WHERE sid = SUSER_SID(@LOGINNAME))

	Begin try
		if @username IS NOT NULL
		begin
			SELECT @role = NAME FROM sys.sysusers 
			WHERE UID = (
						SELECT GROUPUID 
						FROM SYS.SYSMEMBERS 
						WHERE MEMBERUID = ( SELECT UID FROM sys.sysusers WHERE NAME=@username )
						)
					
			IF @role = 'CongTY'
			BEGIN
				SELECT MANV, CONCAT(HO + ' ',TEN) as HOTEN ,@role AS ROLE FROM NHANVIEN WHERE MANV = @username 
				UNION
				SELECT MANV, CONCAT(HO + ' ',TEN) as HOTEN ,@role AS ROLE FROM LINK.QL_VATTU.dbo.NHANVIEN WHERE MANV = @username 
			END
			ELSE
			BEGIN
				SELECT MANV, CONCAT(HO + ' ',TEN) as HOTEN ,@role AS ROLE FROM NHANVIEN WHERE MANV = @username 
			END
		

		end
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMessage VARCHAR(2000)  
		SELECT @ErrorMessage = 'Lỗi Đăng Nhập';  
		RAISERROR(@ErrorMessage, 16, 1)  
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DANHMUCVATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DANHMUCVATTU]

AS
BEGIN
	SELECT TENVT, TENLOAI, DONGIA, DONVI
	 FROM QL_VATTU.DBO.VATTU, QL_VATTU.DBO.LOAIVT 
	 WHERE VATTU.MALOAI = LOAIVT.MALOAI
END




GO
/****** Object:  StoredProcedure [dbo].[SP_DANHSACHPHIEUXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- ============================================   
CREATE PROCEDURE [dbo].[SP_DANHSACHPHIEUXUAT]  
 -- Add the parameters for the stored procedure here  
   
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SET NOCOUNT ON;  
 SELECT 
		a.MAPX AS 'Mã Phiếu Xuất', 
		a.HOTENKH AS 'Tên Khách Hàng', 
		a.NGAY AS 'Ngày Xuất', 
		b.TENKHO AS 'Tên Kho', 
		c.HO + ' ' + c.TEN  AS 'Tên Nhân Viên'  
 FROM PhieuXuat a inner join Kho b on a.MAKHO = b.MAKHO
					inner join NhanVien c on a.MANV = c.MANV
 
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DOIMATKHAU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DOIMATKHAU]
	-- Add the parameters for the stored procedure here
	@oldpassword varchar(20),
		@newpassword varchar(20),
			@login char(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @ret smallint
	execute @ret=sp_password @oldpassword,@newpassword,@login
	return @ret
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_CHITIET_DONDATHANG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DS_CHITIET_DONDATHANG]  
 -- Add the parameters for the stored procedure here  
    @MADDH VARCHAR(20)
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
  select a.MasoDDH as MADDH ,
		b.MANV ,
		b.NhaCC as TENNCC,
		b.NGAY,
		a.SOLUONG,
		c.TENVT,
		a.MAVT,
		'TRTHAI' = CASE  
		WHEN b.TrangThai = 0 THEN N'Đang xử lý'  
		WHEN b.TrangThai = 1 THEN N'Hàng đã về'  
		WHEN b.TrangThai = 2 THEN N'Đã nhập'  
		END  
		from CTDDH a inner join DatHang b on a.MasoDDH =b.MasoDDH
				     inner join Vattu c on c.MAVT = a.MAVT
		where a.MasoDDH = @MADDH
    -- Insert statements for procedure here  
 --SELECT CHITIETDDH.MADDH,MANV,TENNCC,NGAY,SOLUONG,VATTU.TENVT,VATTU.MAVT,   
 --'TRTHAI' = CASE  
 --   WHEN DONDH.TRTHAI = 0 THEN N'Đang xử lý'  
 --   WHEN DONDH.TRTHAI = 1 THEN N'Hàng đã về'  
 --   WHEN DONDH.TRTHAI = 2 THEN N'Đã nhập'  
 --   END  
 -- FROM DONDH   
 --INNER JOIN CHITIETDDH ON DONDH.MADDH = CHITIETDDH.MADDH  
 --INNER JOIN NHACUNGCAP ON NHACUNGCAP.MANCC = DONDH.MANCC  
 --INNER JOIN VATTU ON VATTU.MAVT = CHITIETDDH.MAVT  
 --ORDER BY MADDH DESC;  
   
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_CHITIET_DONDATHANG_THEOMA]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- =============================================  
	-- Author:  <Author,,Name>  
	-- Create date: <Create Date,,>  
	-- Description: <Description,,>  
	-- =============================================  
	CREATE PROCEDURE  [dbo].[SP_DS_CHITIET_DONDATHANG_THEOMA]  
	 @MADDH NVARCHAR(15)  
   
	AS  
	BEGIN  
	 -- SET NOCOUNT ON added to prevent extra result sets from  
	 -- interfering with SELECT statements.  
	 SET NOCOUNT ON;  
  
	   SELECT a.MasoDDH,
				a.SOLUONG,
				a.MAVT,
				TENVT, 
				c.MAKHO,
				b.DVT as DONVI,
				a.DONGIA    
	   FROM CTDDH a 
	   INNER JOIN VATTU b ON b.MAVT = a.MAVT  
	   INNER JOIN DatHang c ON c.MasoDDH = a.MasoDDH
	   WHERE c.MasoDDH = @MADDH  
     
	 --ORDER BY MADDH DESC;  
   
	END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_CHITIET_PHIEUNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[SP_DS_CHITIET_PHIEUNHAP]   
 -- Add the parameters for the stored procedure here  
 @MAPN NVARCHAR(15)  
AS  
BEGIN  
  
  SELECT a.MAPN,
			a.MAVT,
			a.DONGIA,
			a.SOLUONG,
			b.TENVT,
			c.NGAY as NGAYLAP
  FROM CTPN a inner join Vattu b on a.MAVT= b.MAVT
			inner join PhieuNhap c on c.MAPN = a.MAPN
   WHERE A.MAPN = @MAPN
   ORDER BY A.MAPN DESC
   
  
  
   
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_DONDATHANG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- ALTER date: <ALTER Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[SP_DS_DONDATHANG]  
 -- Add the parameters for the stored procedure here  
   
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SELECT a.MasoDDH,a.MANV,a.NhaCC,a.NGAY,  
 'TRTHAI' = CASE  
    WHEN a.TrangThai = 0 THEN N'Đang xử lý'  
    WHEN a.TrangThai = 1 THEN N'Nhập thiếu'  
    WHEN a.TrangThai = 2 THEN N'Đã nhập'  
    END  
  FROM DatHang a  
 ORDER BY a.MasoDDH DESC;  
   
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_DONDATHANG_CHUANHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DS_DONDATHANG_CHUANHAP]  
 -- Add the parameters for the stored procedure here  
   
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SELECT MasoDDH,NhaCC,NGAY,MAKHO,  
 'TRTHAI' = CASE  
    WHEN TrangThai = 0 THEN N'Đang xử lý'  
      
    END  
  FROM DatHang    
 WHERE TrangThai = 0  
 ORDER BY MasoDDH DESC;  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_KHACHHANG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DS_KHACHHANG]

AS
BEGIN
	SELECT MAKH AS 'Mã Khách Hàng', HOTEN AS 'Họ Tên', DIACHI AS 'Địa Chỉ', SDT AS 'Số Điện Thoại' FROM KHACHHANG
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DS_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_DS_KHO]

AS
BEGIN
	SELECT MAKHO, TENKHO FROM KHO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DS_PHIEUNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DS_PHIEUNHAP]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.MasoDDH AS MADDH,A.MANV,A.MAPN,A.NGAY
	FROM PHIEUNHAP a 
	ORDER BY a.MAPN DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_VATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DS_VATTU]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--CREATE NONCLUSTERED INDEX IX_Contact_MALOAI
	--ON VATTU.MALOAI(MALOAI)
	--INCLUDE (TENVT,TENLOAI)
	--WITH (DROP_EXISTING  = ON) -- xóa index nếu đã được tạo trước đó
	--select VATTU.MAVT,TENVT,VATTU.MALOAI,DONGIA,DONVI,TENLOAI,KHO.MAKHO,SOLUONGTON from VATTU 
	--		INNER JOIN LOAIVT ON VATTU.MALOAI = LOAIVT.MALOAI
	--		INNER JOIN CHITIETKHO ON CHITIETKHO.MAVT = VATTU.MAVT
	--		INNER JOIN KHO ON KHO.MAKHO = CHITIETKHO.MAKHO 

    -- Insert statements for procedure here
	select a.MAVT,a.TENVT,a.DVT as DONVI,a.SOLUONGTON from Vattu a 
	
			

	--select VATTU.MAVT,TENVT,VATTU.MALOAI,DONGIA,DONVI,TENLOAI from VATTU 
	--		INNER JOIN LOAIVT ON VATTU.MALOAI = LOAIVT.MALOAI			
			
			
			
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_VATTU_TRONGKHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DS_VATTU_TRONGKHO]  
 -- Add the parameters for the stored procedure here  
 @MAKHO NVARCHAR(10)  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 select a.MAVT,
		a.TENVT,
		--DONGIA,
		a.DVT,
		--TENLOAI,
		d.MAKHO,
		SOLUONGTON 
		from VATTU a  
		inner join CTPN b on a.MAVT = b.MAVT
	   inner join PhieuNhap c on c.MAPN = b.MAPN
	   inner join Kho d on d.MAKHO = c.MAKHO
	   WHERE d.MAKHO = @MAKHO  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_DSDON_DATHANG_CHUAPHIEUNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DSDON_DATHANG_CHUAPHIEUNHAP]
	@FromDay Datetime,
	@ToDay Datetime 
AS
BEGIN

	SET NOCOUNT ON;

	 SELECT a.MasoDDH,NhaCC,NGAY,MAKHO,(b.HO + ' ' + b.TEN) as 'HOTENNV', 
	 'TRTHAI' = CASE  
		WHEN TrangThai = 0 THEN N'Đang xử lý'  
      	END,
		d.TENVT,
		c.SOLUONG,
		 c.DONGIA as TONGDONGIA
	  FROM DatHang a INNER JOIN NhanVien b on a.MANV =b.MANV 
	  inner join CTDDH c on a.MasoDDH = c.MasoDDH 
	  inner join Vattu d on d.MAVT = c.MAVT  
	  WHERE TrangThai = 0  
	  ORDER BY a.MasoDDH DESC; 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DSVT_PHIEUXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_DSVT_PHIEUXUAT]
	@MAKHO nchar(10)
AS
BEGIN
	SELECT VATTU.MAVT AS 'Mã Vật Tư', VATTU.TENVT AS 'Tên Vật Tư', VATTU.MALOAI AS 'Mã Loại VT', VATTU.DONVI AS 'Đơn Vị', VATTU.DONGIA AS 'Giá VT', CHITIETKHO.SOLUONGTON AS 'Số Lượng Tồn'
	FROM VATTU JOIN CHITIETKHO ON VATTU.MAVT = CHITIETKHO.MAVT
	WHERE CHITIETKHO.MAKHO = @MAKHO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_HOATDONGNHANVIEN]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_HOATDONGNHANVIEN]  
 @MaNV nchar(10),  
 @DateFrom VARCHAR(50) ,   
    @DateTo VARCHAR(50),  
 @MACN NVARCHAR(11)  
AS  
BEGIN  
  
  
 SET NOCOUNT ON;  
	   declare @tblNhanVien table(MANV int,HOTEN NVARCHAR(50),NGAYSINH VARCHAR(40),DIACHI VARCHAR(40),LUONG DECIMAL)
	  IF(@MACN = (SELECT A.MACN FROM ChiNhanh A))
	  BEGIN

		  INSERT INTO @tblNhanVien
		  SELECT a.MANV,  
		  (a.HO+' '+a.TEN) as 'HOTEN',  
		  a.NGAYSINH,  
		  a.DIACHI,  
		  a.LUONG 
		  FROM  NHANVIEN  a   
		  where a.MANV = @MaNV  

		  IF NOT EXISTS (SELECT TOP 1 a.MANV from  @tblNhanVien a inner join PhieuNhap b on a.MANV = b.MANV)
		  BEGIN
				 select a.HOTEN,a.MANV,a.NGAYSINH,a.DIACHI,a.LUONG,'...' as 'NGAYLAP', '...' as 'SOPHIEU', '...' AS 'TENVT','...' AS 'MAKHO', 0 AS 'SOLUONG',0 AS 'DONGIA', 0 AS'TONGIGA'
				 FROM @tblNhanVien a
		  END
		  ELSE
		  BEGIN
				select a.HOTEN,a.MANV,a.NGAYSINH,a.LUONG,a.DIACHI,b.NGAY as 'NGAYLAP', b.MAPN as 'SOPHIEU',a.HOTEN, d.TENVT,e.MAKHO, c.SOLUONG,(c.DONGIA/c.SOLUONG) as 'DONGIA',c.DONGIA as 'TONGGIA'
				  from @tblNhanVien a   
				  full outer join PhieuNhap b on b.MANV = a.MANV  
				  inner join CTPN c on c.MAPN =b.MAPN  
				  inner join Vattu d on d.MAVT = c.MAVT  
				  inner join Kho e on e.MAKHO = b.MAKHO  
				  WHERE b.NGAY between @DateFrom and @DateTo 
				  UNION ALL
				  select a.HOTEN,a.MANV,a.NGAYSINH,a.LUONG,a.DIACHI,b.NGAY as 'NGAYLAP', b.MAPX as 'SOPHIEU',a.HOTEN, d.TENVT,e.MAKHO,C.SOLUONG,C.DONGIA AS 'DONGIA',(c.DONGIA*c.SOLUONG) as 'TONGGIA'
				  from @tblNhanVien a   
				  full outer join PhieuXuat b on b.MANV = a.MANV  
				  inner join CTPX c on c.MAPX =b.MAPX  
				  inner join Vattu d on d.MAVT = c.MAVT  
				  inner join Kho e on e.MAKHO = b.MAKHO  
				  WHERE b.NGAY between @DateFrom and @DateTo
		  END
		    


	  END
	  ELSE
	  BEGIN
		INSERT INTO @tblNhanVien
		  SELECT a.MANV,  
		  (a.HO+' '+a.TEN) as 'HOTEN',  
		  a.NGAYSINH,  
		  a.DIACHI,  
		  a.LUONG 
		  FROM  LINK.QL_VATTU.dbo.NHANVIEN  a   
		  where a.MANV = @MaNV  
  
		  IF NOT EXISTS (SELECT TOP 1 a.MANV from  @tblNhanVien a inner join PhieuNhap b on a.MANV = b.MANV)
		  BEGIN
				 select a.HOTEN,a.MANV,a.NGAYSINH,a.DIACHI,a.LUONG,'...' as 'NGAYLAP', '...' as 'SOPHIEU', '...' AS 'TENVT','...' AS 'MAKHO', 0 AS 'SOLUONG',0 AS 'DONGIA', 0 AS'TONGIGA'
				 FROM @tblNhanVien a
		  END
		  ELSE
		  BEGIN
				 select a.HOTEN,a.MANV,a.NGAYSINH,a.DIACHI,a.LUONG,b.NGAY as 'NGAYLAP', b.MAPN as 'SOPHIEU', d.TENVT,e.MAKHO, c.SOLUONG,(c.DONGIA/c.SOLUONG) as 'DONGIA',c.DONGIA as 'TONGGIA'
				  from @tblNhanVien a   
				  full outer join LINK.QL_VATTU.dbo.PhieuNhap b on b.MANV = a.MANV  
				  inner join LINK.QL_VATTU.dbo.CTPN c on c.MAPN =b.MAPN  
				  inner join LINK.QL_VATTU.dbo.Vattu d on d.MAVT = c.MAVT  
				  inner join LINK.QL_VATTU.dbo.Kho e on e.MAKHO = b.MAKHO  
				  WHERE b.NGAY between @DateFrom and @DateTo 
				  UNION ALL
				  select a.HOTEN,a.MANV,a.NGAYSINH,a.DIACHI,a.LUONG,b.NGAY as 'NGAYLAP', b.MAPX as 'SOPHIEU', d.TENVT,e.MAKHO,C.SOLUONG,C.DONGIA AS 'DONGIA',(c.DONGIA*c.SOLUONG) as 'TONGGIA'
				  from @tblNhanVien a   
				  full outer join LINK.QL_VATTU.dbo.PhieuXuat b on b.MANV = a.MANV  
				  inner join LINK.QL_VATTU.dbo.CTPX c on c.MAPX =b.MAPX  
				  inner join LINK.QL_VATTU.dbo.Vattu d on d.MAVT = c.MAVT  
				  inner join LINK.QL_VATTU.dbo.Kho e on e.MAKHO = b.MAKHO  
				  WHERE b.NGAY between @DateFrom and @DateTo  
		  END
		 
	  END
      
        
        
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRA_ROLE]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KIEMTRA_ROLE]
	@MANV NVARCHAR(20) --username
AS
BEGIN
	declare @role nvarchar(20), @username nvarchar(20), @loginname nvarchar(20)/* @password nvarchar(20)*/
	--set @role = (SELECT )
	set @username = (SELECT NAME FROM sys.sysusers WHERE NAME = @MANV)
	if @username IS NOT NULL
	begin
		SELECT @role = NAME FROM sys.sysusers 
		WHERE UID = (
					SELECT GROUPUID 
					FROM SYS.SYSMEMBERS 
					WHERE MEMBERUID = ( SELECT UID FROM sys.sysusers WHERE NAME=@username )
					)
		--lay ten login de tao login khi chuyen sang chi nhanh
		select @loginname = loginname from sys.syslogins  where sid = (select sid from sys.sysusers where name = @username)
		--select @password = password from sys.syslogins where loginname = @loginname
		SELECT @role AS ROLE, @loginname AS TENLOGIN
	end
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MA_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_MA_KHO]
	@TENKHO NVARCHAR(50)
AS
BEGIN
	SELECT MAKHO FROM KHO WHERE TENKHO = @TENKHO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MA_VATTU_TUDONG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAY_MA_VATTU_TUDONG]   
 
   
AS  
BEGIN  
  
  DECLARE @i varchar(50)
  declare @maVT varchar(50)
  if(not exists(select Vattu.MAVT from Vattu))
				BEGIN
					set @maVT ='VT01'
				END
			else
				BEGIN
					set @i = (select MAX(SUBSTRING(Vattu.MAVT,LEN('VT')+1,LEN('VT')+11)) FROM Vattu)
					set  @i = @i+ 1
					if(@i<10)
						begin
							set @maVT = 'VT0';
						end
					else
						begin
							set @maVT = 'VT';
						end
					set @maVT = @maVT + @i  -- LAY MA VAT TU TỰ ĐỘNG
				END
				select @maVT as MAVT

END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_NHANVIEN]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAY_NHANVIEN]    
 -- Add the parameters for the stored procedure here    
     
AS    
BEGIN    
 -- SET NOCOUNT ON added to prevent extra result sets from    
 -- interfering with SELECT statements.    
 SET NOCOUNT ON;    
    
    -- Insert statements for procedure here    
 SELECT MANV,    
   MACN,    
   (HO + ' ' +TEN) as HOTEN,    
   NGAYSINH,    
   DIACHI,    
   CASE WHEN a.TrangThaiNV = 0 THEN N'Đang Làm'    
            ELSE N'Đang Làm' END AS TRANGTHAI,  
 IIF(dp.Name = 'User',N'Nhân Viên','') as CHUCVU  
 FROM sys.sysusers us right   
 JOIN  sys.database_role_members rm ON us.uid = rm.member_principal_id  
 JOIN sys.database_principals dp ON rm.role_principal_id =  dp.principal_id  
 Inner join NHANVIEN a ON  us.name = Convert(varchar,a.MANV)  
 where dp.name = 'User'  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_NHANVIENTHEOCN]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_LAY_NHANVIENTHEOCN] 
	
	@MACN varchar(10)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    IF EXISTS (SELECT TOP 1 A.MACN from ChiNhanh a where a.MACN = @MACN )
	BEGIN
		select a.MANV, (a.HO + ' '+ A.TEN) AS HOTEN from NhanVien a
	END
	ELSE
	BEGIN
		select a.MANV, (a.HO + ' '+ A.TEN) AS HOTEN from LINK.QL_VATTU.dbo.NhanVien a
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_VATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
CREATE PROCEDURE [dbo].[SP_LAY_VATTU]  
   
   
AS  
BEGIN  
  
  
 SELECT MAVT,  
   TENVT,  
   DVT,  
   SOLUONGTON,
   Vattu.DONGIA,  
   TrangThaiVT as TrangThai from Vattu   
   --CASE TrangThaiVT  
   -- WHEN 0 THEN 'sản phẩm ngưng bán'   
   -- ELSE  'sản phẩm còn bán'   
   --END as TrangThai  FROM Vattu A   
  
   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYCHINHANH]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYCHINHANH]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	select SUBSTRING(publication,LEN('QL_VATTU')+2,LEN('QL_VATTU_CN')+2)as MACN,ChiNhanh,DIACHI,SoDT,subscriber as DATASOURCE
		from  distribution.dbo.MSpublications as Pub 
		join CHINHANH ON CHINHANH.MACN = SUBSTRING(publication,LEN('QL_VATTU')+2,LEN('QL_VATTU_CN')+2)
		join distribution.dbo.MSmerge_subscriptions as Sub on Pub.publication_id = Sub.publication_id ;

		--SELECT 'CN1' AS MACN,
		--		'TPHCM' AS ChiNhanh,
		--		'PTIT_HCM' AS DIACHI,
		--		'012345689' AS SoDT,
		--		'LAM-A75\SERVER2' as DATASOURCE
				
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYKHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_LAYKHO]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT* FROM KHO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMA_PHIEUXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[SP_LAYMA_PHIEUXUAT]   
 -- Add the parameters for the stored procedure here  
 AS  
BEGIN  
  DECLARE @i varchar(50),  
  @maHD varchar(10)  
    
  IF((SELECT MACN FROM CHINHANH) = 'CN1')  
   BEGIN  
     
   IF (not exists(select top 1 PhieuXuat.MAPX FROM PhieuXuat))  
    BEGIN  
     SET @maHD = 'PXCN1_01';   
    END  
   ELSE  
    BEGIN  
     --LAY MA TRONG TABLE CAT PHAN SO HOA DON, SAU DO +1  
     set @i = (select MAX(SUBSTRING(PhieuXuat.MAPX,LEN('PXCN1_')+1,LEN('PXCN1_')+11)) FROM PhieuXuat)  
     set  @i = @i+ 1  
     if(@i<10)  
      begin  
       set @maHD = 'PXCN1_0';  
      end  
     else  
      begin  
       set @maHD = 'PXCN1_';  
      end  
     set @maHD = @maHD + @i  -- LAY MA PHIEU TU DONG  
    END  
   END  
  ELSE  
   BEGIN    
    IF (not exists(select top 1 PhieuXuat.MAPX FROM PhieuXuat))  
     BEGIN  
      SET @maHD = 'PXCN2_01';  
     END  
    ELSE   
     BEGIN  
      set @i = (select MAX(SUBSTRING(PhieuXuat.MAPX,LEN('PXCN2_')+1,LEN('PXCN2_')+11)) FROM PhieuXuat)  
      set  @i = @i+ 1;  
      if(@i<10)  
       begin  
        set @maHD = 'PXCN2_0';  
       end  
      else  
       begin  
        set @maHD = 'PXCN2_';  
       end  
      set @maHD = @maHD + @i  -- LAY MA PHIEU TU DONG  
     END  
    END  
  select @maHD as MAHD  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMADONDATHANG_TUDONG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LAYMADONDATHANG_TUDONG]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

     DECLARE @i varchar(50),
		@maDDH varchar(50)
		IF((SELECT MACN FROM CHINHANH) = 'CN1')
			BEGIN
				if(not exists(SELECT top 1 DatHang.MasoDDH FROM DatHang))
					BEGIN
						set @maDDH ='DHCN1_01'
					END
				else
					begin
					set @i = (select MAX(SUBSTRING(MasoDDH,LEN('DHCN1_')+1,LEN('DHCN1_')+11)) FROM DatHang)
					set  @i = @i+ 1
					if(@i<10)
						begin
							set @maDDH = 'DHCN1_0';
						end
					else
						begin
							set @maDDH = 'DHCN1_';
						end
					set @maDDH = @maDDH + @i  -- LAY MA PHIEU TU DONG
				end
			END
		ELSE
			BEGIN
				if(not exists(SELECT top 1 DatHang.MasoDDH FROM DatHang))
					BEGIN
						set @maDDH ='DHCN2_0'
					END
				else
					begin
					set @i = (select MAX(SUBSTRING(MasoDDH,LEN('DHCN2_')+1,LEN('DHCN2_')+11)) FROM DatHang)
					set  @i = @i+ 1
					if(@i<10)
						begin
							set @maDDH = 'DHCN2_0';
						end
					else
						begin
							set @maDDH = 'DHCN2_';
						end
					set @maDDH = @maDDH + @i  -- LAY MA PHIEU TU DONG
				end
			END
		select @maDDH as MADDH
		
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYMAKHACHHANG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAYMAKHACHHANG]
AS
BEGIN
	DECLARE @i varchar(50),
		@maKH varchar(50)
		IF((SELECT MACN FROM CHINHANH) = 'CN01')
			BEGIN
				set @i = (select MAX(SUBSTRING(MAKH,LEN('KHCM')+1,LEN('KHCM')+11)) FROM KHACHHANG)
				set  @i = @i+ 1
				if(@i<10)
					begin
						set @maKH = 'KHCM0';
					end
				else
					begin
						set @maKH = 'KHCM';
					end
				set @maKH = @maKH + @i  -- LAY MA PHIEU TU DONG
				
			END
		ELSE
			BEGIN
				set @i = (select MAX(SUBSTRING(MAKH,LEN('KHN')+1,LEN('KHN')+11)) FROM KHACHHANG)
				set  @i = @i+ 1;
				if(@i<10)
					begin
						set @maKH = 'KHN0';
					end
				else
					begin
						set @maKH = 'KHN';
					end
				set @maKH = @maKH + @i  -- LAY MA PHIEU TU DONG
			END
		select @maKH as MAKH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYNHACUNGCAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LAYNHACUNGCAP] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- xóa index nếu đã được tạo trước đó
	CREATE NONCLUSTERED INDEX IX_TENNHACUNGCAP
	ON NHACUNGCAP(TENNCC)
	INCLUDE (DIACHI,SDT)
	WITH (DROP_EXISTING  = ON) -- xóa index nếu đã được tạo trước đó

	 -- xóa index nếu đã được tạo trước đó
    -- Insert statements for procedure here

	SELECT NHACUNGCAP.MANCC,TENNCC,DIACHI,SDT from NHACUNGCAP
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYNHANVIEN_USER_CHINHANH]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   
CREATE PROCEDURE [dbo].[SP_LAYNHANVIEN_USER_CHINHANH]    
 -- Add the parameters for the stored procedure here    
AS    
BEGIN    
 -- SET NOCOUNT ON added to prevent extra result sets from    
 -- interfering with SELECT statements.    
 SET NOCOUNT ON;    
    
    -- Insert statements for procedure here   
  
   SELECT MANV,    
   MACN,    
   (HO + '' +TEN) as HOTEN,    
   NGAYSINH,    
   DIACHI,    
  CASE WHEN a.TrangThaiNV = 0 THEN N'Đang Làm'  
		WHEN a.TrangThaiNV = 1 THEN N'Nghỉ Làm'  
         ELSE N'Đã Từng Chuyển' END AS TRANGTHAI,  
 Case WHEN dp.Name = 'User' Then N'Nhân Viên'  
   ELSE N'Trưởng Phòng' END AS CHUCVU  
 FROM sys.sysusers us right   
 JOIN  sys.database_role_members rm ON us.uid = rm.member_principal_id  
 JOIN sys.database_principals dp ON rm.role_principal_id =  dp.principal_id  
 Inner join NHANVIEN a ON  us.name = Convert(varchar,a.MANV)  
 where dp.name = 'User'  
 UNION ALL  
 SELECT MANV,    
   MACN,    
   (HO + '' +TEN) as HOTEN,    
   NGAYSINH,    
   DIACHI,    
   CASE WHEN a.TrangThaiNV = 0 THEN N'Đang Làm'  
		WHEN a.TrangThaiNV = 1 THEN N'Nghỉ Làm'  
         ELSE N'Đã Từng Chuyển' END AS TRANGTHAI,  
 Case WHEN dp.Name = 'User' Then N'Nhân Viên'  
   ELSE N'Trưởng Phòng' END AS CHUCVU  
 FROM sys.sysusers us right   
 JOIN  sys.database_role_members rm ON us.uid = rm.member_principal_id  
 JOIN sys.database_principals dp ON rm.role_principal_id =  dp.principal_id  
 Inner join NHANVIEN a ON  us.name = Convert(varchar,a.MANV)  
 where dp.name = 'ChiNhanh'  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYPHIEUNHAP_TUDONG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    
    
CREATE PROCEDURE [dbo].[SP_LAYPHIEUNHAP_TUDONG]    
     
     
AS    
BEGIN    
     
 SET NOCOUNT ON;    
    
 DECLARE @i varchar(50),    
  @maPN varchar(50)    
  IF((SELECT MACN FROM CHINHANH) = 'CN1')    
   BEGIN    
   if(not exists(select PHIEUNHAP.MAPN from PHIEUNHAP))    
    BEGIN    
     set @maPN ='PNCN1_01'    
    END    
   else    
    BEGIN    
     set @i = (select MAX(SUBSTRING(PHIEUNHAP.MAPN,LEN('PNCN1_')+1,LEN('PNCN1_')+11)) FROM PHIEUNHAP)    
     set  @i = @i+ 1    
     if(@i<10)    
      begin    
       set @maPN = 'PNCN1_0';    
      end    
     else    
      begin    
       set @maPN = 'PNCN1_';    
      end    
     set @maPN = @maPN + @i  -- LAY MA PHIEU TU DONG    
    END    
    
        
   END    
  ELSE    
   BEGIN    
    if(not exists(select PHIEUNHAP.MAPN from PHIEUNHAP))    
     BEGIN    
      set @maPN = 'PNCN2_01';    
     END    
    else    
     BEGIN    
      set @i = (select MAX(SUBSTRING(PHIEUNHAP.MAPN,LEN('PNCN2_')+1,LEN('PNCN2_')+11)) FROM PHIEUNHAP)    
      set  @i = @i+ 1;    
      if(@i<10)    
       begin    
        set @maPN = 'PNCN2_0';    
       end    
      else    
       begin    
        set @maPN = 'PNCN2_';    
       end    
      set @maPN = @maPN + @i  -- LAY MA PHIEU TU DONG    
     END    
   END    
  select @maPN as MAPN    
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_LOAD_CT_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_LOAD_CT_KHO]
	@TENKHO nvarchar(10)
AS
BEGIN
	DECLARE @MAKHO NCHAR(10)
	SET NOCOUNT ON;
	--LAY MA KHO THEO TEN KHO
	SET @MAKHO = (SELECT MAKHO FROM KHO WHERE TENKHO = @TENKHO)
	--TU MA KHO LAY CHI TIET SAM PHAM TRONG KHO
	SELECT VATTU.MAVT AS 'Mã Vật Tư', VATTU.TENVT AS 'Tên Vật Tư', VATTU.DONVI AS 'Đơn Vị Tính', VATTU.DONGIA AS 'Đơn Giá VT', CHITIETKHO.SOLUONGTON AS 'Số Lượng Tồn'
	FROM VATTU JOIN CHITIETKHO ON VATTU.MAVT = CHITIETKHO.MAVT
	WHERE CHITIETKHO.MAKHO = @MAKHO
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LOAD_USER]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
CREATE PROCEDURE [dbo].[SP_LOAD_USER]   
   
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SELECT NHANVIEN.MANV,  
  NHANVIEN.HO,NHANVIEN.TEN,  
  --IIF(NHANVIEN.PHAI = 'True',N'Nam',N'Nữ')AS PHAI,  
  NHANVIEN.NGAYSINH,  
  NHANVIEN.DIACHI,NHANVIEN.MACN  ,
  IIF(dp.name ='User',N'Nhân Viên','') as ChucVu
 FROM sys.sysusers us right   
 JOIN  sys.database_role_members rm ON us.uid = rm.member_principal_id  
 JOIN sys.database_principals dp ON rm.role_principal_id =  dp.principal_id  
 Inner join NHANVIEN ON  us.name = Convert(varchar,NHANVIEN.MANV)  
 where dp.name = 'User' 
 
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_DS_NHANVIEN_THEOMA]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_REPORT_DS_NHANVIEN_THEOMA]
	-- Add the parameters for the stored procedure here
	@MACN VARCHAR(10)
AS
BEGIN

	SET NOCOUNT ON;

	IF((SELECT MACN FROM CHINHANH) = @MACN)
	BEGIN
		SELECT  a.MANV,(a.HO + ' '+ a.TEN) as HOTEN,a.NGAYSINH,a.DIACHI, 
		CASE  
			 WHEN dp.name = 'User' THEN N'Nhân viên'
			 WHEN dp.name ='ChiNhanh' Then N'Quản Lý'
			 ELSE N'Giam đốc'  
		
		END  CHUCVU  from sys.sysusers us right   
		 JOIN sys.database_role_members rm ON us.uid = rm.member_principal_id  
		 JOIN sys.database_principals dp ON rm.role_principal_id =  dp.principal_id 
		 Inner join NHANVIEN a ON  us.name = Convert(varchar,a.MANV) 
		 ORDER BY A.HO,A.TEN 
	END
	
	ELSE
	BEGIN
		SELECT  a.MANV,(a.HO + ' '+ a.TEN) as HOTEN,a.NGAYSINH,a.DIACHI, 
		CASE  
			 WHEN dp.name = 'User' THEN N'Nhân viên'
			 WHEN dp.name ='ChiNhanh' Then N'Quản Lý'
			 ELSE N'Giam đốc'  
		
		END  CHUCVU  from LINK.QL_VATTU.sys.sysusers us right   
		 JOIN LINK.QL_VATTU.sys.database_role_members rm ON us.uid = rm.member_principal_id  
		 JOIN LINK.QL_VATTU.sys.database_principals dp ON rm.role_principal_id =  dp.principal_id 
		 Inner join LINK.QL_VATTU.dbo.NHANVIEN a ON  us.name = Convert(varchar,a.MANV)  
		 ORDER BY A.HO,A.TEN
	END


	 
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_SUA_KHO] 
	-- Add the parameters for the stored procedure here
	@MAKHO varchar(20),
	@TENKHO NVARCHAR(20),
	@DIACHI NVARCHAR(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Kho SET TENKHO = @TENKHO,DIACHI = @DIACHI where MAKHO = @MAKHO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SUA_VATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[SP_SUA_VATTU]  
 -- Add the parameters for the stored procedure here  
 @MAVT NVARCHAR(15),  
 @TENVT NVARCHAR(50),  
 @DONVI NVARCHAR(20),  
 @DONGIA FLOAT,
 @TRANGTHAI int  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 UPDATE VATTU  
 SET TENVT = @TENVT,DVT = @DONVI,TrangThaiVT = @TRANGTHAI ,DONGIA =@DONGIA
 WHERE MAVT = @MAVT  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_DONHANG]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_TAO_DONHANG]
	-- Add the parameters for the stored procedure here
	@XmlData ntext  -- truyen chuỗi XML

	
AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	declare @iDoc int
	exec sp_xml_preparedocument @iDoc output, @XmlData

	select MasoDDH,MAVT,SOLUONG,DONGIA,MANV,MAKHO,NHACC into #tmp from openxml(@iDoc, 'Root/DonDH') 
	with (MasoDDH varchar(20)
			,MAVT VARCHAR(20)
			,SOLUONG varchar(10)
			,DONGIA varchar(15)
			,MANV varchar(10)
			,MAKHO varchar(10)
			,NHACC varchar(10)) -- Đưa giá trị trong chuỗi xml vào table

	SET XACT_ABORT ON
	begin tran  --bat dau trasaction
	BEGIN TRY 
		INSERT INTO DatHang(MasoDDH,MAKHO,NGAY,NhaCC,MANV) 
		select top 1 MasoDDH ,MAKHO ,GETDATE(),NHACC,MANV from #tmp 

		Insert into CTDDH(MasoDDH,MAVT,SOLUONG,DONGIA) 
		SELECT MasoDDH,MAVT,Convert(INT,SOLUONG),Convert(float,DONGIA)DONGIA from #tmp 

		-- neu 1 trong 2 lenh insert loi nhảy xuống catch
	COMMIT 
	END TRY

	BEGIN CATCH
			ROLLBACK -- quay lui lại tất cả ,xem như chưa insert gì
			DECLARE @ErrorMessage VARCHAR(2000)
			SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
			RAISERROR(@ErrorMessage, 16, 1)
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[SP_TAO_KHO]  
 -- Add the parameters for the stored procedure here  
 @MAKHO VARCHAR(20),  
 @TENKHO VARCHAR(20),  
 @DIACHI VARCHAR(50)  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
  declare @ReVal int 
    begin tran  
  
  insert into Kho(MAKHO,TENKHO,DIACHI,MACN)  
  values(@MAKHO,@TENKHO,@DIACHI,(select MACN FROM ChiNhanh))  

  select @ReVal = @@error  
  if @ReVal <> 0  
  begin  
   rollback  
   return  
  end  
 commit tran  
 return  
  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_LOAIVT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_TAO_LOAIVT] 
	-- Add the parameters for the stored procedure here
	@MALOAI NVARCHAR(10),
	@TENLOAI NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO LOAIVT(MALOAI,TENLOAI)
	VALUES(@MALOAI,@TENLOAI)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_PHIEUNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TAO_PHIEUNHAP]   
 --@MAPN NVARCHAR(20),  
 --@MADDH NVARCHAR(20),  
 --@MAVT NVARCHAR(20),  
 --@MANV NVARCHAR(20),  
 --@SL_NHAP NCHAR(20),  
 --@DONGIA_NHAP NCHAR(20)  
 @XmlData ntext  -- truyen chuỗi XML  
  
  
AS  
BEGIN  
   
 SET NOCOUNT ON;  
 declare @iDoc int  
 exec sp_xml_preparedocument @iDoc output, @XmlData  
 select MAPN,MAKHO,MADDH,MAVT,MANV,SL_NHAP,DONGIA_NHAP into #tmp from openxml(@iDoc, 'Root/PhieuNhap')   
 with (MAPN varchar(20)  
   ,MAKHO varchar(8)  
   ,MADDH VARCHAR(20)  
   ,MAVT varchar(10)  
   ,MANV varchar(10)  
   ,SL_NHAP varchar(10)  
   ,DONGIA_NHAP varchar(10)) -- Đưa giá trị trong chuỗi xml vào table  
  

  
 SET XACT_ABORT ON  
 begin tran  --bat dau trasaction   
 BEGIN TRY   
   INSERT INTO PHIEUNHAP(MAPN,NGAY,MasoDDH,MAKHO,MANV)   
   SELECT TOP 1 MAPN,GETDATE(),MADDH,MAKHO,MANV from #tmp  -- Them Phieu nhap  
  
   Insert into CTPN(MAPN,MAVT,SOLUONG,DONGIA)   
   SELECT MAPN,MAVT,SL_NHAP,DONGIA_NHAP FROM #tmp-- them chi tiet phieu nhap  
     
   UPDATE DatHang  -- update trnag thai don hang len da nhap  
   SET TrangThai = 2  
   WHERE DatHang.MasoDDH = (SELECT TOP 1 MADDH from #tmp)     
  
   UPDATE Vattu  
   set SOLUONGTON = SOLUONGTON + b.SL_NHAP  
   FROM Vattu a INNER JOIN #tmp b on a.MAVT = b.MAVT  
  
     
  -- neu 1 trong 2 lenh insert loi nhảy xuống catch  
 COMMIT   
 END TRY  
  
 BEGIN CATCH  
   ROLLBACK -- quay lui lại tất cả ,xem như chưa insert gì  
   DECLARE @ErrorMessage VARCHAR(2000)  
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()  
   RAISERROR(@ErrorMessage, 16, 1)  
 END CATCH  
  
      
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_PHIEUXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAO_PHIEUXUAT]  
  @XmlData ntext  -- truyen chuỗi XML 
AS  
BEGIN  


 declare @iDoc int  
 exec sp_xml_preparedocument @iDoc output, @XmlData  
 select MAPX,HOTENKH,MAKHO,MANV,SDT,DIACHI,MAVT,SL_XUAT,DONGIA into #tmp from openxml(@iDoc, 'Root/PhieuXuat')   
 with (MAPX varchar(20)  
   ,HOTENKH varchar(50)  
   ,MAKHO VARCHAR(10)  
   ,MANV varchar(10)  
   ,SDT varchar(10)  
   ,DIACHI varchar(50) 
   ,MAVT varchar(10) 
   ,SL_XUAT varchar(10)
   ,DONGIA varchar(10)) -- Đưa giá trị trong chuỗi xml vào table  


 SELECT * FROM #TMP
 SET XACT_ABORT ON  
 begin tran  --bat dau trasaction   
 BEGIN TRY   

	INSERT INTO PhieuXuat(MAPX,NGAY,HOTENKH,MAKHO,MANV,SDT,DIACHI)   
	SELECT TOP 1 MAPX,GETDATE(),HOTENKH,MAKHO,MANV,SDT,DIACHI from #tmp  -- Them Phieu xuat 

	Insert into CTPX(MAPX,MAVT,SOLUONG,DONGIA)   
	SELECT MAPX,MAVT,SL_XUAT,DONGIA FROM #tmp-- them chi tiet phieu xuat

	UPDATE Vattu  
	set SOLUONGTON = a.SOLUONGTON - b.SL_XUAT
	FROM Vattu a INNER JOIN #tmp b on a.MAVT = b.MAVT 

 COMMIT   


 END TRY  
  
 BEGIN CATCH  
   ROLLBACK -- quay lui lại tất cả ,xem như chưa insert gì  
   DECLARE @ErrorMessage VARCHAR(2000)  
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()  
   RAISERROR(@ErrorMessage, 16, 1)  
 END CATCH  
  
END  
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_VATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TAO_VATTU]  
 @MAVT NVARCHAR(15),  
 @TENVT NVARCHAR(50),  
 @DONVI NVARCHAR(20),
 @DONGIA FLOAT  
   
AS  
BEGIN  
  
  
 INSERT INTO VATTU(MAVT,TENVT,DVT,DONGIA)  
 VALUES(@MAVT,@TENVT,@DONVI,@DONGIA)  
   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN_NHANVIEN]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--EXEC SP_TAOTAIKHOAN_NHANVIEN
--@LGNAME ='test',
--  @PASS ='123',
--  @HO ='Nguyen Ngoc',
--  @TEN = 'Ngan',
--  @NGAYSINH = '05-05-1995',
--  @DIACHI = 'TPHCM',
--  @LUONG =5000000,
--  @ROLE ='ChiNhanh'

CREATE PROCEDURE [dbo].[SP_TAOTAIKHOAN_NHANVIEN] 
  @LGNAME VARCHAR(50),
  @PASS NVARCHAR(50),
  @HO NVARCHAR(50),
  @TEN NVARCHAR(50),
  @NGAYSINH varchar(50),
  @DIACHI NVARCHAR(80),
  @LUONG varchar(50),
  @ROLE VARCHAR(50)

AS

  declare @USERNAME varchar(50)  
   DECLARE @RET INT
  set @USERNAME = (SELECT Convert(INT,RAND() * 100000))
  IF EXISTS (SELECT TOP 1 A.MANV FROM NhanVien a where a.MANV = @USERNAME) 
  OR EXISTS(SELECT TOP 1 A.MANV FROM LINK.QL_VATTU.dbo.NhanVien a where a.MANV = @USERNAME)
  BEGIN
		RETURN -1;
  END

  ELSE
  BEGIN
		  BEGIN TRY
		  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QL_VATTU'
		  IF (@RET =1)  -- LOGIN NAME BI TRUNG
			 RETURN 1
 
		  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
		  IF (@RET =1)  -- USER  NAME BI TRUNG
		  BEGIN
			   EXEC SP_DROPLOGIN @LGNAME
			   RETURN 2
		  END

		  EXEC sp_addrolemember @ROLE, @USERNAME -- Đưa username là manv vào ROLE 
		  Insert into NHANVIEN(MANV,HO,TEN,NGAYSINH,DIACHI,LUONG,MACN) values(CONVERT(INT,@USERNAME),@HO,@TEN,Convert(Datetime,@NGAYSINH),@DIACHI,Convert(float,@LUONG),(select a.MACN from ChiNhanh a) )

  
		  IF (@ROLE = 'CHINHANH'  )
			BEGIN
			   EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
			   EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
			END	
		  IF (@ROLE = 'USER'  )
			BEGIN
			   EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
			   EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
	   
			END	

		  IF (@ROLE = 'CONGTY'  )
			BEGIN
				begin try
					EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
					EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
					--thuc hien day login sang chi nhanh khac
					EXEC @RET = LINK.QL_VATTU.dbo.SP_ADDLOGIN @LGNAME, @PASS, 'QL_VATTU'
					IF (@RET = 1) RETURN 1
					EXEC @RET = LINK.QL_VATTU.dbo.SP_GRANTDBACCESS @LGNAME, @USERNAME
					IF (@RET = 1) RETURN 1
					EXEC LINK.QL_VATTU.dbo.sp_addrolemember @ROLE, @USERNAME
					BEGIN
					   EXEC LINK.QL_VATTU.dbo.sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
					   EXEC LINK.QL_VATTU.dbo.sp_addsrvrolemember @LGNAME, 'sysadmin'
					END	
				end try
				begin catch
					PRINT 'LOI TAO LOGIN'
				end catch
			END	
			RETURN 0  -- THANH CONG
			END TRY
			BEGIN CATCH
		
			   DECLARE @ErrorMessage VARCHAR(2000)  
			   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()  
			   RAISERROR(@ErrorMessage, 16, 1)  
			END CATCH
  END

  


GO
/****** Object:  StoredProcedure [dbo].[SP_THONGKESOHANGNHAP]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC [SP_THONGKESOHANGNHAP]
--@FromDay ='5-5-2015',
--	@ToDay ='5-5-2019',
--	@Role ='CongTy'
CREATE PROCEDURE [dbo].[SP_THONGKESOHANGNHAP]
	@FromDay varchar(50),
	@ToDay varchar(50),
	@Role varchar(10)
	
AS
BEGIN

	SET NOCOUNT ON;
	
	DECLARE @tmp table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongNhap int ,TongDonGia decimal(20) )
	DECLARE @tmp1 table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongNhap int ,TongDonGia decimal(20) )
	DECLARE @tmpEnd table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongNhap int ,TongDonGia decimal(20) )


	insert into @tmp
	SELECT (  Convert(varchar,Month(a.NGAY)) + '/' + Convert(varchar,year(a.NGAY))) as 'Month/Year',
				c.TENVT,
				sum (b.SOLUONG) as TongSoLuongNhap, -- TongSoLuongNhap theo thang va theo ten vat tu
				sum(b.DONGIA) as TongDonGia   -- TongDonGia theo thang va theo ten vat tu 
				FROM PhieuNhap a inner join CTPN b on a.MAPN = b.MAPN
				inner join Vattu c on c.MAVT=b.MAVT
				WHERE a.NGAY BETWEEN @FromDay and @ToDay -- trong khoảng thời gian
				GROUP BY Month(a.NGAY),year(a.NGAY),c.TENVT -- gom cụm theo thang, năm,tên vật tư
				order by year(a.NGAY) desc, MONTH(a.NGAY) desc -- xep theo thứ tự giảm dần theo năm và tháng

	
		IF(@Role = 'CongTy') -- nếu role bằng công ty  => tổng hợp hàng nhập trên cả 2 server phân mảnh
		BEGIN
				insert into @tmp1
				SELECT (  Convert(varchar,Month(a.NGAY)) + '/' + Convert(varchar,year(a.NGAY))) as 'Month/Year',
				c.TENVT,
				sum (b.SOLUONG) as TongSoLuongNhap, --TongSoLuongNhap theo thang va theo ten vat tu ben LINK SERVER
				sum(b.DONGIA) as TongDonGia  -- TongDonGia theo thang va theo ten vat tu ben LINK SERVER
				FROM LINK.QL_VATTU.dbo.PhieuNhap a inner join LINK.QL_VATTU.dbo.CTPN b on a.MAPN = b.MAPN
				inner join LINK.QL_VATTU.dbo.Vattu c on c.MAVT=b.MAVT
				WHERE a.NGAY BETWEEN @FromDay and @ToDay -- trong khoảng thời gian
				GROUP BY Month(a.NGAY),year(a.NGAY),c.TENVT -- gom cụm theo thang, năm , tên vật tư
				order by year(a.NGAY) desc, MONTH(a.NGAY) desc -- xep theo thứ tự giảm dần theo năm và tháng

					insert into @tmpEnd
					select a.[Month/Year],
					a.TENVT,
					(ISNULL(a.TongSoLuongNhap,0) + ISNULL(b.TongSoLuongNhap,0)) as TongSoLuongNhap,
					(ISNULL(a.TongDonGia,0) +ISNULL(B.TongDonGia,0)) AS TongDonGia
					from @tmp1 a left join @tmp b 
					on a.TENVT = b.TENVT and a.[Month/Year] =b.[Month/Year]
					UNION 
					select C.[Month/Year],
					C.TENVT,
					(ISNULL(C.TongSoLuongNhap,0) + ISNULL(d.TongSoLuongNhap,0)) as TongSoLuongNhap,
					(ISNULL(c.TongDonGia,0) +ISNULL(d.TongDonGia,0)) AS TongDonGia
					from @tmp c left join @tmp1 d 
					on c.TENVT = d.TENVT and c.[Month/Year] =d.[Month/Year]

					select * from @tmpEnd a
					order by SUBSTRING(a.[Month/Year],(CHARINDEX ('/',a.[Month/Year],0)+1),len(a.[Month/Year])) desc -- sắp xếp theo năm từ cao xuống thấp
						,SUBSTRING(a.[Month/Year],0,CHARINDEX ( a.[Month/Year] , '/' ,0 )) desc -- sắp xếp theo tháng
		END
		ELSE
		BEGIN
				SELECT * FROM @tmp a
				order by SUBSTRING(a.[Month/Year],(CHARINDEX ('/',a.[Month/Year],0)+1),len(a.[Month/Year])) desc -- sắp xếp theo năm từ cao xuống thấp
						,SUBSTRING(a.[Month/Year],0,CHARINDEX ( a.[Month/Year] , '/' ,0 )) desc -- sắp xếp theo tháng

		END
		

		--drop table #tmp
		--drop table #tmpEnd
		--drop table #tmp1

					--select * from #tmp a where a.[Month/Year] ='8-2018'
					--select  a.[Month/Year] as result
					--from #tmp a where a.[Month/Year] ='8-2018'

					--SELECT CHARINDEX ('-',a.[Month/Year],0)
					--from #tmp a where a.[Month/Year] ='8-2018'

					--select  SUBSTRING(a.[Month/Year],0,CHARINDEX ('-',a.[Month/Year],0)) as result
					--from #tmp a where a.[Month/Year] ='8-2018'

					--SELECT SUBSTRING(a.[Month/Year],(CHARINDEX ('-',a.[Month/Year],0)+1),len(a.[Month/Year])) as result
					--from #tmp a where a.[Month/Year] ='8-2018'
END


GO
/****** Object:  StoredProcedure [dbo].[SP_THONGKESOHANGXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC [SP_THONGKESOHANGXUAT]
--@FromDay ='5-5-2015',
--	@ToDay ='5-5-2019',
--	@Role ='CongTy'
CREATE PROCEDURE [dbo].[SP_THONGKESOHANGXUAT]
	@FromDay varchar(50),
	@ToDay varchar(50),
	@Role varchar(10)
AS
BEGIN

	SET NOCOUNT ON;

		DECLARE @tmp table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongXuat int ,TongDonGia decimal(20) )
		DECLARE @tmp1 table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongXuat int ,TongDonGia decimal(20) )
		DECLARE @tmpEnd table([Month/Year] Nvarchar(50),TENVT nvarchar(30),TongSoLuongXuat int ,TongDonGia decimal(20) )

		insert into @tmp
		SELECT (  Convert(varchar,Month(a.NGAY)) + '-' + Convert(varchar,year(a.NGAY))) as 'Month/Year',
				c.TENVT,
				sum (b.SOLUONG) as TongSoLuongXuat,
				sum(b.DONGIA) as TongDonGia  
				FROM PhieuXuat a inner join CTPX b on a.MAPX = b.MAPX
				inner join Vattu c on c.MAVT=b.MAVT
				WHERE a.NGAY BETWEEN @FromDay and @ToDay -- trong khoảng thời gian
				GROUP BY Month(a.NGAY),year(a.NGAY),c.TENVT -- gom cụm theo thang, nam,mã vt, mã pn
				order by year(a.NGAY) desc, MONTH(a.NGAY) desc -- xep theo thứ tự giảm dần theo năm và tháng
	
		IF(@Role = 'CongTy')
		BEGIN
			insert into @tmp1
			SELECT (  Convert(varchar,Month(a.NGAY)) + '-' + Convert(varchar,year(a.NGAY))) as 'Month/Year',
				c.TENVT,
				sum (b.SOLUONG) as TongSoLuongXuat,
				sum(b.DONGIA*b.SOLUONG) as TongDonGia 
				FROM LINK.QL_VATTU.dbo.PhieuXuat a inner join LINK.QL_VATTU.dbo.CTPX b on a.MAPX = b.MAPX
				inner join LINK.QL_VATTU.dbo.Vattu c on c.MAVT=b.MAVT
				WHERE a.NGAY BETWEEN @FromDay and @ToDay -- trong khoảng thời gian
				GROUP BY Month(a.NGAY),year(a.NGAY),c.TENVT -- gom cụm theo thang, nam,mã vt, mã pn
				order by year(a.NGAY) desc, MONTH(a.NGAY) desc -- xep theo thứ tự giảm dần theo năm và tháng


				insert into @tmpEnd
				select a.[Month/Year],
							a.TENVT ,
					(ISNULL(a.TongSoLuongXuat,0) + ISNULL(b.TongSoLuongXuat,0)) as TongSoLuongXuat,
					(ISNULL(a.TongDonGia,0) +ISNULL(B.TongDonGia,0)) AS TongDonGia
			 
					from @tmp1 a left join @tmp b 
					on a.TENVT = b.TENVT and a.[Month/Year] =b.[Month/Year]
					UNION 
					select C.[Month/Year],
					C.TENVT,
					(ISNULL(C.TongSoLuongXuat,0) + ISNULL(d.TongSoLuongXuat,0)) as TongSoLuongXuat,
					(ISNULL(c.TongDonGia,0) +ISNULL(d.TongDonGia,0)) AS TongDonGia
					
					from @tmp c left join @tmp1 d 
					on c.TENVT = d.TENVT and c.[Month/Year] =d.[Month/Year]

					select * from @tmpEnd a
					order by SUBSTRING(a.[Month/Year],(CHARINDEX ('/',a.[Month/Year],0)+1),len(a.[Month/Year])) desc -- sắp xếp theo năm từ cao xuống thấp
						,SUBSTRING(a.[Month/Year],0,CHARINDEX ( a.[Month/Year] , '/' ,0 )) desc -- sắp xếp theo tháng
		END
		ELSE
		BEGIN
				SELECT * FROM @tmp a
				order by SUBSTRING(a.[Month/Year],(CHARINDEX ('-',a.[Month/Year],0)+1),len(a.[Month/Year])) desc -- sắp xếp theo năm từ cao xuống thấp
						,SUBSTRING(a.[Month/Year],0,CHARINDEX ( a.[Month/Year] , '-' ,0 )) desc -- sắp xếp theo tháng

		END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TONGHOPNHAPXUAT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    
CREATE PROCEDURE [dbo].[SP_TONGHOPNHAPXUAT]       
 @DateFrom VARCHAR(50) ,       
 @DateTo VARCHAR(50),      
 @MACN NVARCHAR(11)      
AS      
BEGIN      
      
      
 SET NOCOUNT ON;      
  declare @totalPN float     
  declare @totalPX float    
    
  declare @tmpPN_CN1 table(Ngay datetime,TongGiaNhap decimal)    
  declare @tmpPX_CN1 table(Ngay datetime,TongGiaXuat decimal)    
  declare @tmpTongHopNhapCN1 table(Ngay datetime,TongGiaNhap decimal,[Ti le Nhap] varchar(30))    
  declare @tmpTongHopXuatCN1 table(Ngay datetime,TongGiaXuat decimal,[Ti le Xuat] varchar(30))    
    
    
  declare @tmpPN_CN2 table(Ngay datetime,TongGiaNhap decimal)    
  declare @tmpPX_CN2 table(Ngay datetime,TongGiaXuat decimal)    
  declare @tmpTongHopNhapCN2 table(Ngay datetime,TongGiaNhap decimal,[Ti le Nhap] varchar(30))    
  declare @tmpTongHopXuatCN2 table(Ngay datetime,TongGiaXuat decimal,[Ti le Xuat] varchar(30))    
    
    
  IF((SELECT MACN FROM ChiNhanh) = @MACN) -- Kiem tra xem đang ở chi nhánh nào . nếu đang đứng đúng chi nhanh đang đăng nhập    
  BEGIN        
       insert into @tmpPN_CN1    
       select    
       A.NGAY,     
       sum(B.DONGIA) as 'TongGiaNhap'     
       from PhieuNhap a inner join CTPN b on a.MAPN = b.MAPN    
       where a.NGAY between @DateFrom and  @DateTo    
       group by DAY(A.NGAY),a.NGAY    
    
       insert into @tmpPX_CN1    
       select     
       A.NGAY,    
       sum(B.DONGIA*b.SOLUONG) as 'TongGiaXuat'     
       from  PhieuXuat a inner join CTPX b on a.MAPX = b.MAPX    
       where a.NGAY between  @DateFrom and  @DateTo    
       group by DAY(A.NGAY),a.NGAY    
    
       set @totalPN = (select sum(a.TongGiaNhap) as 'TONGCONGPN'    
       from @tmpPN_CN1 a)    
    
       insert into @tmpTongHopNhapCN1    
       select *, (Convert(varchar,((a.TongGiaNhap/@totalPN)*100))) as 'Ti le Nhap'      
       from @tmpPN_CN1 a    
    
       set @totalPX = (select sum(a.TongGiaXuat) as 'TONGCONGPX'    
       from @tmpPX_CN1 a)    
    
       insert into @tmpTongHopXuatCN1    
       select *, (Convert(varchar,((a.TongGiaXuat/@totalPX)*100))) as 'Ti le Xuat'      
       from @tmpPX_CN1 a    
    
    
       select a.NGAY,ISNULL(a.TongGiaNhap,0) as TongGiaNhap,ISNULL(a.[Ti le Nhap],0) as 'Ti le Nhap',ISNULL(b.TongGiaXuat,0)as TongGiaXuat,ISNULL(b.[Ti le Xuat],0) as 'Ti le Xuat',@DateFrom as 'TuNgay', @DateTo as 'DenNgay' from  @tmpTongHopNhapCN1 a     
       left join  @tmpTongHopXuatCN1 b on a.NGAY =b.NGAY    
       union all     
       select b.NGAY,ISNULL(a.TongGiaNhap,0) as TongGiaNhap ,ISNULL(a.[Ti le Nhap],0) as 'Ti le Nhap',ISNULL(b.TongGiaXuat,0) as TongGiaXuat,ISNULL(b.[Ti le Xuat],0) as 'Ti le Xuat',@DateFrom as 'TuNgay', @DateTo as 'DenNgay' from  @tmpTongHopXuatCN1 b     
       left join  @tmpTongHopNhapCN1 a on a.NGAY =b.NGAY    
    
  end    
  ELSE    
  BEGIN    
       insert into @tmpPN_CN2    
       select    
       A.NGAY,    
       sum(B.DONGIA) as 'TongGiaNhap'     
       from LINK.QL_VATTU.dbo.PhieuNhap a inner join LINK.QL_VATTU.dbo.CTPN b on a.MAPN = b.MAPN    
       where a.NGAY between @DateFrom and  @DateTo    
       group by DAY(A.NGAY),a.NGAY    
    
    
       insert into @tmpPX_CN2    
       select     
       A.NGAY,    
       sum(B.DONGIA*b.SOLUONG) as 'TongGiaXuat'     
       from  LINK.QL_VATTU.dbo.PhieuXuat a inner join LINK.QL_VATTU.dbo.CTPX b on a.MAPX = b.MAPX    
       where a.NGAY between @DateFrom and  @DateTo    
       group by DAY(A.NGAY),a.NGAY    
    
       set @totalPN = (select sum(a.TongGiaNhap) as 'TONGCONGPN'    
       from @tmpPN_CN2 a)    
    
       insert into  @tmpTongHopNhapCN2     
       select *, (Convert(varchar,((a.TongGiaNhap/@totalPN)*100))) as 'Ti le Nhap'      
       from @tmpPN_CN2 a    
    
       set @totalPX = (select sum(a.TongGiaXuat) as 'TONGCONGPX'    
       from @tmpPX_CN2 a)    
       insert into @tmpTongHopXuatCN2     
       select *, (Convert(varchar,((a.TongGiaXuat/@totalPX)*100))) as 'Ti le Xuat'      
       from @tmpPX_CN2 a    
    
    
       select a.NGAY,ISNULL(a.TongGiaNhap,0) as TongGiaNhap,ISNULL(a.[Ti le Nhap],0) as 'Ti le Nhap',ISNULL(b.TongGiaXuat,0)as TongGiaXuat,ISNULL(b.[Ti le Xuat],0) as 'Ti le Xuat',@DateFrom as 'TuNgay', @DateTo as 'DenNgay' from  @tmpTongHopNhapCN2 a     
       left join  @tmpTongHopXuatCN2 b on a.NGAY =b.NGAY    
       union all     
       select b.NGAY,ISNULL(a.TongGiaNhap,0) as TongGiaNhap ,ISNULL(a.[Ti le Nhap],0) as 'Ti le Nhap',ISNULL(b.TongGiaXuat,0) as TongGiaXuat,ISNULL(b.[Ti le Xuat],0) as 'Ti le Xuat',@DateFrom as 'TuNgay', @DateTo as 'DenNgay' from  @tmpTongHopXuatCN2 b     
       left join  @tmpTongHopNhapCN2 a on a.NGAY =b.NGAY    
           
           
    
  END     
      
           
    
        
            
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_KHO]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_KHO]
	-- Add the parameters for the stored procedure here
	@MAKHO VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    IF EXISTs(select top 1 makho from PhieuNhap where MAKHO = @MAKHO) 
	begin
		return 1
	end

	ELSE
	BEGIN
		IF EXISTs(select top 1 makho from PhieuXuat WHERE MAKHO= @MAKHO)
		BEGIN
			RETURN 1
		END

		ELSE
		BEGIN
			IF EXISTS (SELECT TOP 1 MAKHO FROM DatHang WHERE MAKHO = @MAKHO)
			BEGIN
				RETURN 1
			END
			ELSE
			BEGIN
				DELETE FROM Kho
				WHERE MAKHO = @MAKHO
			END
		END
	END 
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_LOAIVT]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_XOA_LOAIVT]
	-- Add the parameters for the stored procedure here
	@MALOAI NVARCHAR(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	BEGIN TRY	 
		DELETE LOAIVT WHERE MALOAI = @MALOAI
	END TRY
	BEGIN CATCH
		--print N'LOẠI VẬT TƯ NÀY ĐANG SỬ DỤNG .BẠN KHÔNG ĐƯỢC XÓA'
		SELECT N'LOẠI VẬT TƯ NÀY ĐANG SỬ DỤNG .BẠN KHÔNG ĐƯỢC XÓA'
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_VATTU]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_XOA_VATTU]   
 -- Add the parameters for the stored procedure here  
 @MAVT NVARCHAR(15)  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 BEGIN TRY 
 SET XACT_ABORT ON  
 begin tran  --bat dau trasaction 
	  IF not exists   (select top 1 A.MAVT from CTPN a where a.MAVT = @MAVT)  
			and	not exists(select top 1 b.MAVT from  CTPX b where b.MAVT = @MAVT) 
			and exists (select c.TrangThaiVT  from Vattu c where c.MAVT = @MAVT and c.TrangThaiVT = 0) 
			BEGIN
				  DELETE FROM VATTU  
				  WHERE MAVT = @MAVT;  
				  COMMIT   
			END
	 ELSE
			BEGIN
				RETURN 1;
			END
  COMMIT	  
 END TRY  

  
 BEGIN CATCH  
   ROLLBACK -- quay lui lại tất cả ,xem như chưa insert gì  
   DECLARE @ErrorMessage VARCHAR(2000)  
   SELECT @ErrorMessage = N'Vật tư này đang bán không được xóa'
   RAISERROR(@ErrorMessage, 16, 1)  
 END CATCH  
 END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 8/18/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
  
AS
BEGIN
EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
END
GO

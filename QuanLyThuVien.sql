CREATE DATABASE QuanLyThuVien;
GO
USE QuanLyThuVien;
GO

-- 1. Tác giả
CREATE TABLE TacGia (
    MaTacGia  CHAR(10)      PRIMARY KEY,
    HoTen     NVARCHAR(255) NOT NULL,
    NamSinh   INT,
    NamMat    INT,
    QuocTich  NVARCHAR(100),
    TieuSu    NVARCHAR(MAX)
);

INSERT INTO TacGia VALUES
('TG001', N'Nguyễn Nhật Ánh', 1955, NULL, N'Việt Nam', N'Tác giả thiếu nhi'),
('TG002', N'J.K. Rowling', 1965, NULL, N'Anh', N'Harry Potter'),
('TG003', N'George Orwell', 1903, 1950, N'Anh', N'1984, Animal Farm'),
('TG004', N'Haruki Murakami', 1949, NULL, N'Nhật Bản', N'Kafka bên bờ biển'),
('TG005', N'Victor Hugo', 1802, 1885, N'Pháp', N'Les Misérables'),
('TG006', N'Ernest Hemingway', 1899, 1961, N'Mỹ', N'The Old Man and the Sea'),
('TG007', N'Ngô Tất Tố', 1893, 1954, N'Việt Nam', N'Tắt đèn');

-- 2. Thể loại
CREATE TABLE TheLoai (
    MaTheLoai  CHAR(10) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL,
    MoTa       NVARCHAR(MAX)
);

INSERT INTO TheLoai VALUES
('TL001', N'Thiếu nhi', N'Sách cho trẻ em'),
('TL002', N'Fantasy', N'Truyện giả tưởng'),
('TL003', N'Kinh điển', N'Tác phẩm văn học kinh điển'),
('TL004', N'Tiểu thuyết', N'Truyện dài'),
('TL005', N'Khoa học', N'Sách khoa học'),
('TL006', N'Lịch sử', N'Sách lịch sử'),
('TL007', N'Tâm lý', N'Sách tâm lý học');

-- 3. Nhà xuất bản
CREATE TABLE NhaXuatBan (
    MaNXB CHAR(10) PRIMARY KEY,
    TenNXB NVARCHAR(255) NOT NULL,
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(20),
    Email VARCHAR(100)
);

INSERT INTO NhaXuatBan VALUES
('NXB01', N'NXB Trẻ', N'HCM', '0123456789', 'tre@nxb.vn'),
('NXB02', N'Bloomsbury', N'London', '0987654321', 'info@bloomsbury.com'),
('NXB03', N'NXB Giáo dục', N'Hà Nội', '0911111111', 'giaoduc@nxb.vn'),
('NXB04', N'Penguin', N'New York', '0922222222', 'penguin@pub.com'),
('NXB05', N'NXB Văn học', N'Hà Nội', '0933333333', 'vanhoc@nxb.vn'),
('NXB06', N'NXB Kim Đồng', N'HCM', '0944444444', 'kimdong@nxb.vn'),
('NXB07', N'NXB Chính trị', N'Hà Nội', '0955555555', 'chinhtri@nxb.vn');

-- 4. Ngôn ngữ
CREATE TABLE NgonNgu (
    MaNgonNgu CHAR(10) PRIMARY KEY,
    TenNgonNgu NVARCHAR(100) NOT NULL
);

INSERT INTO NgonNgu VALUES
('NN01', N'Tiếng Việt'),
('NN02', N'Tiếng Anh'),
('NN03', N'Tiếng Pháp'),
('NN04', N'Tiếng Nhật'),
('NN05', N'Tiếng Trung'),
('NN06', N'Tiếng Đức'),
('NN07', N'Tiếng Tây Ban Nha');

-- 5. Nhân viên
CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    ChucVu NVARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    DienThoai VARCHAR(20),
    NgayVaoLam DATE
);

INSERT INTO NhanVien VALUES
('NV001', N'Trần Văn Thư', '1990-05-12', N'Nam', N'Thủ thư', 'nv001@lib.vn', '0901111111', '2020-01-01'),
('NV002', N'Nguyễn Thị Hoa', '1988-03-22', N'Nữ', N'Thủ thư', 'nv002@lib.vn', '0902222222', '2019-02-01'),
('NV003', N'Lê Văn Bình', '1992-07-10', N'Nam', N'Quản lý', 'nv003@lib.vn', '0903333333', '2018-03-01'),
('NV004', N'Phạm Thị Mai', '1995-09-15', N'Nữ', N'Thủ thư', 'nv004@lib.vn', '0904444444', '2021-04-01'),
('NV005', N'Hoàng Văn Nam', '1985-11-20', N'Nam', N'Quản lý', 'nv005@lib.vn', '0905555555', '2017-05-01'),
('NV006', N'Đỗ Thị Hạnh', '1993-01-05', N'Nữ', N'Thủ thư', 'nv006@lib.vn', '0906666666', '2022-06-01'),
('NV007', N'Ngô Văn Tài', '1991-12-30', N'Nam', N'Thủ thư', 'nv007@lib.vn', '0907777777', '2023-07-01');

-- 6. Độc giả
CREATE TABLE DocGia (
    MaDocGia CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(20),
    Email VARCHAR(100) UNIQUE,
    NgayDangKy DATE
);

INSERT INTO DocGia VALUES
('DG001', N'Nguyễn Văn A', '2000-03-15', N'Nam', N'Hà Nội', '0911111111', 'dg001@lib.vn', GETDATE()),
('DG002', N'Trần Thị B', '1998-07-20', N'Nữ', N'HCM', '0912222222', 'dg002@lib.vn', GETDATE()),
('DG003', N'Lê Văn C', '1995-01-10', N'Nam', N'Đà Nẵng', '0913333333', 'dg003@lib.vn', GETDATE()),
('DG004', N'Phạm Thị D', '1999-09-25', N'Nữ', N'Hải Phòng', '0914444444', 'dg004@lib.vn', GETDATE()),
('DG005', N'Hoàng Văn E', '2001-12-05', N'Nam', N'Cần Thơ', '0915555555', 'dg005@lib.vn', GETDATE()),
('DG006', N'Đỗ Thị F', '1997-06-18', N'Nữ', N'Hà Nội', '0916666666', 'dg006@lib.vn', GETDATE()),
('DG007', N'Ngô Văn G', '1996-11-30', N'Nam', N'HCM', '0917777777', 'dg007@lib.vn', GETDATE());

-- 7. Kho
CREATE TABLE Kho (
    MaKho CHAR(10) PRIMARY KEY,
    TenKho NVARCHAR(100),
    ViTri NVARCHAR(255),
    Tang INT,
    Phong NVARCHAR(50)
);

INSERT INTO Kho VALUES
('KHO1', N'Kho chính', N'Tầng trệt', 1, N'Phòng A'),
('KHO2', N'Kho phụ', N'Tầng 2', 2, N'Phòng B'),
('KHO3', N'Kho sách hiếm', N'Tầng 3', 3, N'Phòng C'),
('KHO4', N'Kho ngoại văn', N'Tầng 4', 4, N'Phòng D'),
('KHO5', N'Kho thiếu nhi', N'Tầng 1', 1, N'Phòng E'),
('KHO6', N'Kho văn học', N'Tầng 2', 2, N'Phòng F'),
('KHO7', N'Kho khoa học', N'Tầng 3', 3, N'Phòng G');



CREATE TABLE KeSach (
    MaKe CHAR(10) PRIMARY KEY,           
    TenKe NVARCHAR(100) NOT NULL,        
    ViTri NVARCHAR(100),				  
    MaTheLoai CHAR(10) NOT NULL,		
    SoLuongSach INT DEFAULT 0,           
    HinhAnh NVARCHAR(255),               
    MoTa NVARCHAR(255),                  
    CONSTRAINT FK_KeSach_TheLoai FOREIGN KEY (MaTheLoai)
    REFERENCES TheLoai(MaTheLoai)
);

INSERT INTO KeSach (MaKe, TenKe, ViTri, MaTheLoai, SoLuongSach, HinhAnh, MoTa)
VALUES
('Ke1', N'Kệ Văn học Việt Nam', N'Tầng 1 - Góc trái', 'TL001', 120, 'Images/vanhoc.png', N'Chứa sách văn học Việt Nam'),
('Ke2', N'Kệ Kinh tế', N'Tầng 1 - Góc phải', 'TL002', 80, 'Images/kinhte.png', N'Chứa sách về kinh tế, tài chính'),
('Ke3', N'Kệ Kỹ năng sống', N'Tầng 1 - Giữa phòng', 'TL003', 95, 'Images/kynang.png', N'Chứa sách kỹ năng sống và giao tiếp'),
('Ke4', N'Kệ Công nghệ', N'Tầng 1 - Khu công nghệ', 'TL004', 100, 'Images/congnghe.png', N'Chứa sách công nghệ, lập trình'),
('Ke5', N'Kệ Lịch sử', N'Tầng 1 - Góc sau', 'TL005', 70, 'Images/lichsu.jpg', N'Chứa sách lịch sử Việt Nam và thế giới');


UPDATE KeSach SET HinhAnh = 'vanhoc' WHERE MaKe = 'Ke1';
UPDATE KeSach SET HinhAnh = 'kinhte' WHERE MaKe = 'Ke2';
UPDATE KeSach SET HinhAnh = 'kynang' WHERE MaKe = 'Ke3';
UPDATE KeSach SET HinhAnh = 'congnghe' WHERE MaKe = 'Ke4';
UPDATE KeSach SET HinhAnh = 'lichsu' WHERE MaKe = 'Ke5';



ALTER TABLE KeSach
ADD MaKho CHAR(10);

ALTER TABLE KeSach
ADD CONSTRAINT FK_KeSach_Kho FOREIGN KEY (MaKho)
REFERENCES Kho(MaKho);







--9. Sách
CREATE TABLE Sach (
    MaSach CHAR(10) PRIMARY KEY,
    TieuDe NVARCHAR(255) NOT NULL,
    ISBN VARCHAR(20) UNIQUE,
    NamXuatBan INT,
    SoTrang INT,
    SoLuongTon INT DEFAULT 0,
    MoTa NVARCHAR(MAX),
    MaNXB CHAR(10),
    MaNgonNgu CHAR(10),
    MaTacGia CHAR(10),
    MaKho CHAR(10),
    MaKe CHAR(10),
    MaTheLoai CHAR(10),
    FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan(MaNXB),
    FOREIGN KEY (MaNgonNgu) REFERENCES NgonNgu(MaNgonNgu),
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
    FOREIGN KEY (MaKho) REFERENCES Kho(MaKho),
    FOREIGN KEY (MaKe) REFERENCES KeSach(MaKe),
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)
);






INSERT INTO Sach VALUES
('S001', N'Tôi thấy hoa vàng trên cỏ xanh', 'ISBN001', 2010, 250, 10, N'Tiểu thuyết thiếu nhi', 'NXB01', 'NN01', 'TG001', 'KHO1', 'KE1', 'TL001'),
('S002', N'Harry Potter và Hòn đá phù thủy', 'ISBN002', 1997, 320, 5, N'Fantasy nổi tiếng', 'NXB02', 'NN02', 'TG002', 'KHO1', 'KE2', 'TL002'),
('S003', N'1984', 'ISBN003', 1949, 300, 7, N'Tiểu thuyết dystopia', 'NXB04', 'NN02', 'TG003', 'KHO2', 'KE3', 'TL003'),
('S004', N'Kafka bên bờ biển', 'ISBN004', 2002, 450, 4, N'Tiểu thuyết Nhật', 'NXB05', 'NN04', 'TG004', 'KHO3', 'KE4', 'TL004'),
('S005', N'Les Misérables', 'ISBN005', 1862, 1200, 2, N'Tác phẩm kinh điển', 'NXB03', 'NN03', 'TG005', 'KHO4', 'KE3', 'TL003'),
('S006', N'The Old Man and the Sea', 'ISBN006', 1952, 127, 6, N'Tác phẩm đoạt Nobel', 'NXB04', 'NN02', 'TG006', 'KHO5', 'KE4', 'TL004'),
('S007', N'Tắt đèn', 'ISBN007', 1939, 200, 8, N'Tác phẩm hiện thực Việt Nam', 'NXB05', 'NN01', 'TG007', 'KHO6', 'KE3', 'TL003');


--10. Thẻ Thư Viện
CREATE TABLE TheThuVien (
    MaThe CHAR(10) PRIMARY KEY,
    MaDocGia CHAR(10),
    NgayCap DATE,
    NgayHetHan DATE,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia)
);

INSERT INTO TheThuVien VALUES
('TT001', 'DG001', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT002', 'DG002', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT003', 'DG003', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT004', 'DG004', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT005', 'DG005', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT006', 'DG006', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực'),
('TT007', 'DG007', GETDATE(), DATEADD(YEAR,1,GETDATE()), N'Còn hiệu lực');





--11.Phiếu mượn
CREATE TABLE PhieuMuon (
    MaPhieuMuon CHAR(10) PRIMARY KEY,
    MaDocGia CHAR(10),
    MaThe CHAR(10),
    NguoiPhuTrach CHAR(10),
    NgayMuon DATE,
    HanTra DATE,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
    FOREIGN KEY (MaThe) REFERENCES TheThuVien(MaThe),
    FOREIGN KEY (NguoiPhuTrach) REFERENCES NhanVien(MaNV)
);



INSERT INTO PhieuMuon VALUES
('PM001','DG001','TT001','NV001',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM002','DG002','TT002','NV002',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM003','DG003','TT003','NV003',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM004','DG004','TT004','NV004',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM005','DG005','TT005','NV005',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM006','DG006','TT006','NV006',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn'),
('PM007','DG007','TT007','NV007',GETDATE(),DATEADD(DAY,7,GETDATE()),N'Đang mượn');


--12.Chi tiết phiếu mượn
CREATE TABLE ChiTietPhieuMuon (
    MaPhieuMuon CHAR(10),
    MaSach CHAR(10),
    PRIMARY KEY (MaPhieuMuon, MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuon(MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

INSERT INTO ChiTietPhieuMuon VALUES
('PM001','S001'),
('PM002','S002'),
('PM003','S003'),
('PM004','S004'),
('PM005','S005'),
('PM006','S006'),
('PM007','S007');


--13.Phiếu trả
CREATE TABLE PhieuTra (
    MaPhieuTra CHAR(10) PRIMARY KEY,
    MaPhieuMuon CHAR(10),
    NgayTra DATE,
    TinhTrangSach NVARCHAR(100),
    GhiChu NVARCHAR(MAX),
    SoTien DECIMAL(10,2) DEFAULT 0,
    NguoiPhuTrach CHAR(10),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuon(MaPhieuMuon),
    FOREIGN KEY (NguoiPhuTrach) REFERENCES NhanVien(MaNV)
);

INSERT INTO PhieuTra VALUES
('PT001','PM001',DATEADD(DAY,5,GETDATE()),N'Bình thường',NULL,0,'NV001'),
('PT002','PM002',DATEADD(DAY,6,GETDATE()),N'Bình thường',NULL,0,'NV002'),
('PT003','PM003',DATEADD(DAY,8,GETDATE()),N'Trễ hạn',N'Phạt 10k',10000,'NV003'),
('PT004','PM004',DATEADD(DAY,7,GETDATE()),N'Bình thường',NULL,0,'NV004'),
('PT005','PM005',DATEADD(DAY,9,GETDATE()),N'Hỏng sách',N'Phạt 20k',20000,'NV005'),
('PT006','PM006',DATEADD(DAY,10,GETDATE()),N'Mất sách',N'Phạt 50k',50000,'NV006'),
('PT007','PM007',DATEADD(DAY,11,GETDATE()),N'Bình thường',NULL,0,'NV007');


--14. Chi tiết phiếu trả
CREATE TABLE ChiTietPhieuTra (
    MaPhieuTra CHAR(10),
    MaSach CHAR(10),
    TinhTrang NVARCHAR(100),
    PhiPhat DECIMAL(10,2) DEFAULT 0,
    GhiChu NVARCHAR(MAX),
    PRIMARY KEY (MaPhieuTra, MaSach),
    FOREIGN KEY (MaPhieuTra) REFERENCES PhieuTra(MaPhieuTra),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

INSERT INTO ChiTietPhieuTra VALUES
('PT001','S001',N'Tốt',0,NULL),
('PT002','S002',N'Tốt',0,NULL),
('PT003','S003',N'Trễ hạn',10000,N'Phạt do trả muộn'),
('PT004','S004',N'Tốt',0,NULL),
('PT005','S005',N'Hỏng',20000,N'Bìa sách rách'),
('PT006','S006',N'Mất',50000,N'Không trả sách'),
('PT007','S007',N'Tốt',0,NULL);





--1. Bảng vai trò
CREATE TABLE VaiTro (
    MaVaiTro   INT           PRIMARY KEY IDENTITY(1,1),
    TenVaiTro  NVARCHAR(50)  NOT NULL UNIQUE,  -- Admin / ThuThu / DocGia
    MoTa       NVARCHAR(255)
);

-- Dữ liệu mặc định
INSERT INTO VaiTro (TenVaiTro, MoTa) VALUES
    (N'Admin',   N'Toàn quyền: quản lý hệ thống, tài khoản, báo cáo'),
    (N'ThuThu',  N'Quản lý sách, mượn/trả, độc giả'),
    (N'DocGia',  N'Xem danh mục sách, xem lịch sử mượn của bản thân');
GO

--2. Bảng tài khoản
CREATE TABLE TaiKhoan (
    MaTaiKhoan  INT           PRIMARY KEY IDENTITY(1,1),
    TenDangNhap VARCHAR(50)   NOT NULL UNIQUE,
    MatKhau     VARCHAR(100)  NOT NULL,        
    MaVaiTro    INT           NOT NULL,
    MaNV        CHAR(10)      NULL,             -- liên kết NhanVien (Admin / ThuThu)
    MaDocGia    CHAR(10)      NULL,             -- liên kết DocGia
    TrangThai   NVARCHAR(20)  NOT NULL DEFAULT N'HoatDong', -- HoatDong / BiKhoa
    NgayTao     DATE          NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (MaVaiTro)  REFERENCES VaiTro(MaVaiTro),
    FOREIGN KEY (MaNV)      REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaDocGia)  REFERENCES DocGia(MaDocGia),
    -- Ràng buộc: chỉ được liên kết 1 trong 2
    CONSTRAINT CK_TaiKhoan_LoaiUser CHECK (
        (MaNV IS NOT NULL AND MaDocGia IS NULL) OR
        (MaNV IS NULL AND MaDocGia IS NULL) OR   -- tài khoản admin hệ thống
        (MaNV IS NULL AND MaDocGia IS NOT NULL)
    )
);
GO


-- 3. Lịch sử đăng nhập

CREATE TABLE LichSuDangNhap (
    MaLog       INT          PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan  INT          NOT NULL,
    ThoiGian    DATETIME     NOT NULL DEFAULT GETDATE(),
    KetQua      NVARCHAR(20) NOT NULL,  -- ThanhCong / ThatBai
    GhiChu      NVARCHAR(255),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);
GO

-- 4. Bảng Quyền
CREATE TABLE Quyen (
    MaQuyen    INT           PRIMARY KEY IDENTITY(1,1),
    MaVaiTro   INT           NOT NULL,
    ManHinh    NVARCHAR(100) NOT NULL,  -- tên form / module
    CoPhep     BIT           NOT NULL DEFAULT 1,
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro)
);

-- Phân quyền mặc định
INSERT INTO Quyen (MaVaiTro, ManHinh, CoPhep)
SELECT MaVaiTro, ManHinh, 1 FROM (VALUES
    -- Admin: tất cả
    (1, N'frmQuanLySach'),
    (1, N'frmQuanLyDocGia'),
    (1, N'frmQuanLyNhanVien'),
    (1, N'frmQuanLyTaiKhoan'),
    (1, N'frmMuonSach'),
    (1, N'frmTraSach'),
    (1, N'frmBaoCao'),
    (1, N'frmCaiDat'),
    -- ThuThu: quản lý nghiệp vụ, không có quản lý tài khoản & cài đặt
    (2, N'frmQuanLySach'),
    (2, N'frmQuanLyDocGia'),
    (2, N'frmMuonSach'),
    (2, N'frmTraSach'),
    (2, N'frmBaoCao'),
    -- DocGia: chỉ xem
    (3, N'frmXemSach'),
    (3, N'frmLichSuMuon')
) AS T(MaVaiTro, ManHinh);
GO


-- 5. Tài khoản mẫu để test
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaVaiTro, MaNV, MaDocGia)
VALUES
    ('admin',    '123456', 1, NULL, NULL),   -- Admin hệ thống
    ('thuthu01', '123456', 2, NULL, NULL),   -- Thủ thư (gán MaNV sau)
    ('docgia01', '123456', 3, NULL, NULL);   -- Độc giả  (gán MaDocGia sau)
GO

--Thông Báo
CREATE TABLE ThongBao (
    MaThongBao INT IDENTITY PRIMARY KEY,
    LoaiTB NVARCHAR(50),
    TieuDe NVARCHAR(200),
    NoiDung NVARCHAR(MAX),
    ThoiGian DATETIME,
    DaDoc BIT,
    DuongDan NVARCHAR(100)
);

INSERT INTO ThongBao (LoaiTB, TieuDe, NoiDung, ThoiGian, DaDoc, DuongDan)
VALUES (N'HeThong', N'Thông báo hệ thống', N'Hệ thống sẽ bảo trì lúc 22h', GETDATE(), 0, N'frmMain');

INSERT INTO ThongBao (LoaiTB, TieuDe, NoiDung, ThoiGian, DaDoc, DuongDan)
VALUES (N'QuaHan', N'Sách quá hạn', N'Có 3 phiếu mượn đã quá hạn', GETDATE(), 0, N'frmMuonTra');

INSERT INTO ThongBao (LoaiTB, TieuDe, NoiDung, ThoiGian, DaDoc, DuongDan)
VALUES (N'DocGiaMoi', N'Độc giả mới', N'Có 2 độc giả đăng ký hôm nay', GETDATE(), 0, N'frmQuanLyDocGia');

INSERT INTO ThongBao (LoaiTB, TieuDe, NoiDung, ThoiGian, DaDoc, DuongDan)
VALUES (N'KeSapDay', N'Kệ sách sắp đầy', N'Kệ A1 đã đạt 90% sức chứa', GETDATE(), 0, N'frmKhoSach');

INSERT INTO ThongBao (LoaiTB, TieuDe, NoiDung, ThoiGian, DaDoc, DuongDan)
VALUES (N'HeThong', N'Cập nhật phần mềm', N'Phiên bản mới đã được cài đặt', GETDATE(), 0, N'frmMain');


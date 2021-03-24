using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymProJectv2.Migrations
{
    public partial class _03162021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDV = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GiaoAns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaGiaoAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenGiaoAn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CaHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NhomGiaoAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoAns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoaiKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    SoTKNganHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenNganHang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LopHocs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLop = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenLop = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CMND = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ChuyenMon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhomHangHoas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhomHangHoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNhomHangHoa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomHangHoas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TieuChiDanhGias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTieuChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoaiTieuChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiemToiDa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TieuChiDanhGias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HocVienDKLopHocs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLopHoc = table.Column<int>(type: "int", nullable: false),
                    IDKhachHang = table.Column<int>(type: "int", nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDDichVu = table.Column<int>(type: "int", nullable: false),
                    ChiNhanh = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ThoiGianHoc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVienDKLopHocs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HocVienDKLopHocs_DichVus_IDDichVu",
                        column: x => x.IDDichVu,
                        principalTable: "DichVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVienDKLopHocs_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HocVienDKLopHocs_LopHocs_IDLopHoc",
                        column: x => x.IDLopHoc,
                        principalTable: "LopHocs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    IDKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaChiNhanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaSoThue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDoanhNghiep = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DiaChiChiNhanh = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SoThue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false),
                    NgayLapHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenNVBanHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenNVLapPhieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaKHLienQuan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaNVBanHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaNVLapPhieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LapGiaoAns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    IDGiaoAn = table.Column<int>(type: "int", nullable: false),
                    IDLopHoc = table.Column<int>(type: "int", nullable: false),
                    ThoiGianKhaiGiang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoLuongHocVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapGiaoAns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LapGiaoAns_GiaoAns_IDGiaoAn",
                        column: x => x.IDGiaoAn,
                        principalTable: "GiaoAns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapGiaoAns_LopHocs_IDLopHoc",
                        column: x => x.IDLopHoc,
                        principalTable: "LopHocs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapGiaoAns_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuChis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieuChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoPhieuChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayLapPhieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenNVLapPhieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HinhThucChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoTenNguoiNhan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoaiPhieuChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false),
                    TTLienLac = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LyDoChi = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TenKH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenNVBanHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenNhanVienChiuTrachNhiem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDNhanVienLapPhieu = table.Column<int>(type: "int", nullable: true),
                    IDNhanVienBanHang = table.Column<int>(type: "int", nullable: true),
                    KhachHangID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuChis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuChis_KhachHangs_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuChis_NhanViens_IDNhanVienBanHang",
                        column: x => x.IDNhanVienBanHang,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuChis_NhanViens_IDNhanVienLapPhieu",
                        column: x => x.IDNhanVienLapPhieu,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKhachHang = table.Column<int>(type: "int", nullable: true),
                    MaPhieuThu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoPhieuThu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoaiThue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoaiPhieuThu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LyDoNop = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false),
                    NgayLapPhieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDNhanVienLapPhieu = table.Column<int>(type: "int", nullable: true),
                    IDNhanVienBanHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuThus_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuThus_NhanViens_IDNhanVienBanHang",
                        column: x => x.IDNhanVienBanHang,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuThus_NhanViens_IDNhanVienLapPhieu",
                        column: x => x.IDNhanVienLapPhieu,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MaSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDNhomHangHoa = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPhams_NhomHangHoas_IDNhomHangHoa",
                        column: x => x.IDNhomHangHoa,
                        principalTable: "NhomHangHoas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuDanhGiaHLVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDHuanLuyenVien = table.Column<int>(type: "int", nullable: true),
                    IDNhanVienDanhGia = table.Column<int>(type: "int", nullable: true),
                    Diem = table.Column<int>(type: "int", nullable: false),
                    IDTieuChiDanhGia = table.Column<int>(type: "int", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDanhGiaHLVs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuDanhGiaHLVs_NhanViens_IDHuanLuyenVien",
                        column: x => x.IDHuanLuyenVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDanhGiaHLVs_NhanViens_IDNhanVienDanhGia",
                        column: x => x.IDNhanVienDanhGia,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuDanhGiaHLVs_TieuChiDanhGias_IDTieuChiDanhGia",
                        column: x => x.IDTieuChiDanhGia,
                        principalTable: "TieuChiDanhGias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonSanPhams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHoaDon = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonSanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonSanPhams_HoaDons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonSanPhams_SanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LapPhieuChis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPhieuChi = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapPhieuChis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LapPhieuChis_PhieuChis_IDPhieuChi",
                        column: x => x.IDPhieuChi,
                        principalTable: "PhieuChis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapPhieuChis_SanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LapPhieuThus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPhieuThu = table.Column<int>(type: "int", nullable: false),
                    IDKhachHang = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapPhieuThus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LapPhieuThus_PhieuThus_IDPhieuThu",
                        column: x => x.IDPhieuThu,
                        principalTable: "PhieuThus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LapPhieuThus_SanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IDKhachHang",
                table: "HoaDons",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IDNhanVien",
                table: "HoaDons",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonSanPhams_IDHoaDon",
                table: "HoaDonSanPhams",
                column: "IDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonSanPhams_IDSanPham",
                table: "HoaDonSanPhams",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HocVienDKLopHocs_IDDichVu",
                table: "HocVienDKLopHocs",
                column: "IDDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_HocVienDKLopHocs_IDKhachHang",
                table: "HocVienDKLopHocs",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HocVienDKLopHocs_IDLopHoc",
                table: "HocVienDKLopHocs",
                column: "IDLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_LapGiaoAns_IDGiaoAn",
                table: "LapGiaoAns",
                column: "IDGiaoAn");

            migrationBuilder.CreateIndex(
                name: "IX_LapGiaoAns_IDLopHoc",
                table: "LapGiaoAns",
                column: "IDLopHoc");

            migrationBuilder.CreateIndex(
                name: "IX_LapGiaoAns_IDNhanVien",
                table: "LapGiaoAns",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_LapPhieuChis_IDPhieuChi",
                table: "LapPhieuChis",
                column: "IDPhieuChi");

            migrationBuilder.CreateIndex(
                name: "IX_LapPhieuChis_IDSanPham",
                table: "LapPhieuChis",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_LapPhieuThus_IDPhieuThu",
                table: "LapPhieuThus",
                column: "IDPhieuThu");

            migrationBuilder.CreateIndex(
                name: "IX_LapPhieuThus_IDSanPham",
                table: "LapPhieuThus",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChis_IDNhanVienBanHang",
                table: "PhieuChis",
                column: "IDNhanVienBanHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChis_IDNhanVienLapPhieu",
                table: "PhieuChis",
                column: "IDNhanVienLapPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuChis_KhachHangID",
                table: "PhieuChis",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDanhGiaHLVs_IDHuanLuyenVien",
                table: "PhieuDanhGiaHLVs",
                column: "IDHuanLuyenVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDanhGiaHLVs_IDNhanVienDanhGia",
                table: "PhieuDanhGiaHLVs",
                column: "IDNhanVienDanhGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDanhGiaHLVs_IDTieuChiDanhGia",
                table: "PhieuDanhGiaHLVs",
                column: "IDTieuChiDanhGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_IDKhachHang",
                table: "PhieuThus",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_IDNhanVienBanHang",
                table: "PhieuThus",
                column: "IDNhanVienBanHang");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_IDNhanVienLapPhieu",
                table: "PhieuThus",
                column: "IDNhanVienLapPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IDNhomHangHoa",
                table: "SanPhams",
                column: "IDNhomHangHoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonSanPhams");

            migrationBuilder.DropTable(
                name: "HocVienDKLopHocs");

            migrationBuilder.DropTable(
                name: "LapGiaoAns");

            migrationBuilder.DropTable(
                name: "LapPhieuChis");

            migrationBuilder.DropTable(
                name: "LapPhieuThus");

            migrationBuilder.DropTable(
                name: "PhieuDanhGiaHLVs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "DichVus");

            migrationBuilder.DropTable(
                name: "GiaoAns");

            migrationBuilder.DropTable(
                name: "LopHocs");

            migrationBuilder.DropTable(
                name: "PhieuChis");

            migrationBuilder.DropTable(
                name: "PhieuThus");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TieuChiDanhGias");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "NhomHangHoas");
        }
    }
}

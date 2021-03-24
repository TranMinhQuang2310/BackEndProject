using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymProJectv2.Migrations
{
    public partial class _03232021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LapGiaoAns");

            migrationBuilder.DropColumn(
                name: "ThoiGianHoc",
                table: "HocVienDKLopHocs");

            migrationBuilder.DropColumn(
                name: "CaHoc",
                table: "GiaoAns");

            migrationBuilder.AddColumn<int>(
                name: "IDGiaoAn",
                table: "LopHocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDNhanVien",
                table: "LopHocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayBatDau",
                table: "LopHocs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayKetThuc",
                table: "LopHocs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SoPhong",
                table: "LopHocs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongHocVien",
                table: "GiaoAns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongTietHoc",
                table: "GiaoAns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GiaoAnHLVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDGiaoAn = table.Column<int>(type: "int", nullable: false),
                    IDHuanLuyenVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoAnHLVs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GiaoAnHLVs_GiaoAns_IDGiaoAn",
                        column: x => x.IDGiaoAn,
                        principalTable: "GiaoAns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiaoAnHLVs_NhanViens_IDHuanLuyenVien",
                        column: x => x.IDHuanLuyenVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_IDGiaoAn",
                table: "LopHocs",
                column: "IDGiaoAn");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocs_IDNhanVien",
                table: "LopHocs",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoAnHLVs_IDGiaoAn",
                table: "GiaoAnHLVs",
                column: "IDGiaoAn");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoAnHLVs_IDHuanLuyenVien",
                table: "GiaoAnHLVs",
                column: "IDHuanLuyenVien");

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_GiaoAns_IDGiaoAn",
                table: "LopHocs",
                column: "IDGiaoAn",
                principalTable: "GiaoAns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LopHocs_NhanViens_IDNhanVien",
                table: "LopHocs",
                column: "IDNhanVien",
                principalTable: "NhanViens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_GiaoAns_IDGiaoAn",
                table: "LopHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_LopHocs_NhanViens_IDNhanVien",
                table: "LopHocs");

            migrationBuilder.DropTable(
                name: "GiaoAnHLVs");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_IDGiaoAn",
                table: "LopHocs");

            migrationBuilder.DropIndex(
                name: "IX_LopHocs_IDNhanVien",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "IDGiaoAn",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "IDNhanVien",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "NgayBatDau",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "NgayKetThuc",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "SoPhong",
                table: "LopHocs");

            migrationBuilder.DropColumn(
                name: "SoLuongHocVien",
                table: "GiaoAns");

            migrationBuilder.DropColumn(
                name: "SoLuongTietHoc",
                table: "GiaoAns");

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianHoc",
                table: "HocVienDKLopHocs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CaHoc",
                table: "GiaoAns",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LapGiaoAns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDGiaoAn = table.Column<int>(type: "int", nullable: false),
                    IDLopHoc = table.Column<int>(type: "int", nullable: false),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    SoLuongHocVien = table.Column<int>(type: "int", nullable: false),
                    ThoiGianHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKhaiGiang = table.Column<DateTime>(type: "datetime2", nullable: false)
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
        }
    }
}

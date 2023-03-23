using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class duan01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dichVus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dichVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hangDTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangDTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loaiDTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiDTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    LinkImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangDT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiDT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCapCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhuyenMaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiDTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangDTId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sanPhams_hangDTs_HangDTId",
                        column: x => x.HangDTId,
                        principalTable: "hangDTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_khuyenMais_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "khuyenMais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_loaiDTs_LoaiDTId",
                        column: x => x.LoaiDTId,
                        principalTable: "loaiDTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDonCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCapCTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCapCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nhaCungCapCTs_nhaCungCaps_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "nhaCungCaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nhaCungCapCTs_sanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "sanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonCTs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IntoMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DichVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhuyenMaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_dichVus_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "dichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_khuyenMais_KhuyenMaiId",
                        column: x => x.KhuyenMaiId,
                        principalTable: "khuyenMais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonCTs_sanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "sanPhams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_DichVuId",
                table: "hoaDonCTs",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_HoaDonId",
                table: "hoaDonCTs",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_KhuyenMaiId",
                table: "hoaDonCTs",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonCTs_SanPhamId",
                table: "hoaDonCTs",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienId",
                table: "hoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_nhaCungCapCTs_NhaCungCapId",
                table: "nhaCungCapCTs",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_nhaCungCapCTs_SanPhamId",
                table: "nhaCungCapCTs",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_HangDTId",
                table: "sanPhams",
                column: "HangDTId");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_KhuyenMaiId",
                table: "sanPhams",
                column: "KhuyenMaiId");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_LoaiDTId",
                table: "sanPhams",
                column: "LoaiDTId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonCTs");

            migrationBuilder.DropTable(
                name: "nhaCungCapCTs");

            migrationBuilder.DropTable(
                name: "dichVus");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "nhaCungCaps");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "hangDTs");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "loaiDTs");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace baitap.Migrations
{
    public partial class test02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tensp",
                table: "SanPhams",
                newName: "TenSP");

            migrationBuilder.RenameColumn(
                name: "Soluong",
                table: "SanPhams",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "Giaban",
                table: "SanPhams",
                newName: "GiaBan");

            migrationBuilder.RenameColumn(
                name: "Idsp",
                table: "SanPhams",
                newName: "IdSP");

            migrationBuilder.RenameColumn(
                name: "Gianap",
                table: "SanPhams",
                newName: "GiaNhap");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNhap",
                table: "SanPhams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NhaCC",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayNhap",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "NhaCC",
                table: "SanPhams");

            migrationBuilder.RenameColumn(
                name: "TenSP",
                table: "SanPhams",
                newName: "Tensp");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "SanPhams",
                newName: "Soluong");

            migrationBuilder.RenameColumn(
                name: "GiaBan",
                table: "SanPhams",
                newName: "Giaban");

            migrationBuilder.RenameColumn(
                name: "IdSP",
                table: "SanPhams",
                newName: "Idsp");

            migrationBuilder.RenameColumn(
                name: "GiaNhap",
                table: "SanPhams",
                newName: "Gianap");
        }
    }
}

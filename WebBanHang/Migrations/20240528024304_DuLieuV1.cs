using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class DuLieuV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "Điện thoại" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 2, 2, "Máy tính bảng" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 3, 3, "Laptop" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, "SH350i", 300.0 },
                    { 2, 1, null, null, "SH160i/125i", 350.0 },
                    { 3, 1, null, null, "Sh Mode 125", 400.0 },
                    { 4, 1, null, null, "Vario 160", 420.0 },
                    { 5, 1, null, null, "Air Blade 2025", 630.0 },
                    { 6, 1, null, null, "Vario 125", 750.0 },
                    { 7, 1, null, null, "LEAD 125", 820.0 },
                    { 8, 1, null, null, "Iphone 14 Pro", 950.0 },
                    { 9, 1, null, null, "Vision Phiên Bản C", 1200.0 },
                    { 10, 1, null, null, "Super Cub C125 ", 1450.0 },
                    { 11, 2, null, null, "Wave RSX", 750.0 },
                    { 12, 2, null, null, "Wave Alpha 110", 1250.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

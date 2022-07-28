using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_DatabaseFirst.Migrations
{
    public partial class thuyenupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodTour",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaMonAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenMonAn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodTour");
        }
    }
}

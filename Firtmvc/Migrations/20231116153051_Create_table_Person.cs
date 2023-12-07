using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firtmvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "HeThongPhanPhoi",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    TenHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongPhanPhoi", x => x.MaHTPP);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    MaDaily = table.Column<string>(type: "TEXT", nullable: false),
                    TenDaily = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", nullable: false),
                    DienThoai = table.Column<string>(type: "TEXT", nullable: false),
                    HeThongPhanPhoiTempId1 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.MaHTPP);
                    table.ForeignKey(
                        name: "FK_Daily_HeThongPhanPhoi_HeThongPhanPhoiTempId1",
                        column: x => x.HeThongPhanPhoiTempId1,
                        principalTable: "HeThongPhanPhoi",
                        principalColumn: "MaHTPP");
                    table.ForeignKey(
                        name: "FK_Daily_HeThongPhanPhoi_MaHTPP",
                        column: x => x.MaHTPP,
                        principalTable: "HeThongPhanPhoi",
                        principalColumn: "MaHTPP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Daily_HeThongPhanPhoiTempId1",
                table: "Daily",
                column: "HeThongPhanPhoiTempId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Daily");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "HeThongPhanPhoi");
        }
    }
}

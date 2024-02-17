using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAndPayWebApi.Migrations
{
    /// <inheritdoc />
    public partial class StudentDatatable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentData",
                columns: table => new
                {
                    AdmissionNumber = table.Column<string>(type: "text", nullable: false),
                    RFID_UID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentData", x => x.AdmissionNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentData");
        }
    }
}

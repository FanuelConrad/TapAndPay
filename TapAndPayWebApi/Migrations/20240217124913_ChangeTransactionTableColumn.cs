using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TapAndPayWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTransactionTableColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transactions",
                newName: "TransactionId");
        }
    }
}

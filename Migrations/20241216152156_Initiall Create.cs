using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expence_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class InitiallCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "TransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "TransactionId");
        }
    }
}

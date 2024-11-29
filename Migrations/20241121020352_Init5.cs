using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectForYp2.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_ClientId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Comments",
                newName: "requestId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ClientId",
                table: "Comments",
                newName: "IX_Comments_requestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_requestId",
                table: "Comments",
                column: "requestId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_requestId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "requestId",
                table: "Comments",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_requestId",
                table: "Comments",
                newName: "IX_Comments_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

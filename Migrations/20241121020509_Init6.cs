using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectForYp2.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_requestId",
                table: "Comments");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Requests_requestId",
                table: "Comments",
                column: "requestId",
                principalTable: "Requests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Requests_requestId",
                table: "Comments");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_requestId",
                table: "Comments",
                column: "requestId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

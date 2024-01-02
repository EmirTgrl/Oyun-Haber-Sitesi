using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updategametable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameTypes_GameTypeTypeId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameTypeTypeId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameTypeTypeId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "GameTypes",
                newName: "GameTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Games",
                newName: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameTypeId",
                table: "Games",
                column: "GameTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameTypes_GameTypeId",
                table: "Games",
                column: "GameTypeId",
                principalTable: "GameTypes",
                principalColumn: "GameTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameTypes_GameTypeId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameTypeId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "GameTypeId",
                table: "GameTypes",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "GameTypeId",
                table: "Games",
                newName: "TypeId");

            migrationBuilder.AddColumn<int>(
                name: "GameTypeTypeId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameTypeTypeId",
                table: "Games",
                column: "GameTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameTypes_GameTypeTypeId",
                table: "Games",
                column: "GameTypeTypeId",
                principalTable: "GameTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

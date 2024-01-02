using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class deletetestimonialfromnews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Testimonials_TestimonialId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_TestimonialId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "TestimonialId",
                table: "News");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestimonialId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_News_TestimonialId",
                table: "News",
                column: "TestimonialId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Testimonials_TestimonialId",
                table: "News",
                column: "TestimonialId",
                principalTable: "Testimonials",
                principalColumn: "TestimonialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

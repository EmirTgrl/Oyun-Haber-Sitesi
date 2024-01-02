using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class nullabletestimonialıd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Testimonials_TestimonialId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "TestimonialId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Testimonials_TestimonialId",
                table: "Reviews",
                column: "TestimonialId",
                principalTable: "Testimonials",
                principalColumn: "TestimonialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Testimonials_TestimonialId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "TestimonialId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Testimonials_TestimonialId",
                table: "Reviews",
                column: "TestimonialId",
                principalTable: "Testimonials",
                principalColumn: "TestimonialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

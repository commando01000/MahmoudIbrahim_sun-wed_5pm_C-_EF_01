using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Migrations
{
    /// <inheritdoc />
    public partial class instructor_department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_instructors_departmentId",
                table: "instructors",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_departmentId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "instructors");
        }
    }
}

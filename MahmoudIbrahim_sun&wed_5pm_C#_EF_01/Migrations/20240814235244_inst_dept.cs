using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Migrations
{
    /// <inheritdoc />
    public partial class inst_dept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_departmentId",
                table: "instructors",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

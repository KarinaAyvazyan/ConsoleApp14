using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp14.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Families_AnimalId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Animals",
                newName: "FamilyId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalId",
                table: "Animals",
                newName: "IX_Animals_FamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Families_FamilyId",
                table: "Animals",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Families_FamilyId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "FamilyId",
                table: "Animals",
                newName: "AnimalId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_FamilyId",
                table: "Animals",
                newName: "IX_Animals_AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Families_AnimalId",
                table: "Animals",
                column: "AnimalId",
                principalTable: "Families",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

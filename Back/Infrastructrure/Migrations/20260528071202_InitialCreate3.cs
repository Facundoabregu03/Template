using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Partido_IdsigPartido",
                table: "Partido");

            migrationBuilder.RenameColumn(
                name: "IdsigPartido",
                table: "Partido",
                newName: "IdSigPartido");

            migrationBuilder.RenameIndex(
                name: "IX_Partido_IdsigPartido",
                table: "Partido",
                newName: "IX_Partido_IdSigPartido");

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Partido_IdSigPartido",
                table: "Partido",
                column: "IdSigPartido",
                principalTable: "Partido",
                principalColumn: "IdPartido",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Partido_IdSigPartido",
                table: "Partido");

            migrationBuilder.RenameColumn(
                name: "IdSigPartido",
                table: "Partido",
                newName: "IdsigPartido");

            migrationBuilder.RenameIndex(
                name: "IX_Partido_IdSigPartido",
                table: "Partido",
                newName: "IX_Partido_IdsigPartido");

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Partido_IdsigPartido",
                table: "Partido",
                column: "IdsigPartido",
                principalTable: "Partido",
                principalColumn: "IdPartido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

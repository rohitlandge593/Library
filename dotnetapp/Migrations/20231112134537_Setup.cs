using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapp.Migrations
{
    /// <inheritdoc />
    public partial class Setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Librarycards_LibrarycardId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "LibrarycardId",
                table: "Books",
                newName: "LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_LibrarycardId",
                table: "Books",
                newName: "IX_Books_LibraryCardId");

            migrationBuilder.AlterColumn<int>(
                name: "LibraryCardId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Librarycards_LibraryCardId",
                table: "Books",
                column: "LibraryCardId",
                principalTable: "Librarycards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Librarycards_LibraryCardId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "LibraryCardId",
                table: "Books",
                newName: "LibrarycardId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_LibraryCardId",
                table: "Books",
                newName: "IX_Books_LibrarycardId");

            migrationBuilder.AlterColumn<int>(
                name: "LibrarycardId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Librarycards_LibrarycardId",
                table: "Books",
                column: "LibrarycardId",
                principalTable: "Librarycards",
                principalColumn: "Id");
        }
    }
}

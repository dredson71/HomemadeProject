using Microsoft.EntityFrameworkCore.Migrations;

namespace Uweek.Migrations
{
    public partial class AddingSongGenderAuthorToNewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Authors_AuthorId",
                table: "Songs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genders_GenderId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IdAuthor",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IdGender",
                table: "Songs");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Authors_AuthorId",
                table: "Songs",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genders_GenderId",
                table: "Songs",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Authors_AuthorId",
                table: "Songs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genders_GenderId",
                table: "Songs");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Songs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Songs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdAuthor",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGender",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Authors_AuthorId",
                table: "Songs",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genders_GenderId",
                table: "Songs",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

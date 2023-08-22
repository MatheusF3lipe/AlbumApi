using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumApi.Migrations
{
    /// <inheritdoc />
    public partial class Ajudadeus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musica_album_AlbumId",
                table: "musica");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "musica",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_musica_album_AlbumId",
                table: "musica",
                column: "AlbumId",
                principalTable: "album",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musica_album_AlbumId",
                table: "musica");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "musica",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_musica_album_AlbumId",
                table: "musica",
                column: "AlbumId",
                principalTable: "album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

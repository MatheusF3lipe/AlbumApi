using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumApi.Migrations
{
    /// <inheritdoc />
    public partial class Correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musica_album_Id",
                table: "Musica");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Musica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Musica",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musica_AlbumId",
                table: "Musica",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musica_album_AlbumId",
                table: "Musica",
                column: "AlbumId",
                principalTable: "album",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musica_album_AlbumId",
                table: "Musica");

            migrationBuilder.DropIndex(
                name: "IX_Musica_AlbumId",
                table: "Musica");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Musica");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Musica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Musica_album_Id",
                table: "Musica",
                column: "Id",
                principalTable: "album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

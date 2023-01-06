using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class MeuNovoCampoCarros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_carro",
                table: "pedidos",
                type: "integer not null",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "integer not null",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_carro",
                table: "pedidos",
                type: "integer not null",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer not null")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

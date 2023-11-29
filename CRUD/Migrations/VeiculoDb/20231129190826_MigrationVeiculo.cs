using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUD.Migrations.VeiculoDb
{
    /// <inheritdoc />
    public partial class MigrationVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Chassi = table.Column<string>(type: "TEXT", nullable: true),
                    Cor = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Anofabricacao = table.Column<string>(name: "Ano_fabricacao", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Veiculo",
                columns: new[] { "Id", "Ano_fabricacao", "Chassi", "Cor", "Modelo", "Placa" },
                values: new object[,]
                {
                    { 1001, "10-12-2201", "12345678901234567", "Azul", "Fusca", "ABC-1234" },
                    { 1002, "10-12-2201", "1241234kc21c243c421", "Vermelho", "Fusca", "CDC-3213" },
                    { 1003, "10-12-2201", "124134kc24421", "Prata", "Hilux 2.0", "PUB-3213" },
                    { 1004, "10-12-2201", "1241234kc21c243c421", "Vermelho", "Corola", "PWD-2313" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}

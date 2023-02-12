using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeTournament.Migrations
{
    /// <inheritdoc />
    public partial class PokeList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListPokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokeAtk = table.Column<int>(type: "int", nullable: false),
                    PokeHp = table.Column<int>(type: "int", nullable: false),
                    PokeDef = table.Column<int>(type: "int", nullable: false),
                    PokeSpd = table.Column<int>(type: "int", nullable: false),
                    PokeAvg = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListPokemon", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListPokemon");
        }
    }
}

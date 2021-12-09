using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharSpecies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharOrientation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "SuggestionQuestion",
                columns: table => new
                {
                    QuesSugesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuesSuges = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestionQuestion", x => x.QuesSugesId);
                });

            migrationBuilder.CreateTable(
                name: "Towers",
                columns: table => new
                {
                    TowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TowerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowerRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowerDamage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowerDescript = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towers", x => x.TowerId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CharGender", "CharName", "CharOrientation", "CharSpecies", "Description", "Image" },
                values: new object[,]
                {
                    { 1, "Genderfluid", "Philomena", "Pansexual", "Young Spirit", "A blood hungry and violent spirit.", "images/Philomena.png" },
                    { 2, "Non-Binary, Masculine Leaning", "Rocket", "Pansexual, Monogamous", "Middle-aged Spirit", "An upbeat and jovial spirit", "images/Rocket.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SuggestionQuestion",
                columns: new[] { "QuesSugesId", "Name", "QuesSuges", "Subject" },
                values: new object[,]
                {
                    { 1, "John", "It has great potential!", "Your Game" },
                    { 2, "NarutoRockz", "when?", "cat girls" }
                });

            migrationBuilder.InsertData(
                table: "Towers",
                columns: new[] { "TowerId", "TowerDamage", "TowerDescript", "TowerName", "TowerRange", "TowerType" },
                values: new object[,]
                {
                    { 1, "Physical", "This tower perodically releases trained soldiers to block the way of oncoming enemies. It has a cooldown timer roughly 45 seconds long", "Philomena", "Close", "Barracks" },
                    { 2, "Magic", "This tower periodcally shoots enemies with magical attacks(unspecified and undecided at this time) they have to charge up attacks but are otherwise a basic tower. They have a 8 second cooldown timer", "Rocket", "Long", "Ranged" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "SuggestionQuestion");

            migrationBuilder.DropTable(
                name: "Towers");
        }
    }
}

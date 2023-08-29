using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMO_Gear_Comparison_App.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemLevel = table.Column<int>(type: "int", nullable: false),
                    DamageScaling = table.Column<int>(type: "int", nullable: true),
                    ArmorScaling = table.Column<int>(type: "int", nullable: true),
                    PrimaryStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryStatScaling = table.Column<int>(type: "int", nullable: true),
                    SecondaryStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryStatScaling = table.Column<int>(type: "int", nullable: true),
                    Durability = table.Column<int>(type: "int", nullable: true),
                    GearSlot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gears", x => x.ItemID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gears");
        }
    }
}

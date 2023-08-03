using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMO_Gear_Comparison_App.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    ItemID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemLevel = table.Column<int>(type: "int", nullable: false),
                    DamageScaling = table.Column<int>(type: "int", nullable: true),
                    ArmorScaling = table.Column<int>(type: "int", nullable: true),
                    primaryStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primaryStatScaling = table.Column<int>(type: "int", nullable: true),
                    secondaryStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondaryStatScaling = table.Column<int>(type: "int", nullable: true),
                    durability = table.Column<int>(type: "int", nullable: true),
                    GearSlot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

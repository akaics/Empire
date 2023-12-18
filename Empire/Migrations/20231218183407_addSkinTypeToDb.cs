using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empire.Migrations
{
    /// <inheritdoc />
    public partial class addSkinTypeToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bruger");

            migrationBuilder.DropTable(
                name: "SalgsOpslag");

            migrationBuilder.DropTable(
                name: "Søgekriterier");

            migrationBuilder.CreateTable(
                name: "SkinType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkinItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false),
                    SkinTypeId = table.Column<int>(type: "int", nullable: false),
                    SkinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkinItem_SkinType_SkinTypeId",
                        column: x => x.SkinTypeId,
                        principalTable: "SkinType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkinItem_Skin_SkinId",
                        column: x => x.SkinId,
                        principalTable: "Skin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkinItem_SkinId",
                table: "SkinItem",
                column: "SkinId");

            migrationBuilder.CreateIndex(
                name: "IX_SkinItem_SkinTypeId",
                table: "SkinItem",
                column: "SkinTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkinItem");

            migrationBuilder.DropTable(
                name: "SkinType");

            migrationBuilder.CreateTable(
                name: "Bruger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdgangsKode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrugerNavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bruger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalgsOpslag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrugerId = table.Column<int>(type: "int", nullable: false),
                    OprettelsesDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalgsOpslag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Søgekriterier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkinNavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VåbenType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Søgekriterier", x => x.Id);
                });
        }
    }
}

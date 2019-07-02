using Microsoft.EntityFrameworkCore.Migrations;

namespace tftWEB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Gold = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ChampionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChampionClass_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChampionOrigin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OriginId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ChampionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionOrigin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChampionOrigin_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemRelations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PreviousItem1Id = table.Column<int>(nullable: true),
                    PreviousItem2Id = table.Column<int>(nullable: true),
                    NextItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemRelations_Items_NextItemId",
                        column: x => x.NextItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRelations_Items_PreviousItem1Id",
                        column: x => x.PreviousItem1Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemRelations_Items_PreviousItem2Id",
                        column: x => x.PreviousItem2Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampionClass_ChampionId",
                table: "ChampionClass",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionOrigin_ChampionId",
                table: "ChampionOrigin",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRelations_NextItemId",
                table: "ItemRelations",
                column: "NextItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRelations_PreviousItem1Id",
                table: "ItemRelations",
                column: "PreviousItem1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRelations_PreviousItem2Id",
                table: "ItemRelations",
                column: "PreviousItem2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionClass");

            migrationBuilder.DropTable(
                name: "ChampionOrigin");

            migrationBuilder.DropTable(
                name: "ItemRelations");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}

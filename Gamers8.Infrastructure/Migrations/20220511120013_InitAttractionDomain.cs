using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gamers8.Infrastructure.Migrations
{
    public partial class InitAttractionDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attractions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AttractionCategory = table.Column<byte>(type: "tinyint", nullable: false),
                    DefaultImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SeasonZone = table.Column<byte>(type: "tinyint", nullable: false),
                    DateTime_Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTime_End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpeningTimesAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OpeningTimesEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AgeGroupFrom = table.Column<int>(type: "int", nullable: false),
                    IncludedInEntranceTicket = table.Column<bool>(type: "bit", nullable: false),
                    RequiresSignup = table.Column<bool>(type: "bit", nullable: false),
                    IsFeaturedEvent = table.Column<bool>(type: "bit", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttractionTag",
                columns: table => new
                {
                    AttractionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttractionTag", x => new { x.AttractionsId, x.TagsName });
                    table.ForeignKey(
                        name: "FK_AttractionTag_Attractions_AttractionsId",
                        column: x => x.AttractionsId,
                        principalTable: "Attractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttractionTag_Tags_TagsName",
                        column: x => x.TagsName,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalleryItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttractionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryItems_Attractions_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "Attractions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_IsActive",
                table: "Attractions",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_AttractionTag_TagsName",
                table: "AttractionTag",
                column: "TagsName");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItems_AttractionId",
                table: "GalleryItems",
                column: "AttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItems_IsActive",
                table: "GalleryItems",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItems_ItemName",
                table: "GalleryItems",
                column: "ItemName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttractionTag");

            migrationBuilder.DropTable(
                name: "GalleryItems");

            migrationBuilder.DropTable(
                name: "Attractions");
        }
    }
}

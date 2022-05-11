using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gamers8.Infrastructure.Migrations
{
    public partial class InitDbWithSummitDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SummitDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummitDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DefaultImagePathAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DefaultImagePathEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SeasonZone = table.Column<byte>(type: "tinyint", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "Date", nullable: true),
                    EndingDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ProgramFilePathAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ProgramFilePathEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AgeGroupFrom = table.Column<byte>(type: "tinyint", nullable: true),
                    RequireSignup = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsIncludedInEntranceTicket = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsFeaturedEvent = table.Column<bool>(type: "bit", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SummitSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonZone = table.Column<byte>(type: "tinyint", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummitSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    JobTitleAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JobTitleEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployerAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployerEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    BriefAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BriefEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LinkedInProfile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SocialMediaProfile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speakers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SummitTag",
                columns: table => new
                {
                    SummitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummitTag", x => new { x.SummitsId, x.TagsName });
                    table.ForeignKey(
                        name: "FK_SummitTag_Summits_SummitsId",
                        column: x => x.SummitsId,
                        principalTable: "Summits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummitTag_Tags_TagsName",
                        column: x => x.TagsName,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakerSummit",
                columns: table => new
                {
                    SpeakersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SummitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakerSummit", x => new { x.SpeakersId, x.SummitsId });
                    table.ForeignKey(
                        name: "FK_SpeakerSummit_Speakers_SpeakersId",
                        column: x => x.SpeakersId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeakerSummit_Summits_SummitsId",
                        column: x => x.SummitsId,
                        principalTable: "Summits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsActive",
                table: "Countries",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_CountryId",
                table: "Speakers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_IsActive",
                table: "Speakers",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakerSummit_SummitsId",
                table: "SpeakerSummit",
                column: "SummitsId");

            migrationBuilder.CreateIndex(
                name: "IX_SummitDays_IsActive",
                table: "SummitDays",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Summits_IsActive",
                table: "Summits",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_SummitSessions_IsActive",
                table: "SummitSessions",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_SummitTag_TagsName",
                table: "SummitTag",
                column: "TagsName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeakerSummit");

            migrationBuilder.DropTable(
                name: "SummitDays");

            migrationBuilder.DropTable(
                name: "SummitSessions");

            migrationBuilder.DropTable(
                name: "SummitTag");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Summits");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

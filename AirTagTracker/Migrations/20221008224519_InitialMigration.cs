using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirTagTracker.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "UploadSessions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeDataAccessed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeDataLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirTagDatas",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadSessionAirTagDatasId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirTagDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirTagDatas_UploadSessions_UploadSessionAirTagDatasId",
                        column: x => x.UploadSessionAirTagDatasId,
                        principalSchema: "dbo",
                        principalTable: "UploadSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirTagDatas_UploadSessionAirTagDatasId",
                schema: "dbo",
                table: "AirTagDatas",
                column: "UploadSessionAirTagDatasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirTagDatas",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UploadSessions",
                schema: "dbo");
        }
    }
}

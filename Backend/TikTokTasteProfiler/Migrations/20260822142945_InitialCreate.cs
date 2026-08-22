using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TikTokTasteProfiler.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Followers = table.Column<int>(type: "integer", nullable: false),
                    Following = table.Column<int>(type: "integer", nullable: false),
                    IsPrivate = table.Column<bool>(type: "boolean", nullable: false),
                    Handle = table.Column<string>(type: "text", nullable: false),
                    LastScraped = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reposts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountID = table.Column<int>(type: "integer", nullable: false),
                    CreatorFollowers = table.Column<int>(type: "integer", nullable: false),
                    VideoID = table.Column<string>(type: "text", nullable: false),
                    CreatorID = table.Column<string>(type: "text", nullable: false),
                    CreatorHandle = table.Column<string>(type: "text", nullable: false),
                    Likes = table.Column<int>(type: "integer", nullable: false),
                    Shares = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<int>(type: "integer", nullable: false),
                    VideoURL = table.Column<string>(type: "text", nullable: false),
                    Audio = table.Column<string>(type: "text", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: false),
                    PostDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Hashtags = table.Column<List<string>>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reposts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reposts_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TasteProfiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountID = table.Column<int>(type: "integer", nullable: false),
                    RepostsAnalyzed = table.Column<int>(type: "integer", nullable: false),
                    Likes = table.Column<List<string>>(type: "text[]", nullable: false),
                    Points = table.Column<List<string>>(type: "text[]", nullable: false),
                    Caveats = table.Column<List<string>>(type: "text[]", nullable: false),
                    Dislikes = table.Column<List<string>>(type: "text[]", nullable: false),
                    Preferences = table.Column<List<string>>(type: "text[]", nullable: false),
                    GeneratedAtUTC = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasteProfiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TasteProfiles_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Handle",
                table: "Accounts",
                column: "Handle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reposts_AccountID",
                table: "Reposts",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TasteProfiles_AccountID",
                table: "TasteProfiles",
                column: "AccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reposts");

            migrationBuilder.DropTable(
                name: "TasteProfiles");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccess.Migrations
{
    public partial class update_relation_in_team_and_player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_PlayerID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PlayerID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "TeamsID",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamsID",
                table: "Players",
                column: "TeamsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamsID",
                table: "Players",
                column: "TeamsID",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamsID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamsID",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamsID",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PlayerID",
                table: "Teams",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_PlayerID",
                table: "Teams",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

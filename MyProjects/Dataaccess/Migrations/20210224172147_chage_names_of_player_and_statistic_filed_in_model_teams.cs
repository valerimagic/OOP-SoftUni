using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccess.Migrations
{
    public partial class chage_names_of_player_and_statistic_filed_in_model_teams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_PlayerIDID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Statistics_StatisticIDID",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "StatisticIDID",
                table: "Teams",
                newName: "StatisticID");

            migrationBuilder.RenameColumn(
                name: "PlayerIDID",
                table: "Teams",
                newName: "PlayerID");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_StatisticIDID",
                table: "Teams",
                newName: "IX_Teams_StatisticID");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_PlayerIDID",
                table: "Teams",
                newName: "IX_Teams_PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_PlayerID",
                table: "Teams",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Statistics_StatisticID",
                table: "Teams",
                column: "StatisticID",
                principalTable: "Statistics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_PlayerID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Statistics_StatisticID",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "StatisticID",
                table: "Teams",
                newName: "StatisticIDID");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "Teams",
                newName: "PlayerIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_StatisticID",
                table: "Teams",
                newName: "IX_Teams_StatisticIDID");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_PlayerID",
                table: "Teams",
                newName: "IX_Teams_PlayerIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_PlayerIDID",
                table: "Teams",
                column: "PlayerIDID",
                principalTable: "Players",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Statistics_StatisticIDID",
                table: "Teams",
                column: "StatisticIDID",
                principalTable: "Statistics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

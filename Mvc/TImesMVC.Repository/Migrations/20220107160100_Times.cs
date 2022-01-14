using Microsoft.EntityFrameworkCore.Migrations;

namespace TimesMVC.Repository.Migrations
{
    public partial class Times : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskTimes");

            migrationBuilder.AddColumn<string>(
                name: "Rival",
                table: "Time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Titulos",
                table: "Time",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Time_TimeId",
                table: "Time",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Time_TimeId",
                table: "Time",
                column: "TimeId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Time_Time_TimeId",
                table: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Time_TimeId",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "Rival",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "Titulos",
                table: "Time");

            migrationBuilder.CreateTable(
                name: "TaskTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rival = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeId = table.Column<int>(type: "int", nullable: true),
                    Titulos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTimes_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskTimes_TimeId",
                table: "TaskTimes",
                column: "TimeId");
        }
    }
}

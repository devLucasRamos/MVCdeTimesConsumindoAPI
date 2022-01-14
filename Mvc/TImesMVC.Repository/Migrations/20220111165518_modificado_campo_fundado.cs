using Microsoft.EntityFrameworkCore.Migrations;

namespace TimesMVC.Repository.Migrations
{
    public partial class modificado_campo_fundado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Time_Time_TimeId",
                table: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Time_TimeId",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Time");

            migrationBuilder.AlterColumn<int>(
                name: "Fundado",
                table: "Time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fundado",
                table: "Time",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Time",
                type: "int",
                nullable: true);

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBackTask.Migrations
{
    public partial class CardChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Cards",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}

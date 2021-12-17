using Microsoft.EntityFrameworkCore.Migrations;

namespace _01_EF_Enviroment.Migrations
{
    public partial class AddBirthPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "T_Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "T_Persons");
        }
    }
}

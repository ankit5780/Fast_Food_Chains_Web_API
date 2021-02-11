using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace Fast_Food_Chains_Web_API.Migrations
{
    public partial class food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FastFoodChain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revenue = table.Column<int>(type: "int", nullable: false),
                    Employees = table.Column<int>(type: "int", nullable: false),
                    EstablishedYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastFoodChain", x => x.Id);
                });
            var sqlFile = Path.Combine(".\\DatabaseScripts", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FastFoodChain");
        }
    }
}

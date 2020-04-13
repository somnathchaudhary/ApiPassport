using Microsoft.EntityFrameworkCore.Migrations;

namespace PasportDetails.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PDetails",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHolderName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PPNumber = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    PPExp = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    PPOCode = table.Column<string>(type: "nvarchar(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDetails", x => x.PId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PDetails");
        }
    }
}

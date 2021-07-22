using Microsoft.EntityFrameworkCore.Migrations;

namespace Advertisement_WebAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Job_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "job");
        }
    }
}

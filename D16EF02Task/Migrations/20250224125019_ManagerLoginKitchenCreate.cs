using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D16EF02Task.Migrations
{
    /// <inheritdoc />
    public partial class ManagerLoginKitchenCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManagerLoginKitchen",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLoginKitchen", x => x.Username);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerLoginKitchen");
        }
    }
}

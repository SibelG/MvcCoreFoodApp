using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Shop.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Catgories_CategoryId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catgories",
                table: "Catgories");

            migrationBuilder.RenameTable(
                name: "Catgories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catgories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catgories",
                table: "Catgories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Catgories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Catgories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

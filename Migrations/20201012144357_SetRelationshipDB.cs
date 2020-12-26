using Microsoft.EntityFrameworkCore.Migrations;

namespace LibManage.Migrations
{
    public partial class SetRelationshipDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Author",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookTpye",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Publisher",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearPublished",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author",
                table: "Books",
                column: "Author");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookTpye",
                table: "Books",
                column: "BookTpye");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Publisher",
                table: "Books",
                column: "Publisher");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_authors_Author",
                table: "Books",
                column: "Author",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_bookTpyes_BookTpye",
                table: "Books",
                column: "BookTpye",
                principalTable: "bookTpyes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publishers_Publisher",
                table: "Books",
                column: "Publisher",
                principalTable: "publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_authors_Author",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_bookTpyes_BookTpye",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_publishers_Publisher",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Author",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookTpye",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Publisher",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookTpye",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "YearPublished",
                table: "Books");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LibManage.Migrations
{
    public partial class update_table_order_add_userverify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserverifyId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserverifyId",
                table: "Orders",
                column: "UserverifyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserverifyId",
                table: "Orders",
                column: "UserverifyId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserverifyId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserverifyId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserverifyId",
                table: "Orders");
        }
    }
}

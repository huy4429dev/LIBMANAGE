using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LibManage.Migrations
{
    public partial class add_rule_fee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.CreateTable(
                name: "RuleFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleFees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderRuleFee",
                columns: table => new
                {
                    RoleFeeId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<int>(type: "integer", nullable: false),
                    TotalFee = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRuleFee", x => new { x.RoleFeeId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderRuleFee_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRuleFee_RuleFees_RoleFeeId",
                        column: x => x.RoleFeeId,
                        principalTable: "RuleFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RuleFees",
                columns: new[] { "Id", "Description", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Mất tài liệu hoặc làm cho tài liệu hoàn toàn không sử dụng được: giá bìa của cuốn sách + 20$ phí phạt", "LOL 1", 100 },
                    { 2, "Làm bẩn, viết vẽ bẩn lên tài liệu: 10$/tờ", "LOL 2", 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderRuleFee_OrderId",
                table: "OrderRuleFee",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderRuleFee");

            migrationBuilder.DropTable(
                name: "RuleFees");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });
        }
    }
}

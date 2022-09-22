using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.Migrations
{
    public partial class createmaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Master",
                schema: "Cor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExpenseId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Master_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "Cor",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Master_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalSchema: "Cor",
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Master_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Cor",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Master_AccountId",
                schema: "Cor",
                table: "Master",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Master_ExpenseId",
                schema: "Cor",
                table: "Master",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Master_UserId",
                schema: "Cor",
                table: "Master",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Master",
                schema: "Cor");
        }
    }
}

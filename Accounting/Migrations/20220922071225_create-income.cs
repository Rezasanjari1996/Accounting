using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.Migrations
{
    public partial class createincome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IncomeId",
                schema: "Cor",
                table: "Diposits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Incomes",
                schema: "Cor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_Incomes_IncomeId",
                        column: x => x.IncomeId,
                        principalSchema: "Cor",
                        principalTable: "Incomes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diposits_IncomeId",
                schema: "Cor",
                table: "Diposits",
                column: "IncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_IncomeId",
                schema: "Cor",
                table: "Incomes",
                column: "IncomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diposits_Incomes_IncomeId",
                schema: "Cor",
                table: "Diposits",
                column: "IncomeId",
                principalSchema: "Cor",
                principalTable: "Incomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diposits_Incomes_IncomeId",
                schema: "Cor",
                table: "Diposits");

            migrationBuilder.DropTable(
                name: "Incomes",
                schema: "Cor");

            migrationBuilder.DropIndex(
                name: "IX_Diposits_IncomeId",
                schema: "Cor",
                table: "Diposits");

            migrationBuilder.DropColumn(
                name: "IncomeId",
                schema: "Cor",
                table: "Diposits");
        }
    }
}

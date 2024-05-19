using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToExpenseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    IncomeMonthly = table.Column<double>(type: "REAL", nullable: false),
                    ExpenseMonthly = table.Column<double>(type: "REAL", nullable: false),
                    SaveMonthly = table.Column<double>(type: "REAL", nullable: false),
                    SaveGoalMonthly = table.Column<double>(type: "REAL", nullable: false),
                    is_Main = table.Column<bool>(type: "INTEGER", nullable: false),
                    BudgetModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budgets_Budgets_BudgetModelId",
                        column: x => x.BudgetModelId,
                        principalTable: "Budgets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PriceTarget = table.Column<double>(type: "REAL", nullable: false),
                    AmountCollected = table.Column<double>(type: "REAL", nullable: false),
                    BudgetModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingTargets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingTargets_Budgets_BudgetModelId",
                        column: x => x.BudgetModelId,
                        principalTable: "Budgets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    CategoryExpenseModelId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_CategoryExpenses_CategoryExpenseModelId",
                        column: x => x.CategoryExpenseModelId,
                        principalTable: "CategoryExpenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_BudgetModelId",
                table: "Budgets",
                column: "BudgetModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CategoryExpenseModelId",
                table: "Expenses",
                column: "CategoryExpenseModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingTargets_BudgetModelId",
                table: "SavingTargets",
                column: "BudgetModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "SavingTargets");

            migrationBuilder.DropTable(
                name: "CategoryExpenses");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}

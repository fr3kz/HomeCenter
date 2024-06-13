using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingTargets_Budgets_BudgetModelId",
                table: "SavingTargets");

            migrationBuilder.AlterColumn<int>(
                name: "BudgetModelId",
                table: "SavingTargets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingTargets_Budgets_BudgetModelId",
                table: "SavingTargets",
                column: "BudgetModelId",
                principalTable: "Budgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingTargets_Budgets_BudgetModelId",
                table: "SavingTargets");

            migrationBuilder.AlterColumn<int>(
                name: "BudgetModelId",
                table: "SavingTargets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_SavingTargets_Budgets_BudgetModelId",
                table: "SavingTargets",
                column: "BudgetModelId",
                principalTable: "Budgets",
                principalColumn: "Id");
        }
    }
}

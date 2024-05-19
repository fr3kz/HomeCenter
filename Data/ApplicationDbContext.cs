using HomeCenter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeCenter.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<BudgetModel> Budgets { get; set; }
    public DbSet<CategoryExpenseModel> CategoryExpenses { get; set; }
    public DbSet<ExpenseModel> Expenses { get; set; }
    public DbSet<SavingTargetModel> SavingTargets { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ExpenseModel>()
            .HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId);
    }
}
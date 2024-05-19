namespace HomeCenter.Models;
using System.ComponentModel.DataAnnotations;

public class BudgetModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Amount { get; set; }
    public double IncomeMonthly { get; set; }
    public double ExpenseMonthly { get; set; }
    public List<BudgetModel> Expenses{ get; set; }
    public double SaveMonthly { get; set; }
    public double SaveGoalMonthly { get; set; }
    public List<SavingTargetModel> SavingTargets { get; set; }
    public bool is_Main { get; set; }
    
    
    
}
using System.ComponentModel.DataAnnotations;

namespace HomeCenter.Models;

public class CategoryExpenseModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ExpenseModel> Expenses { get; set; }
}
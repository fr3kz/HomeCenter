using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HomeCenter.Models;

public class ExpenseModel
{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        
        public int CategoryExpenseModelId { get; set; }
        public CategoryExpenseModel CategoryExpenseModel { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public DateTime DateTime { get; set; }
}
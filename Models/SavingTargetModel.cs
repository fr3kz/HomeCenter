using System.ComponentModel.DataAnnotations;

namespace HomeCenter.Models;

public class SavingTargetModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double PriceTarget { get; set; }
    public double AmountCollected { get; set; }
    
}
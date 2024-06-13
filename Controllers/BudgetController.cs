using HomeCenter.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeCenter.Controllers;

public class BudgetController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _context;

    private readonly UserManager<IdentityUser> _userManager;

    public BudgetController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    // GET
    public IActionResult Budget()
    {
        var Budget = _context.Budgets.ToListAsync();
        return View(Budget);
    }

    public IActionResult BudgetDetail(int id)
    {
       /* var Budget =  _context.Budgets.FirstOrDefault(m => m.Id == id);

        if (Budget == null)
        {
            return NotFound();
        }*/
        return View();
    }

    public IActionResult CreateBudget()
    {
        return View();
    }
    
    
    //Todo: dodanie tutaj api aby mozna bylo usuwac bez wchodzenia w widok
    
}
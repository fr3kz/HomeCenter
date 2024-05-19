using HomeCenter.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        return View();
    }
    
}
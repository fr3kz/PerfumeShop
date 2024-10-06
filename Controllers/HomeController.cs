using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PerfumeShop.Migrations;
using PerfumeShop.Models;

namespace PerfumeShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDBcontext _context;

    public HomeController(ILogger<HomeController> logger,ApplicationDBcontext context)
    {
        
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
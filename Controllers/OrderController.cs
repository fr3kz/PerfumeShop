using Microsoft.AspNetCore.Mvc;
using PerfumeShop.Migrations;
using PerfumeShop.Models;

namespace PerfumeShop.Controllers;

public class OrderController: Controller
{
    private  readonly ILogger<OrderController> _logger;
    private readonly ApplicationDBcontext _context;

    public OrderController(ILogger<OrderController> logger, ApplicationDBcontext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult CreateOrder(int productId)
    {
        //1 sprawdzenie czy user nie ma w cookies innego zamowienia
        if (Request.Cookies["OrderID"] == null)
        {
            //TODO: Create order
            
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append("OrderId", productId.ToString(), options);
        }
        //2 utworzenie zamowienia i dodanie produktu do cookies'
        
        return Redirect($"Home/Index");
    }
    
}
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using PerfumeShop.Migrations;
using PerfumeShop.Models.utils;

namespace PerfumeShop.Controllers;

public class AuthController: Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDBcontext _context;
    
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;



    public AuthController(ILogger<HomeController> logger, ApplicationDBcontext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }


    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt");    
            
        }
        
        return View(model);
    }

    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");

                await _signInManager.SignInAsync(user, true);
                return RedirectToAction("Index", "Home");

            }

            if (!result.Succeeded)
            {
                _logger.LogError(result.Errors.FirstOrDefault().Description.ToString());
            }
            
        }

        
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TikTakToe.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Index action method called.");
        return View();
    }
}
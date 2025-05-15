using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using website.Models;

namespace website.Controllers;

public class enController : Controller
{
    private readonly ILogger<enController> _logger;

    public enController(ILogger<enController> logger)
    {
        _logger = logger;
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
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using website.Models;

namespace website.Controllers;

public class nlController : Controller
{
    private readonly ILogger<nlController> _logger;

    public nlController(ILogger<nlController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogTrace("NL Index requested");
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogTrace("NL Privacy requested");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogTrace("Error requested");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
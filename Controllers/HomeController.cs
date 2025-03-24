using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalPage.Models;
using PersonalPage.Services;

namespace PersonalPage.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CVService _cvService;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _cvService = new CVService();
    }

    public IActionResult Index()
    {
        var cv = _cvService.GetCV();
        return View(cv);
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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DILifetimesSample.Models;
using DILifetimesSample.Services;

namespace DILifetimesSample.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    ITransientService _transientService1;
    ITransientService _transientService2;

    public HomeController(ILogger<HomeController> logger,
        ITransientService transientService1,
        ITransientService transientService2
        )
    {
        _logger = logger;
        _transientService1 = transientService1;
        _transientService2 = transientService2;
    }

    public IActionResult Index()
    {
        ViewBag.message1 = $"First Instance {_transientService1.GetID().ToString()}";
        ViewBag.message2 = $"Second Instance {_transientService2.GetID().ToString()}";

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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult AboutMe()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}

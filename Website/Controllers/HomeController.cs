using System.Diagnostics;
using DatabaseAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Website.Infrastructure;
using Website.Models;

namespace Website.Controllers;

public class HomeController : BaseController
{
    private readonly Database _database;

    public HomeController(Database database)
    {
        _database = database;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
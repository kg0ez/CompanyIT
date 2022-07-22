using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Company.Models;

namespace Company.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }


}


using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LikeToDo.Models;

namespace LikeToDo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var viewModel = new IndexViewModel
        {
            Tasks = Data.GetMockTasks(),
            Categories = Data.GetMockCategories(),
            CurrentPage = 1,
            TotalPages = 1
        };

        return View(viewModel);
    }

    public IActionResult Description()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

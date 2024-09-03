using Microsoft.AspNetCore.Mvc;

namespace sed.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();

    [HttpGet]
    public IActionResult About() => View();


}
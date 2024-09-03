using Microsoft.AspNetCore.Mvc;

namespace sed.Controllers;

public class OtherController : Controller
{
    [HttpGet]
    public IActionResult Result() => View();

    [HttpGet]
    public IActionResult Other() => View();


}
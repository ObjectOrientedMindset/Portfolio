using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using final.Models;

namespace final.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
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

  [HttpPost]
  public IActionResult SendMessage(string name, string email, string message)
  {
    //Save data to DB here ...
    Message msg = new(name, email, message);
    System.Console.WriteLine($"Name : {msg.Name} \nEmail : {msg.Email} \nMessage : {msg.Text}");

    return View("Index", msg);
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}

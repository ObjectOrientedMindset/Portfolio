using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using final.Models;
using Npgsql;


namespace final.Controllers;

public class HomeController : Controller
{
  // Access connection string
  private List<Message> messages;

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
    //database connection
    NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Db=Portfolio; user ID=postgres; password=postgres");
    con.Open();
    //insert into messages
    string sql = "INSERT INTO messages (name, email, message)VALUES('" + msg.Name + "','" + msg.Email + "','" + msg.Text + "')";
    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
    try
    {
      cmd.ExecuteNonQuery();
    }
    catch (System.Exception)
    {

      System.Console.WriteLine("HomeController(insert into messages failed!)");
    }
    con.Close();

    return View("Index", msg);
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}

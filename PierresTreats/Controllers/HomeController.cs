using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Linq;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;
    public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treat = _db.Treats.ToList();
      ViewBag.Flavor = _db.Flavors.ToList();
      return View();
    }

  }
}
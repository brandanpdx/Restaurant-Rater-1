using Microsoft.AspNetCore.Mvc;

namespace RestaurantRater.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
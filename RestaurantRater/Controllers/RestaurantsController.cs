using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    [HttpGet("/restaurants")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
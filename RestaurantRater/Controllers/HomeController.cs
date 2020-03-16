using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Home()
    {
      return View();
    }
  }
}
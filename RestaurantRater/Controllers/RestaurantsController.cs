using Microsoft.AspNetCore.Mvc;
using RestaurantRater.Models;
using System.Collections.Generic;

namespace RestaurantRater.Controllers
{
  public class RestaurantsController : Controller
  {
    [HttpGet("/restaurants")]
    public ActionResult Index()
    {
      List<Restaurant> allRestaurants = Restaurant.GetAll();
      return View(allRestaurants);
    }

    [HttpGet("/restaurants/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/restaurants")]
    public ActionResult Create(string restaurantName)
    {
      Restaurant newRestaurant = new Restaurant(restaurantName);
      newRestaurant.Save();
      return RedirectToAction("Index");
    }
  }
}
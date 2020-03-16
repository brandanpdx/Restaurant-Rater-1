using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace RestaurantRater.Models
{
  public class Restaurant
  {
    public string RestaurantName { get; set; }
    public int Id { get; set; }
 
    public Restaurant(string restaurantName)
    {
      RestaurantName = restaurantName;
    } 

    public static List<Restaurant> GetAll()
    {
      List<Restaurant> allRestaurants = new List<Restaurant> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM restaurants;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        string restaurantName = rdr.GetString(0);
        Restaurant newRestaurant = new Restaurant(restaurantName);
        allRestaurants.Add(newRestaurant);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allRestaurants;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = @"INSERT INTO restaurants(name) VALUES (@RestaurantName);";
      MySqlParameter description = new MySqlParameter();
      description.ParameterName = "@RestaurantName";
      description.Value = this.RestaurantName;
      cmd.Parameters.Add(description);
      cmd.ExecuteNonQuery();
      Id = (int)cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
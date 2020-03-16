using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Restaurant.Models
{
  public class Restaurant
  {
    public string RestaurantName { get; set; }
    public int Id { get; set; }
 
    public Restaurant(string restaurantName)
    {
      RestaurantName = restaurantName;
    } 

  public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = @"INSERT INTO restaurant(name) VALUES (@RestaurantName);";
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
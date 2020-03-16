using System;
using MySql.Data.MySqlClient;
using RestaurantRater;

namespace RestaurantRater.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
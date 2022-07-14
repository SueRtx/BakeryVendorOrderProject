using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set;}
    private static List<Order> _instances = new List<Order> { };
    public Order(string description, string price, string date)
    {
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
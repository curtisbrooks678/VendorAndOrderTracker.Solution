// Properties for Order:
// - Title
// - Description of Order
// - Price
// - Date

using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description { get; set;}
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public Order(string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}
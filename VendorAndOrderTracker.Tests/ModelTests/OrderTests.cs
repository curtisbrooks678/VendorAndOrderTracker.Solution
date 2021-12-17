using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test Order Title";
      string description = "Test Order Description";
      int price = 0;
      string date = "Test Order Date";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Test Order Title";
      string description = "Test Order Description";
      int price = 0;
      string date = "Test Order Date";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string title = "Test Order Title";
      string description = "Test Order Description";
      int price = 0;
      string date = "Test Order Date";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string title = "Test Order Title";
      string description = "Test Order Description";
      int price = 0;
      string date = "Test Order Date";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string title = "Test Order Title";
      string description = "Test Order Description";
      int price = 0;
      string date = "Test Order Date";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string title1 = "Test Order1 Title";
      string description1 = "Test Order1 Description";
      int price1 = 0;
      string date1 = "Test Order1 Date";
      string title2 = "Test Order2 Title";
      string description2 = "Test Order2 Description";
      int price2 = 0;
      string date2 = "Test Order2 Date";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "Test Order1 Title";
      string description1 = "Test Order1 Description";
      int price1 = 0;
      string date1 = "Test Order1 Date";
      string title2 = "Test Order2 Title";
      string description2 = "Test Order2 Description";
      int price2 = 0;
      string date2 = "Test Order2 Date";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}
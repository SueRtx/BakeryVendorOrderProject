using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
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
      Order newOrder = new Order("Spoon", "10", "7/14/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Spoon";
      string price = "10";
      string date = "7/14/2022";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_String()
    {
      string description = "Spoon";
      string price = "10";
      string date = "7/14/2022";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string description = "Spoon";
      string price = "10";
      string date = "7/14/2022";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description1 = "Spoon";
      string price1 = "10";
      string date1 = "7/14/2022";
      string description2 = "Fork";
      string price2 = "20";
      string date2 = "7/15/2022";
      Order newOrder1 = new Order(description1, price1, date1);
      Order newOrder2 = new Order(description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
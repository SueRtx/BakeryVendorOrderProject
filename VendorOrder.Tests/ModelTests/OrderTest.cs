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
    public void getPrice_ReturnPrice_String()
    {
      string description = "Spoon";
      string price = "10";
      string date = "7/14/2022";
      Order newOrder = new Order(description, price, date);
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_OrderList()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> { };

    //   // Act
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsOrders_OrderList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Order newOrder1 = new Order(description01);
    //   Order newOrder2 = new Order(description02);
    //   List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //   //Act
    //   List<Order> result = Order.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}
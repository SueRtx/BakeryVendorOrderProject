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

    // [TestMethod]
    // public void OrderConstructor_CreatesInstanceOfOrder_Order()
    // {
    //   Order newOrder = new Order("test");
    //   Assert.AreEqual(typeof(Order), newOrder.GetType());
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";

    //   //Act
    //   Order newOrder = new Order(description);
    //   string result = newOrder.Description;

    //   //Assert
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Order newOrder = new Order(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newOrder.Description = updatedDescription;
    //   string result = newOrder.Description;

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
      public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
      {
        Vendor newVendor = new Vendor("test Vendor","store");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
     //Arrange
      string name = "Test Vendor";
      string description = "Store";
      Vendor newVendor = new Vendor(name, description);

     //Act
      string result = newVendor.Name;

     //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Store";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Vendor Name1";
      string description1 = "Store";
      string name02 = "Vendor Name2";
      string description2 = "Store2";
      Vendor newVendor1 = new Vendor(name01, description1);
      Vendor newVendor2 = new Vendor(name02, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Vendor Name1";
      string description1 = "Store";
      string name02 = "Vendor Name2";
      string description2 = "Store2";
      Vendor newVendor1 = new Vendor(name01, description1);
      Vendor newVendor2 = new Vendor(name02, description2);  
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "flour";
      string price = "10";
      string date = "7/14/2022"; 
      Order newOrder = new Order(description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Store1";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
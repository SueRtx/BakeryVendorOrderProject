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
        Vendor newVendor = new Vendor("test Vendor");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsAllVendorObjects_VendorList()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Vendor newVendor1 = new Vendor(name01);
    //   Vendor newVendor2 = new Vendor(name02);
    //   List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

    //   //Act
    //   List<Vendor> result = Vendor.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectVendor_Vendor()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Vendor newVendor1 = new Vendor(name01);
    //   Vendor newVendor2 = new Vendor(name02);

    //   //Act
    //   Vendor result = Vendor.Find(2);

    //   //Assert
    //   Assert.AreEqual(newVendor2, result);
    // }

    // [TestMethod]
    // public void AddItem_AssociatesItemWithVendor_ItemList()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   List<Item> newList = new List<Item> { newItem };
    //   string name = "Work";
    //   Vendor newVendor = new Vendor(name);
    //   newVendor.AddItem(newItem);

    //   //Act
    //   List<Item> result = newVendor.Items;

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

  }
}
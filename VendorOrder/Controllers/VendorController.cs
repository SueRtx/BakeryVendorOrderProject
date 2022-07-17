using Microsoft.AspNetCore.Mvc;
using System;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Order> vendorOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("order", vendorOrders);
    return View(model);
    }

    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderDescription, string orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("order", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}
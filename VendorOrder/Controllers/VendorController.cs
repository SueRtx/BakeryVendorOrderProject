using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {

    // [HttpGet("/categories/{categoryId}/items/new")]
    // public ActionResult New(int categoryId)
    // {
    //   Category category = Category.Find(categoryId);
    //   return View(category);
    // }

    // [HttpGet("/categories/{categoryId}/items/{itemId}")]
    // public ActionResult Show(int categoryId, int itemId)
    // {
    //   Item item = Item.Find(itemId);
    //   Category category = Category.Find(categoryId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("item", item);
    //   model.Add("category", category);
    //   return View(model);
    // }

    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }

  }
}
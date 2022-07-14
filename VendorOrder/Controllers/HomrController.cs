using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}

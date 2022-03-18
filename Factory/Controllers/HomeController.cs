using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Dr. SillyStringz's Factory";
      //more viewbag items (engineers and machines) viewbag.engineerslist = _db.engineers.tolist
      return View();
    }
  }
}
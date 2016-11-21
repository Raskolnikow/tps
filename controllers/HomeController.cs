using Microsoft.AspNetCore.Mvc;

namespace tps_x.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    { 
      return View();
    }
  }
}

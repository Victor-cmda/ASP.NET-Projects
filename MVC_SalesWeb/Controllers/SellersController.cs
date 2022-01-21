using Microsoft.AspNetCore.Mvc;

namespace MVC_SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

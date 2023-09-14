using Microsoft.AspNetCore.Mvc;

namespace e_Buy.app.Controllers
{
    public class Products : Controller
    {
        public IActionResult OurProducts()
        {
            return View();
        }
    }
}

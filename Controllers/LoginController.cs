using Microsoft.AspNetCore.Mvc;

namespace e_Buy.app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

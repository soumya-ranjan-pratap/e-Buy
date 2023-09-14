using Microsoft.AspNetCore.Mvc;

namespace e_Buy.app.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

		public IActionResult SignUp()
		{
			return View();
		}
	}
}

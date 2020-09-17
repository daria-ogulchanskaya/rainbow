using Microsoft.AspNetCore.Mvc;

namespace Rainbow.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}

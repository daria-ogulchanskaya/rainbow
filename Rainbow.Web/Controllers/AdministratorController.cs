using Microsoft.AspNetCore.Mvc;

namespace Rainbow.Web.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}

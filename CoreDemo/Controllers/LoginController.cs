using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]//Kurallardan muaf.
        public IActionResult Index()
        {
            return View();
        }
    }
}

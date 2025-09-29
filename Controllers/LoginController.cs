using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

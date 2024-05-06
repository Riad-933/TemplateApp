using Microsoft.AspNetCore.Mvc;

namespace TemplateWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}

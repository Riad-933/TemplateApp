using Microsoft.AspNetCore.Mvc;

namespace TemplateWeb.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

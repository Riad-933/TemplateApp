using Microsoft.AspNetCore.Mvc;

namespace TemplateWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

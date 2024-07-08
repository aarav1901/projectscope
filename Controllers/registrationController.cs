using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    public class registrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

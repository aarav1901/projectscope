using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    public class contact : Controller
    {
        public IActionResult page1()
        {
            return View();
        }
    }
}

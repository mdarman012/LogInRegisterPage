using Microsoft.AspNetCore.Mvc;

namespace RegisterLogin.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

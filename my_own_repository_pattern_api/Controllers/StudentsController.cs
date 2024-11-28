using Microsoft.AspNetCore.Mvc;

namespace my_own_repository_pattern_api.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

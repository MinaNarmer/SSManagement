using Microsoft.AspNetCore.Mvc;

namespace SSManagement.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

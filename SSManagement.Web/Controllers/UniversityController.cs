using Microsoft.AspNetCore.Mvc;
using SSManagment.BL.DTOs;
using SSManagment.BL.IServices;

namespace SSManagement.Web.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUniversityService _servise;

        public UniversityController(IUniversityService servise)
        {
            _servise = servise;
        }

        public IActionResult Index()
        {
            var model = _servise.GetList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(UniversityDTO model)
        {
            _servise.Create(model);

            return RedirectToAction("Index");
        }
    }

}

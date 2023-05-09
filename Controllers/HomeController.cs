using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task12.Models;

namespace Task12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonalData personalData)
        {
            if (!ModelState.IsValid)
                return View(personalData);

            var monthOfBirth = (MonthEnum)personalData.DateOfBirth.Month;
            var shortMonth = monthOfBirth.ToString().Substring(0, 3);

            TempData["personName"] = personalData.FirstName + " " + personalData.LastName;
            TempData["personBirthMonth"] = shortMonth;

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
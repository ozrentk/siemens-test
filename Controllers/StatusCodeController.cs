using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Task12.Controllers
{
    public class StatusCodeController : Controller
    {
        [RouteAttribute("/[controller]/[action]/{code}")]
        public IActionResult Error(int code)
        {
            switch(code)
            {
                case 404:
                    return View("NotFound");
                case 500:
                    return View("InternalServerError");
                default:
                    return View();
            }
        }
    }
}

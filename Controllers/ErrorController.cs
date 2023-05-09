using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Task12.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var exceptionHandlerPathFeature =
                HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (exceptionHandlerPathFeature != null)
            {
                ViewData["path"] = exceptionHandlerPathFeature.Path;
                ViewData["errorMessage"] = exceptionHandlerPathFeature.Error.Message;
            }

            return View();
        }
    }
}

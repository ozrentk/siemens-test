using Microsoft.AspNetCore.Mvc;
using Task12.BL.BLModels;
using Task12.BL.Repositories;
using Task12.Models.User;

namespace Task12.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            var users = _userRepo.GetUsers();

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(VMRegister register)
        {
            if(!ModelState.IsValid)
                return View(register);

            // TODO: Save user to database
            var blUser = new BLUser
            {
                Username = register.Username,
                Password = register.Password,
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
            };
            _userRepo.CreateUser(blUser);

            return RedirectToAction("Index");
        }

        public IActionResult ValidateEmail(VMValidateEmail validateEmail)
        {
            // TODO: Update user: e-mail validated

            return View(validateEmail);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(VMLogin login)
        {
            if (!ModelState.IsValid)
                return View(login);

            // TODO: Check user credentials

            if(login.RedirectUrl != null)
                return Redirect(login.RedirectUrl);
            else
                return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            if (!ModelState.IsValid)
                return View();

            // TODO: Logout user

            return RedirectToAction("Login");
        }


        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(VMChangePassword changePassword)
        {
            if (!ModelState.IsValid)
                return View(changePassword);

            // TODO: Change user password

            return RedirectToAction("Index");
        }

    }
}

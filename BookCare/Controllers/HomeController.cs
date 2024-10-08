using BookCare.DAO;
using BookCare.Models;
using BookCare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BookCare.Data;

namespace BookCare.Controllers
{
    public class HomeController : Controller
    {
        private UserDAO _userDAO;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
     
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model) 
        {
            _userDAO = new();
            if (ModelState.IsValid) 
            { 
                if(_userDAO.Authenticate(model.Email, model.Password))
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(model);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class pagesController : Controller
    {
        private readonly ILogger<pagesController> _logger;

        public pagesController(ILogger<pagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult privacy()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }

        public IActionResult loginstudent()
        {
            return View();
        }

        public IActionResult forgotpassword()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
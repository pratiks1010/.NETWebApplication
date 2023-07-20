using System.Diagnostics;
using BLL;
using BOL;
using HRWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult HrList()

        {

            HrManager hr = new HrManager();
            List<Hr> theHr = hr.getAllHrRecords();
            this.ViewData["theHr"] = theHr;

            return View();
        }






        //Login Page
        public IActionResult Login()
        {
            return View();
        }


        //Register Page
        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
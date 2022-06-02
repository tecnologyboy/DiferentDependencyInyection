using Microsoft.AspNetCore.Mvc;
using MvcDiferentDependencyInyection.Models;
using System.Diagnostics;

namespace MvcDiferentDependencyInyection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingleton _silgleton;

        private readonly ITransient _transient;

        private readonly IScoped _scoped;

        private readonly ISingleton _silgleton2;

        private readonly ITransient _transient2;

        private readonly IScoped _scoped2;


        public HomeController(ISingleton silgleton, ITransient itransient, IScoped scoped, ISingleton silgleton2, ITransient itransient2, IScoped scoped2)
        {
            _silgleton = silgleton;
            _transient = itransient;
            _scoped = scoped;


            _silgleton2 = silgleton2;
            _transient2 = itransient2;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
            ViewBag.singleton = _silgleton;
            ViewBag.transient = _transient;
            ViewBag.scoped = _scoped;

            ViewBag.singleton2 = _silgleton2;
            ViewBag.transient2 = _transient2;
            ViewBag.scoped2 = _scoped2;

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
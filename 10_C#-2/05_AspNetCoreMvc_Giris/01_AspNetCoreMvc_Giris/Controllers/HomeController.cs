using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _01_AspNetCoreMvc_Giris.Models;

namespace _01_AspNetCoreMvc_Giris.Controllers
{
    //En önemli yenilikler;
    //OpenSource bir platform olarak geliştirildi
    //Diğer platform'larda da çalışabilen yapıya sahip, artık core'da geliştirdiğiniz bir projeyi linux ya da apple platformlarında yayınlayabiliriz.
    //Çok ciddi performans gelişimi var.
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

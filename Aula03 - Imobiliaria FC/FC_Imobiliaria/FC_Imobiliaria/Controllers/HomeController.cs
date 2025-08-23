using System.Diagnostics;
using FC_Imobiliaria.Data;
using FC_Imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace FC_Imobiliaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ImobiliariaContext _context;

        public HomeController(ILogger<HomeController> logger, ImobiliariaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Imoveis.ToList());
        }

        public IActionResult Inquilino()
        {
            return View(_context.Inquilinos.ToList());
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

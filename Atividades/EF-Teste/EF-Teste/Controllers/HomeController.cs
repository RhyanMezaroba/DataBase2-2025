using System.Diagnostics;
using EF_Teste.Data;
using EF_Teste.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Variáveis privadas sempre tem precedido com "_ underline" PADRÃO
        private readonly SchoolContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolContext context) // ILogger = Interface de registro de logs
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.ToList());
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
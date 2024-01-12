using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class AudienciaController: Controller
    {

        private readonly ILogger<AudienciaController> _logger;

        public AudienciaController(ILogger<AudienciaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("./Views/Audiencias/Index.cshtml");
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

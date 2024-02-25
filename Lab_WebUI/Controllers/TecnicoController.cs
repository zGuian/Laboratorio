using Lab_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab_WebUI.Controllers
{
    public class TecnicoController : Controller
    {
        private readonly ITecnicoRepository repository;

        public IActionResult Index()
        {
            return View();
        }
    }
}

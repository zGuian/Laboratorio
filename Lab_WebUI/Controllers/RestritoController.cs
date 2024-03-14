using Lab_Application.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Lab_WebUI.Controllers
{
    [PagUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

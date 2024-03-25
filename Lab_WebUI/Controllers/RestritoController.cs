using EFTS_Application.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EFTS_WebUI.Controllers
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
using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_WebUI.Controllers
{
    [Route("Tecnicos")]
    public class TecnicoController : Controller
    {
        private readonly ITecnicoServices _services;

        public TecnicoController(ITecnicoServices services)
        {
            _services = services;
        }

        [Route("lista")]
        public async Task<IActionResult> Index()
        {
            var tecDto = await _services.BuscaTecnicos();
            var model = tecDto.Select(tecDto => new TecnicoModel
            {
                Id = tecDto.Id,
                Nome = tecDto.Nome
            }).ToList();
            return View(model);
        }

        [Route("cadastrotecnico")]
        public IActionResult CadastroTecnico()
        {
            return View();
        }

        [Route("cadastrotecnico")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroTecnico(TecnicoDTO tecnicoDTO)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(CadastroTecnico));
            }
            _services.CadastraTecnico(tecnicoDTO);
            return RedirectToAction(nameof(Index));
        }

        [Route("atualizatecnico")]
        public async Task<IActionResult> AtualizaTecnico(int id)
        {
            var tecDto = await _services.BuscaTecnicosPorId(id);
            var model = new TecnicoModel
            {
                Id = tecDto.Id,
                Nome = tecDto.Nome
            };
            return View(model);
        }

        [Route("atualizatecnico")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AtualizaTecnico(TecnicoDTO tecnicoDTO)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(CadastroTecnico));
            }
            _services.AtualizarTecnico(tecnicoDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}

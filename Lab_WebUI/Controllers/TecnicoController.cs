using EFTS_Application.DTOs;
using EFTS_Application.Filters;
using EFTS_Application.Interfaces;
using EFTS_WebUI.Models.ErrorModels;
using EFTS_WebUI.Models.TecnicoModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFTS_WebUI.Controllers
{
    [Route("Tecnicos")]
    [PagUsuarioLogado]
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
            var model = new CadastraTecnicoModel();
            return View(model);
        }

        [Route("cadastrotecnico")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroTecnico(TecnicoModel tecnicoModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var tecnicoDTO = new TecnicoDTO { Nome = tecnicoModel.Nome };
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
        public IActionResult AtualizaTecnico(int id, TecnicoDTO tecnicoDTO)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(CadastroTecnico));
            }
            _services.AtualizarTecnico(id, tecnicoDTO);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
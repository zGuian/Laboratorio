using Lab_Application.Filters;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;
using Lab_WebUI.Models.UsuariosModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab_WebUI.Controllers
{
    [Route("usuario")]
    [PagUsuarioLogado]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServices _services;

        public UsuarioController(IUsuarioServices services)
        {
            _services = services;
        }

        [Route("lista")]
        public async Task<IActionResult> Index()
        {
            var uDTO = await _services.Buscar();
            var model = uDTO.Select(uDTO => new UsuarioModel
            {
                Id = uDTO.Id,
                Nome = uDTO.Nome,
                Chave = uDTO.Chave,
                Perfil = uDTO.Perfil,
                Senha = uDTO.Senha
            });
            return View(model);
        }

        [Route("cadastro")]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("cadastro")]
        public async Task<IActionResult> Criar(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Algo deu errado");
                return View();
            }
            else
            {
                await _services.Adicionar(usuario);
                return RedirectToAction(nameof(Index));
            }   
        }

        [Route("editar")]
        public async Task<IActionResult> Editar(int id)
        {
            var uDTO = await _services.Buscar(id);
            var model = new UsuarioModel
            {
                Id = uDTO.Id,
                Nome = uDTO.Nome,
                Chave = uDTO.Chave,
                Perfil = uDTO.Perfil,
                Senha = uDTO.Senha
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("editar")]
        public async Task<IActionResult> Editar(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("mensagem", "Algo deu errado");
                return View();
            }
            else
            {
                await _services.Atualizar(id, usuario);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

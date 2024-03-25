using EFTS_Application.DTOs;
using EFTS_Application.Filters;
using EFTS_Application.Interfaces;
using EFTS_Domain.Entities;
using EFTS_WebUI.Models.UsuariosModels;
using Microsoft.AspNetCore.Mvc;

namespace EFTS_WebUI.Controllers
{
    [Route("usuario")]
    [PagSomenteAdmin]
    public class UsuarioController(IUsuarioServices services) : Controller
    {
        private readonly IUsuarioServices _services = services;

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
            var model = new CadastraUsuarioModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("cadastro")]
        public async Task<IActionResult> Criar(UsuarioDTO uDTO)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Algo deu errado");
                return View();
            }
            else
            {
                bool resp = await _services.Adicionar(uDTO);
                if (resp != false)
                {
                    return RedirectToAction(nameof(Index));
                }
                TempData["MensagemErro"] = $"Ops! Ocorreu um problema ao criar usuário.";
                return View();
            }
        }

        [Route("editar/{id:int}")]
        public async Task<IActionResult> Editar(int id)
        {
            var uDTO = await _services.Buscar(id);
            var model = new AtualizaUsuarioModel
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
        [Route("editar/{id:int}")]
        public async Task<IActionResult> Editar(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Algo deu errado");
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
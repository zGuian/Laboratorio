using Lab_Application.Interfaces;
using Lab_WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Lab_WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioServices _services;
        private readonly ISessaoHelper _sessao;

        public LoginController(IUsuarioServices services, ISessaoHelper sessao)
        {
            _services = services;
            _sessao = sessao;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            if(_sessao.BuscarSessaoUsuario() != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [Route("entrar")]
        public async Task<IActionResult> Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await _services.Buscar(loginModel.Login);
                    if (usuario != null)
                    {
                        if (usuario.ValidaSenha(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"OPS! Senha invalida. Tente novamente.";
                            return View(nameof(Index));
                        }
                    }
                    else
                    {
                        TempData["MensagemErro"] = $"Ops, houve um erro. Tente novamente.";
                        return View(nameof(Index));
                    }
                }
                else
                {
                    return View(nameof(Index));
                }
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, houve um erro. Detalhe do erro: {erro.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction(nameof(Index));
        }
    }
}

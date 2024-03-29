﻿using Lab_Application.Interfaces;
using Lab_WebUI.Models.LoginModels;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            var sUsuario = _sessao.BuscarSessaoUsuario();
            if (sUsuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await _services.Buscar(loginModel.Login);
                    if (usuario != null)
                    {
                        var uValidado = await _services.ValidaUsuario(usuario);
                        if (uValidado == true)
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"OPS! Senha invalida. Tente novamente.";
                        return View(nameof(Index));
                    }
                    TempData["MensagemErro"] = $"Ops, houve um erro. Tente novamente.";
                    return View(nameof(Index));
                }
                return View(nameof(Index));
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

        public IActionResult PrimeiroLogin()
        {
            var sUsuario = _sessao.BuscarSessaoUsuario();
            if (sUsuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PrimeiroLogin(PrimeiroLoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = await _services.Buscar(loginModel.Login);
                    if (usuario != null)
                    {
                        var uValidado = await _services.ValidaUsuario(usuario);
                        if (uValidado == true)
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Editar", "Usuario", new { usuario.Id });
                        }
                        TempData["MensagemErro"] = $"OPS! Senha invalida. Tente novamente.";
                        return View(nameof(Index));
                    }
                    TempData["MensagemErro"] = $"Ops, houve um erro. Tente novamente.";
                    return View(nameof(Index));
                }
                TempData["MensagemErro"] = "Houve um erro ao validar seu acesso. Solicite ajude a um administrator";
                return View(nameof(Index));
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, houve um erro. Detalhe do erro: {erro.Message}";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

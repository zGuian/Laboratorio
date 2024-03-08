using Lab_Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab_WebUI.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sUsuario))
            {
                return null!;
            }
            else
            {
                var usuario = JsonConvert.DeserializeObject<Usuario>(sUsuario);
                return View(usuario);
            }
        }
    }
}

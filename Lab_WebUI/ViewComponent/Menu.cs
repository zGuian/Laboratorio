using EFTS_WebUI.Models.UsuariosModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EFTS_WebUI.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sUsuario))
            {
                return null;
            }
            else
            {
                var usuario = JsonConvert.DeserializeObject<UsuarioModel>(sUsuario);
                return View(usuario);
            }
        }
    }
}
using Lab_Application.Interfaces;
using Lab_Domain.Entities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Lab_Application.Helper
{
    public class SessaoHelper : ISessaoHelper
    {
        private readonly IHttpContextAccessor _httpContext;

        public SessaoHelper(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public Usuario BuscarSessaoUsuario()
        {
            var sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaousuariologado");
            if (sessaoUsuario == null || sessaoUsuario == string.Empty)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);
            }
        }

        public void CriarSessaoUsuario(Usuario usuario)
        {
            var objString = JsonConvert.SerializeObject(usuario);
            _httpContext.HttpContext.Session.SetString("sessaousuariologado", objString);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaousuariologado");
        }

    }
}

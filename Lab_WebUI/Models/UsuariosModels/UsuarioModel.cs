using EFTS_Domain.Enums;
using System.ComponentModel;

namespace EFTS_WebUI.Models.UsuariosModels
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public PerfilEnum Perfil { get; set; }

        [PasswordPropertyText]
        public string Senha { get; set; }
    }
}
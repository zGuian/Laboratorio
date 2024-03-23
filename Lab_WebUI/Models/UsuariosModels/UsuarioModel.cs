using Lab_Domain.Enums;
using System.ComponentModel;

namespace Lab_WebUI.Models.UsuariosModels
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

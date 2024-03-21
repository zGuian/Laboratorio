using Lab_Application.Validators;
using Lab_Domain.Enums;
using System.ComponentModel;

namespace Lab_WebUI.Models.UsuariosModels
{
    public class AtualizaUsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public EnumPerfil Perfil { get; set; }

        [ChecaForcaSenhaValidator]
        [PasswordPropertyText]
        public string Senha { get; set; }
    }
}

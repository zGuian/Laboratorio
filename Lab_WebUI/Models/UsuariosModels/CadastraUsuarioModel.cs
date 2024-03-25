using EFTS_Application.Validators;
using EFTS_Domain.Enums;
using System.ComponentModel;

namespace EFTS_WebUI.Models.UsuariosModels
{
    public class CadastraUsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public PerfilEnum Perfil { get; set; }

        [ChecaForcaSenhaValidator]
        [PasswordPropertyText]
        public string Senha { get; set; }
    }
}
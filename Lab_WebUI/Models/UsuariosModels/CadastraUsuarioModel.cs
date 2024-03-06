using Lab_Domain.Enums;

namespace Lab_WebUI.Models.UsuariosModels
{
    public class CadastraUsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public EnumPerfil Perfil { get; set; }
        public string Senha { get; set; }
    }
}

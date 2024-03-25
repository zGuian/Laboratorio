using EFTS_Domain.Enums;

namespace EFTS_Application.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public PerfilEnum Perfil { get; set; }
        public string Senha { get; set; }
    }
}
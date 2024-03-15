using Lab_Domain.Enums;

namespace Lab_Application.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chave { get; set; }
        public EnumPerfil Perfil { get; set; }
        public string Senha { get; set; }

        //public bool SenhaValidada(string senha)
        //{
        //    if (Senha == senha.GeraHash())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public void SetSenhaHash()
        //{
        //    Senha = Senha.GeraHash();
        //}
    }
}

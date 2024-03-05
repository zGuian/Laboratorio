using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface ISessaoHelper
    {
        void CriarSessaoUsuario(Usuario usuario);
        void RemoverSessaoUsuario();
        Usuario BuscarSessaoUsuario();
    }
}

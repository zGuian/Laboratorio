using EFTS_Domain.Entities;

namespace EFTS_Application.Interfaces
{
    public interface ISessaoHelper
    {
        void CriarSessaoUsuario(Usuario usuario);

        void RemoverSessaoUsuario();

        Usuario BuscarSessaoUsuario();
    }
}
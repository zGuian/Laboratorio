using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IUsuarioServices
    {
        public Task<Usuario> Buscar(string login);
        public Task<IEnumerable<UsuarioDTO>> Buscar();
        public Task<UsuarioDTO> Buscar(int id);
        public Task<Usuario> Adicionar(UsuarioDTO usuario);
        public void Atualizar(int id, Usuario usuario);
        Task<bool> ValidaUsuario(Usuario usuario);
    }
}

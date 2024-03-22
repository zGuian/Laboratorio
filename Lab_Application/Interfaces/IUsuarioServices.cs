using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IUsuarioServices
    {
        public Task<Usuario> Buscar(string login);
        public Task<IEnumerable<UsuarioDTO>> Buscar();
        public Task<UsuarioDTO> Buscar(int id);
        public Task<bool> Adicionar(UsuarioDTO usuario);
        public Task<Task> Atualizar(int id, Usuario usuario);
        Task<bool> ValidaUsuario(Usuario usuario);
    }
}

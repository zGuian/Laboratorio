using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IUsuarioServices
    {
        public Task<Usuario> Buscar(string login);
        public Task<IEnumerable<Usuario>> Buscar();
        public Task<Usuario> Buscar(int id);
        public Task<Usuario> Adicionar(Usuario usuario);
        public Task<Usuario> Atualizar(int id, Usuario usuario);
    }
}

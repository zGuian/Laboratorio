using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IUsuarioRepository : IDisposable
    {
        public Task<Usuario> BuscarAsync(string login);
        public Task<IEnumerable<Usuario>> BuscarAsync();
        public Task<Usuario> BuscarAsync(int id);
        public Task<bool> AdicionarAsync(Usuario usuario);
        public Task Atualizar(int id, Usuario usuario);
        public Task Apagar(int id);
    }
}

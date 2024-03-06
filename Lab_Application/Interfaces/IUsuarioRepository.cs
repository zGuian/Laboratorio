using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IUsuarioRepository : IDisposable
    {
        public Task<Usuario> BuscarAsync(string login);
        public Task<IEnumerable<Usuario>> BuscarAsync();
        public Task<Usuario> BuscarAsync(int id);
        public Task<Usuario> AdicionarAsync(Usuario usuario);
        public Task<Usuario> AtualizarAsync(int id, Usuario usuario);
        public void Apagar(int id);
    }
}

using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Application.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioServices(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            return await _repository.AdicionarAsync(usuario);
        }

        public async Task<Usuario> Atualizar(int id, Usuario usuario)
        {
            return await _repository.AtualizarAsync(id, usuario);
        }

        public async Task<Usuario> Buscar(string login)
        {
            return await _repository.BuscarAsync(login);
        }

        public async Task<IEnumerable<Usuario>> Buscar()
        {
            return await _repository.BuscarAsync();
        }

        public async Task<Usuario> Buscar(int id)
        {
            return await _repository.BuscarAsync(id);
        }
    }
}

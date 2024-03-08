using AutoMapper;
using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Application.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioServices(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Usuario> Buscar(string login)
        {

            return await _repository.BuscarAsync(login);
        }

        public async Task<IEnumerable<UsuarioDTO>> Buscar()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(
                await _repository.BuscarAsync());
        }

        public async Task<UsuarioDTO> Buscar(int id)
        {
            return _mapper.Map<UsuarioDTO>(await _repository.BuscarAsync(id));
        }

        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            return await _repository.AdicionarAsync(usuario);
        }

        public async Task<Usuario> Atualizar(int id, Usuario usuario)
        {
            return await _repository.AtualizarAsync(id, usuario);
        }
    }
}

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

        public async Task<bool> Adicionar(UsuarioDTO uDTO)
        {
            var verificaChave = await _repository.BuscarAsync(uDTO.Chave);
            if (verificaChave == null)
            {
                var usuario = _mapper.Map<Usuario>(uDTO);
                GeraHashSenhaUser.ConverteSenhaEmHash(usuario);
                bool uResposta = await _repository.AdicionarAsync(usuario);
                if (uResposta != false)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public async Task<Task> Atualizar(int id, Usuario usuario)
        {
            await _repository.Atualizar(id, usuario);
            return Task.CompletedTask;
        }

        public async Task<bool> ValidaUsuario(Usuario usuario)
        {
            var uConsultado = await _repository.BuscarAsync(usuario.Chave);
            if (uConsultado == null)
            {
                return false;
            }
            var verifica = GeraHashSenhaUser.ValidaAtualizaHashAsync(usuario, usuario.Senha);
            if (verifica != false)
            {
                throw new NotImplementedException();
            }
            return true;
        }
    }
}

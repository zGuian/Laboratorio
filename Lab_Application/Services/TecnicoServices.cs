using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Application.Interfaces;
using EFTS_Domain.Entities;

namespace EFTS_Application.Services
{
    public class TecnicoServices : ITecnicoServices
    {
        private readonly ITecnicoRepository _repository;
        private readonly IMapper _mapper;

        public TecnicoServices(ITecnicoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TecnicoDTO>> BuscaTecnicos()
        {
            return await _repository.GetTecnicoAsync();
        }

        public async Task<TecnicoDTO> BuscaTecnicosPorId(int id)
        {
            return await _repository.GetTecnicoAsync(id);
        }

        public async Task<TecnicoDTO> BuscaTecnicoPorNome(string nome)
        {
            return await _repository.GetTecnicoAsync(nome);
        }

        public void CadastraTecnico(TecnicoDTO tecnicoDto)
        {
            var tecnico = _mapper.Map<Tecnico>(tecnicoDto);
            _repository.InserirTecnico(tecnico);
        }

        public void AtualizarTecnico(int id, TecnicoDTO tecnicoDTO)
        {
            var tecnico = _mapper.Map<Tecnico>(tecnicoDTO);
            _repository.AtualizaTecnico(id, tecnico);
        }
    }
}
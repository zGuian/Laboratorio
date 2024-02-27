using AutoMapper;
using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Application.Services
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

        public void CadastraTecnico(TecnicoDTO tecnicoDto)
        {
            var tecnico = _mapper.Map<Tecnico>(tecnicoDto);
            _repository.InserirTecnico(tecnico);
        }

        public void AtualizarTecnico(TecnicoDTO tecnicoDTO)
        {
            var tecnico = _mapper.Map<Tecnico>(tecnicoDTO);
            _repository.InserirTecnico(tecnico);
        }
    }
}

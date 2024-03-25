using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Application.Interfaces;
using EFTS_Domain.Entities;

namespace EFTS_Application.Services
{
    public class LaboratorioServices : ILaboratorioServices
    {
        private readonly ILaboratorioRepository _repository;
        private readonly IMapper _mapper;

        public LaboratorioServices(ILaboratorioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LaboratorioDTO>> BuscaEquipAsync()
        {
            return await _repository.GetEquipamentoAsync();
        }

        public async Task<LaboratorioDTO> BuscaEquipPorIdAsync(int id)
        {
            return await _repository.GetEquipamentoAsync(id);
        }

        public async Task<LaboratorioDTO> BuscaEquipPorInventarioAsync(string inventario)
        {
            return await _repository.GetEquipamentoAsync(inventario);
        }

        public void CadastraEquipamento(LaboratorioDTO labDTO)
        {
            var lab = _mapper.Map<Laboratorio>(labDTO);
            _repository.InserirEquipamento(lab);
        }

        public void AtualizaEquipamento(int id, LaboratorioDTO labDTO)
        {
            var lab = _mapper.Map<Laboratorio>(labDTO);
            _repository.AtualizaEquipamento(id, lab);
        }
    }
}
using AutoMapper;
using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Application.Services
{
    internal class EquipamentoServices : IEquipamentoServices
    {
        private readonly IEquipamentoRepository _repository;
        private readonly IMapper _mapper;

        public EquipamentoServices(IEquipamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EquipamentoDTO>> BuscaEquipAsync()
        {
            return await _repository.GetEquipamentoAsync();
        }

        public async Task<EquipamentoDTO> BuscaEquipPorIdAsync(int id)
        {
            return await _repository.GetEquipamentoAsync(id);
        }

        public async Task<EquipamentoDTO> BuscaEquipPorInventarioAsync(string inventario)
        {
            return await _repository.GetEquipamentoAsync(inventario);
        }

        public void CadastraEquipamento(EquipamentoDTO equipDTO)
        {
            var equip = _mapper.Map<Equipamento>(equipDTO);
            _repository.InserirEquipamento(equip);
        }

        public void AtualizaEquipamento(int id, EquipamentoDTO equipDTO)
        {
            var equip = _mapper.Map<Equipamento>(equipDTO);
            _repository.AtualizaEquipamento(id, equip);
        }
    }
}

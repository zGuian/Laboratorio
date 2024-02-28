using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IEquipamentoRepository
    {
        void AtualizaEquipamento(int id, Equipamento equip);
        Task<IEnumerable<EquipamentoDTO>> GetEquipamentoAsync();
        Task<EquipamentoDTO> GetEquipamentoAsync(int id);
        Task<EquipamentoDTO> GetEquipamentoAsync(string inventario);
        void InserirEquipamento(Equipamento equip);
    }
}

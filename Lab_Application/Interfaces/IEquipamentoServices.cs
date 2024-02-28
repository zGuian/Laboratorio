using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface IEquipamentoServices
    {
        Task<IEnumerable<EquipamentoDTO>> BuscaEquipAsync();
        Task<EquipamentoDTO> BuscaEquipPorInventarioAsync(string inventario);
        Task<EquipamentoDTO> BuscaEquipPorIdAsync(int id);
        void AtualizaEquipamento(int id, EquipamentoDTO equipDTO);
        void CadastraEquipamento(EquipamentoDTO equipDTO);
    }
}

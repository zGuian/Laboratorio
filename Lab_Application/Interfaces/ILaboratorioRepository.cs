using Lab_Application.DTOs;
using Lab_Domain.Entities;

namespace Lab_Application.Interfaces
{
    public interface ILaboratorioRepository
    {
        Task<IEnumerable<LaboratorioDTO>> GetEquipamentoAsync();
        Task<LaboratorioDTO> GetEquipamentoAsync(int id);
        Task<LaboratorioDTO> GetEquipamentoAsync(string inventario);
        void AtualizaEquipamento(int id, Laboratorio laboratorio);
        void InserirEquipamento(Laboratorio laboratorio);
    }
}

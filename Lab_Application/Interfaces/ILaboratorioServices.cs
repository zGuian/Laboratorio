using EFTS_Application.DTOs;

namespace EFTS_Application.Interfaces
{
    public interface ILaboratorioServices
    {
        Task<IEnumerable<LaboratorioDTO>> BuscaEquipAsync();

        Task<LaboratorioDTO> BuscaEquipPorInventarioAsync(string inventario);

        Task<LaboratorioDTO> BuscaEquipPorIdAsync(int id);

        void AtualizaEquipamento(int id, LaboratorioDTO equipDTO);

        void CadastraEquipamento(LaboratorioDTO equipDTO);
    }
}
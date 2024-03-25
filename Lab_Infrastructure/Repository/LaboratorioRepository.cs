using EFTS_Application.DTOs;
using EFTS_Application.Interfaces;
using EFTS_Domain.Entities;

namespace Lab_Infrastructure.Repository
{
    public class LaboratorioRepository : ILaboratorioRepository
    {
        private readonly ISqlDataAcess _dataAcess;

        public LaboratorioRepository(ISqlDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }

        public async Task<IEnumerable<LaboratorioDTO>> GetEquipamentoAsync()
        {
            return await _dataAcess.LoadData<LaboratorioDTO, dynamic>("[dbo].[Onsite-Lab_GetAll]", new { });
        }

        public async Task<LaboratorioDTO> GetEquipamentoAsync(int id)
        {
            var equip = await _dataAcess.LoadData<LaboratorioDTO, dynamic>("[dbo].[Onsite-Lab_GetById]", new { id });
            return equip.FirstOrDefault() ?? throw new Exception();
        }

        public async Task<LaboratorioDTO> GetEquipamentoAsync(string inventario)
        {
            var equip = await _dataAcess.LoadData<LaboratorioDTO, dynamic>("[dbo].[Onsite-Lab_GetByInv]", new { inventario });
            return equip.FirstOrDefault() ?? throw new Exception();
        }

        public async void InserirEquipamento(Laboratorio laboratorio)
        {
            await _dataAcess.SaveData("[dbo].[Onsite-Lab_Insert]", new { laboratorio });
        }

        public async void AtualizaEquipamento(int id, Laboratorio laboratorio)
        {
            await _dataAcess.SaveData("[dbo].[Onsite-Lab_Update]", new { id, laboratorio });
        }
    }
}
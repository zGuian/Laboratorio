using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Infrastructure.Repository
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        private readonly ISqlDataAcess _dataAcess;

        public EquipamentoRepository(ISqlDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }

        public async Task<IEnumerable<EquipamentoDTO>> GetEquipamentoAsync()
        {
            var equipDTO = await _dataAcess.LoadData<EquipamentoDTO, dynamic>("[dbo].[labEquipamento_GetAll]", new { });
            return equipDTO;
        }

        public async Task<EquipamentoDTO> GetEquipamentoAsync(int id)
        {
            var equip = await _dataAcess.LoadData<EquipamentoDTO, dynamic>("[dbo].[labEquipamento_GetById]", new { id });
            return equip.FirstOrDefault() ?? throw new Exception();
        }

        public async Task<EquipamentoDTO> GetEquipamentoAsync(string inventario)
        {
            var equip = await _dataAcess.LoadData<EquipamentoDTO, dynamic>("[dbo].[labEquipamento_GetByInv", new { inventario });
            return equip.FirstOrDefault() ?? throw new Exception();
        }

        public async void InserirEquipamento(Equipamento equip)
        {
            await _dataAcess.SaveData("[dbo].[labEquipamento_Insert]", new { equip });
        }

        public async void AtualizaEquipamento(int id, Equipamento equip)
        {
            await _dataAcess.SaveData("[dbo].[labEquipamento_Update]", new { id, equip });
        }
    }
}

using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Entities;

namespace Lab_Infrastructure.Repository
{
    public class TecnicoRepository : ITecnicoRepository
    {
        private readonly ISqlDataAcess _dataAcess;

        public TecnicoRepository(ISqlDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }

        public async Task<IEnumerable<TecnicoDTO>> GetTecnicoAsync()
        {
            var tecDTO = await _dataAcess.LoadData<TecnicoDTO, dynamic>("[dbo].[labTecnico_GetAll]", new { });
            return tecDTO;
        }

        public async Task<TecnicoDTO> GetTecnicoAsync(int id)
        {
            var tecnico = await _dataAcess.LoadData<TecnicoDTO, dynamic>("[dbo].[labTecnico_GetById]", new { id });
            return tecnico.FirstOrDefault() ?? throw new Exception();
        }

        public async Task<TecnicoDTO> GetTecnicoAsync(string nome)
        {
            var tecnico = await _dataAcess.LoadData<TecnicoDTO, dynamic>("[dbo].[labTecnico_GetByName", new { nome });
            return tecnico.FirstOrDefault() ?? throw new Exception();
        }

        public async void InserirTecnico(Tecnico tecnico)
        {
            await _dataAcess.SaveData("[dbo].[labTecnico_Insert]", new { tecnico.Nome });
        }

        public async void AtualizaTecnico(int id, Tecnico tecnico)
        {
            await _dataAcess.SaveData("[dbo].[labTecnico_UpdateTec]", tecnico);
        }
    }
}
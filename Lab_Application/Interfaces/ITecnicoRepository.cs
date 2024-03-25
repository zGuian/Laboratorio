using EFTS_Application.DTOs;
using EFTS_Domain.Entities;

namespace EFTS_Application.Interfaces
{
    public interface ITecnicoRepository
    {
        Task<IEnumerable<TecnicoDTO>> GetTecnicoAsync();

        Task<TecnicoDTO> GetTecnicoAsync(int id);

        Task<TecnicoDTO> GetTecnicoAsync(string nome);

        void InserirTecnico(Tecnico tecnico);

        void AtualizaTecnico(int id, Tecnico tecnico);
    }
}